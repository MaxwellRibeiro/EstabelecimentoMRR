using System.Windows.Forms;
using EstabelecimentoMRR.Repository;
using EstabelecimentoMRR.UI.Usuario;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EstabelecimentoMRR.UI.Login
{
    public partial class FormLogin : MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

            // Criando um material theme manager e adicionando o formulário
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //// Definindo um esquema de Cor para formulário com tom Azul
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Red800,
            //    Primary.Red900,
            //    Primary.Red900,
            //    Accent.Red700,
            //    TextShade.WHITE
            //);
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange700,
                TextShade.WHITE
            );
        }

        private void FormLogin_Load(object sender, System.EventArgs e)
        {

        }

        private void lblCadastrar_Click(object sender, System.EventArgs e)
        {
            var frm = new FormCadastroUsuario();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var rep = new UsuarioRep();
            var usuario = rep.Login(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                Session.Instance.IdUsuario = usuario.Id;
                Session.Instance.NomeUsuario = usuario.Nome;
                Session.Instance.EmailUsuario = usuario.Email;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"Acesso negado");
            }
           
        }
    }
}
