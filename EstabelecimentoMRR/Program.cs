using EstabelecimentoMRR.UI.Principal;
using System;
using System.Windows.Forms;
using EstabelecimentoMRR.UI.Login;
using EstabelecimentoMRR.UI.Despesa;

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

            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new FormDespesaCadastro());
            }
        }
    }
}
