using System;
using System.Windows.Forms;

namespace Torm_OOP_KT2_CSharp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KT_Form1());
        }
    }
}
