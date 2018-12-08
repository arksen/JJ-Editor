using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJ_Editor
{
    public partial class conversion : Form
    {
        public conversion()
        {
            InitializeComponent();
        }

        private void decText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            if (hexText.Text == "" && decText.Text != "")
            {
                int hexValue = int.Parse(decText.Text);
                hexText.Text = IDToHex.idToHex(hexValue);
            }

            if (decText.Text == "" && hexText.Text != "")
            {
                char[] decValue = hexText.Text.ToCharArray();
                HexToID.hexToID(decValue);
                string resultHex = new string(decValue);

                if (resultHex == "FFFF")
                {
                    //isEmpty = true;
                }
                else if (resultHex.EndsWith("0"))
                {
                    resultHex = resultHex.Substring(0, resultHex.Length - 1);
                }

                int resultHex2 = Convert.ToInt32(resultHex, 16);
                decText.Text = resultHex2.ToString();
            }
        }
    }
}
