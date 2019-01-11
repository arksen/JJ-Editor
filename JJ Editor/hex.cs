using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace JJ_Editor
{
    public partial class hex : Form
    {

        ByteViewer bv = new ByteViewer();
        public string directory;
        public string filename;
        public hex(string dir, string fileName)
        {
            InitializeComponent();

            directory = dir;
            filename = fileName;
            bv.Dock = DockStyle.Fill;
            bv.SetBytes(new byte[] { });
            bv.SetFile(directory + "/" + filename);
            bv.BorderStyle = BorderStyle.None;
            Controls.Add(bv);
        }

        private void hex_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bv.SaveToFile(directory + "/" + filename);
        }
    }
}
