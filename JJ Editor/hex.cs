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

            df = new DynamicFileByteProvider(directory + "/" + filename);
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
    }
}
