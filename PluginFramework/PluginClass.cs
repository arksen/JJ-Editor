using System.Windows.Forms;

namespace PluginFramework
{
    public interface IForm
    {
        Form window(Form src);
        string name { get; }
    }
}
