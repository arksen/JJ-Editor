﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using PluginFramework;

namespace JJ_Editor
{
    public partial class main : Form
    {
        string curDir = Directory.GetCurrentDirectory();
        public ToolStripStatusLabel statusLabelPlayer;
        Dictionary<string, IForm> plugins = new Dictionary<string, IForm>();
        public main()
        {
            InitializeComponent();
            statusLabelPlayer = statusLabel;

            var assembly = Assembly.GetExecutingAssembly();
            var folder = Path.GetDirectoryName(assembly.Location);

            LoadPlugins(folder);
            createPluginMenu();

            var separator = new ToolStripSeparator();
            toolsToolStripMenuItem.DropDownItems.Add(separator);
            var addTool = new ToolStripMenuItem("Add Tool", null, addToolToolStripMenuItem_Click);
            toolsToolStripMenuItem.DropDownItems.Add(addTool);
        }

        void LoadPlugins(string folder)
        {
            plugins.Clear();
            foreach(var dll in Directory.GetFiles(folder, "*.dll"))
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    foreach(var type in asm.GetTypes())
                    {
                        if(type.GetInterface("IForm") == typeof(IForm))
                        {
                            var plugin = Activator.CreateInstance(type) as IForm;
                            plugins[plugin.name] = plugin;
                        }
                    }
                }
                catch (FileLoadException) { }
            }
        }

        void createPluginMenu()
        {
            foreach(KeyValuePair<string, IForm> pair in plugins)
            {
                var item = new ToolStripMenuItem(pair.Key);
                item.Click += new EventHandler(menuItem_Click);
                toolsToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var thePlugin = plugins[menuItem.Text];

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Form form = new Form();

                form = thePlugin.window(form);
                form.MdiParent = this;
                form.Show();
            }
            catch(Exception ex)
            {
                // In case the plugin fucks up
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Ready!";

            //d BackgroundWorker bw = new BackgroundWorker();

            WebClient client = new WebClient();
            WebRequest versionUrl = WebRequest.Create(new Uri("https://raw.githubusercontent.com/arksen/JJ-Editor/master/version.txt"));
            WebResponse ws = versionUrl.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());
            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string latestVersion = sr.ReadLine();

            // Download update when program is not up to date
            if (Version.Parse(currentVersion) < Version.Parse(latestVersion))
            {
                if (MessageBox.Show("There is an update available " + latestVersion + "\nWould you like to download it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    try
                    {
                        client.DownloadFile("https://github.com/arksen/JJ-Editor/releases/latest/download/JJ.Editor.rar", Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads/JJ.Editor.rar");
                        MessageBox.Show("Update successfully downloaded!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to download update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                    client.Dispose();

                    Process.Start(Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads/JJ.Editor.rar");
                    Environment.Exit(0);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        string dir = Environment.GetEnvironmentVariable("USERPROFILE")+@"\AppData\Roaming\Junk Jack\players";
        string fileName = "";
        bool fileSelected = true;
        bool autoSaveCheck = false;
        bool orderCheck = true;

        Player player;
        private void playerFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (autoSave.CheckState == CheckState.Checked)
            {
                autoSaveCheck = true;
            }
            if (orderOption.CheckState == CheckState.Checked)
            {
                orderCheck = true;
            }
            else
            {
                orderCheck = false;
            }

            statusLabel.Text = "Waiting...";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".dat file only|*.dat";

            void chooseFile()
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = Path.GetFileName(ofd.FileName);
                } else
                {
                    fileSelected = false;
                }
            }

            Player player;
            void createWindow()
            {
                if (fileSelected == true)
                {
                    // Check if file is already in use
                    try
                    {
                        using (FileStream fs = new FileStream(dir + "/" + fileName, FileMode.Open, FileAccess.Read))
                        {
                            player = new Player(dir, fileName, autoSaveCheck, orderCheck);
                            player.MdiParent = this;
                            player.Text = fileName;
                            player.Show();
                            statusLabel.Text = fileName + " loaded"; 
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("File is currently being used by another process", "JJ Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    /*player = new Player(dir, fileName, autoSaveCheck, orderCheck);
                    player.MdiParent = this;
                    player.Text = fileName;
                    player.Show();
                    statusLabel.Text = fileName + " loaded";*/
                }
            }

            // Check if save directory exists
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, "*.dat");

                if (files.Length > 1)
                {
                    ofd.InitialDirectory = dir;
                    chooseFile();
                    fileName = Path.GetFileName(ofd.FileName);
                    createWindow();
                    return;
                }
                else if (files.Length < 1)
                {
                    chooseFile();
                    fileName = Path.GetFileName(ofd.FileName);
                    createWindow();
                    return;
                }
                else
                {
                    fileName = Path.GetFileName(files[0]);
                    createWindow();
                    return;
                }

            }
            else
            {
                //MessageBox.Show("Directory does not exist.");
                chooseFile();
                fileName = Path.GetFileName(ofd.FileName);
                dir = Path.GetDirectoryName(ofd.FileName);
                createWindow();
            }

            
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            player = null;
        }

        AboutBox1 ab;
        private void aboutJJEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ab == null)
            {
                ab = new AboutBox1();
                ab.MdiParent = this;
                ab.FormClosed += Ab_FormClosed;
                ab.Show();
                statusLabel.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            } else
            {
                ab.Activate();
            }
        }

        private void Ab_FormClosed(object sender, FormClosedEventArgs e)
        {
            ab = null;
            //throw new NotImplementedException();
        }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversion conv = new conversion();
            conv.MdiParent = this;
            conv.Show();
        }

        private void hexEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".dat file only|*.dat";

            void chooseFile()
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = Path.GetFileName(ofd.FileName);
                }
                else
                {
                    fileSelected = false;
                }
            }

            hex Hex;
            void createWindow()
            {
                if (fileSelected == true)
                {
                    Hex = new hex(dir, fileName);
                    Hex.MdiParent = this;
                    Hex.Text = fileName;
                    Hex.Show();
                    statusLabel.Text = fileName + " loaded";
                }
            }

            // Check if save directory exists
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, "*.dat");

                if (files.Length > 1)
                {
                    ofd.InitialDirectory = dir;
                    chooseFile();
                    fileName = Path.GetFileName(ofd.FileName);
                    createWindow();
                    return;
                }
                else if (files.Length < 1)
                {
                    chooseFile();
                    fileName = Path.GetFileName(ofd.FileName);
                    createWindow();
                    return;
                }
                else
                {
                    fileName = Path.GetFileName(files[0]);
                    createWindow();
                    return;
                }

            }
            else
            {
                //MessageBox.Show("Directory does not exist.");
                chooseFile();
                fileName = Path.GetFileName(ofd.FileName);
                dir = Path.GetDirectoryName(ofd.FileName);
                createWindow();
            }
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/arksen/JJ-Editor");
        }

        private void updateEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(curDir);
        }

        private void addToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dllPath;
            string dllName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".dll file only|*.dll";
            ofd.InitialDirectory = curDir;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dllPath = Path.GetDirectoryName(ofd.FileName);
                dllName = Path.GetFileName(ofd.FileName);
                File.Move(dllPath + "/" + dllName, curDir + "/" + dllName);

                toolsToolStripMenuItem.DropDownItems.Clear();

                var assembly = Assembly.GetExecutingAssembly();
                var folder = Path.GetDirectoryName(assembly.Location);

                LoadPlugins(folder);
                createPluginMenu();

                var separator = new ToolStripSeparator();
                toolsToolStripMenuItem.DropDownItems.Add(separator);
                var addTool = new ToolStripMenuItem("Add Tool", null, addToolToolStripMenuItem_Click);
                toolsToolStripMenuItem.DropDownItems.Add(addTool);
            }
            else
            {
                // File not opened
            }
        }
    }
}
