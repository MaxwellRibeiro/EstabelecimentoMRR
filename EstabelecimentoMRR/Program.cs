using EstabelecimentoMRR.UI.Principal;
using System;
using System.Windows.Forms;
using EstabelecimentoMRR.UI.Login;

namespace EstabelecimentoMRR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
