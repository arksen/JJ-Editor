using System;
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

namespace JJ_Editor
{
    public partial class main : Form
    {
        public ToolStripStatusLabel statusLabelPlayer;
        public main()
        {
            InitializeComponent();
            statusLabelPlayer = statusLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Ready!";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        string dir = @"C:\Users\Willem\AppData\Roaming\Junk Jack\players";
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
                    player = new Player(dir, fileName, autoSaveCheck, orderCheck);
                    player.MdiParent = this;
                    player.Text = fileName;
                    player.Show();
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

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            player = null;
        }

        about ab;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ab == null)
            {
                ab = new about();
                ab.MdiParent = this;
                ab.FormClosed += Ab_FormClosed;
                ab.Show();
                statusLabel.Text = "Version 0.3";
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
    }
}
