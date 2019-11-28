using System;
using System.Linq;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;

namespace EstabelecimentoMRR.UI.Principal
{
    public partial class FormPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            ContaRep rep = new ContaRep();
            var contas = rep.Select_All();
            lblValorAPagar.Text = contas.Where(c => c.TipoConta == TipoConta.Dispesa && c.Status == Status.Pendente).Sum(s=> s.Valor).ToString();

            dataGridView1.DataSource = contas;
        }
    }
}
