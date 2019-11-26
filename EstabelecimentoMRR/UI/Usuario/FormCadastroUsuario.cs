using System;
using System.Windows.Forms;
using EstabelecimentoMRR.Repository;

namespace EstabelecimentoMRR.UI.Usuario
{
    public partial class FormCadastroUsuario : MaterialSkin.Controls.MaterialForm
    {

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Digite o nome");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Digite o email");
                return;
            }
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            var usuario = new Model.Usuario {Nome = txtNome.Text, Email = txtEmail.Text, Senha = txtSenha.Text};
            var rep = new UsuarioRep();
            var isSalvo = rep.Inserir(usuario);
            if (isSalvo)
            {
                MessageBox.Show("Usuário salvo");
                Close();
            }
            else
            {
                MessageBox.Show("Problema ao salvar usuário");
            }
        }
    }
}
