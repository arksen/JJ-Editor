using System.Windows.Forms;
using System.Drawing;
using PluginFramework;

namespace Decompress
{
    public partial class decompressForm : IForm
    {
        public string name => "Decompress";

        public Form window(Form src)
        {
            Label label = new Label();
            TextBox pathBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            label.Text = "Enter the path of .dat:";
            buttonOk.Text = "Decompress";
            buttonCancel.Text = "Cancel";

            label.SetBounds(9, 20, 372, 13);
            pathBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            src.ClientSize = new Size(396, 107);
            src.Controls.AddRange(new Control[] { label, pathBox, buttonOk, buttonCancel });
            src.FormBorderStyle = FormBorderStyle.FixedSingle;

            src.MaximizeBox = false;
            src.MinimizeBox = false;

            src.CancelButton = buttonCancel;

            return src;
        }
    }
}
