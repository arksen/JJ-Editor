using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using Be.Windows.Forms;

namespace JJ_Editor
{
    public partial class hex : Form
    {
        public string directory;
        public string filename;
        DynamicFileByteProvider df;
        public hex(string dir, string fileName)
        {
            InitializeComponent();

            directory = dir;
            filename = fileName;
            //bv.Dock = DockStyle.Fill;
            //bv.SetBytes(new byte[] { });
            //bv.SetFile(directory + "/" + filename);
            //bv.BorderStyle = BorderStyle.None;
            //Controls.Add(bv);

            df = new DynamicFileByteProvider(directory + "/" + fileName);
            hexBox.ByteProvider = df;

            hexBox.InsertActive = true;

            playerName.Text = fileName;
            FileInfo fi = new FileInfo(directory + "/" + filename);
            long fLength = fi.Length;
            fileSize.Text = fLength.ToString() + " bytes";
            subsets.Text = "[Modifier, Unknown, Item ID, Amount, Durability, Toggle]";

        }

        private void hex_Load(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.ApplyChanges();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            df.Dispose();
            this.Close();
        }

        private void stringViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(stringViewToolStripMenuItem.CheckState == CheckState.Checked)
            {
                hexBox.StringViewVisible = true;
            }
            else if (stringViewToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                hexBox.StringViewVisible = false;
            }
        }

        private void hexBox_SelectionStartChanged(object sender, EventArgs e)
        {
            offsetText.Text = string.Format("Line: {0} Column: {1}", hexBox.CurrentLine, hexBox.CurrentPositionInLine);
        }

        private void bytesText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void offsetTextBox_TextChanged(object sender, EventArgs e)
        {
            if(offsetTextBox.Text == "")
            {
                hexBox.SelectionStart = 0;
            }
            else if (int.Parse(offsetTextBox.Text) > hexBox.ByteProvider.Length)
            {
                hexBox.SelectionStart = 0;
            }
            else
            {
                hexBox.SelectionStart = int.Parse(offsetTextBox.Text);
            }
        }
    }
}
