using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EstabelecimentoMRR.BusinessLogic;
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

            lblValorAPagar.Text = ContaLogic.CalcularValorAPagar(contas).ToString();
            lblValorAPagarAtradado.Text = ContaLogic.CalcularValorAPagarAtradado(DateTime.Now, contas).ToString();
            lblValorAReceber.Text = ContaLogic.CalcularValorAReceber(contas).ToString();
            lblGastoMedio.Text = ContaLogic.CalcularGastoMedioQuitado(contas).ToString();
            lblSaldo.Text = ContaLogic.CalcularSaldo(contas).ToString();

            gridPrincipal.DataSource = contas;

            foreach (DataGridViewRow row in gridPrincipal.Rows)
            {
                var data = (Conta)row.DataBoundItem;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "Situacao")
                    {
                        cell.Value = data.Status == Status.Pendente ? ImageList.Images[0] : ImageList.Images[1];
                    }
                    if (cell.OwningColumn.Name == "Alterar")
                    {
                        cell.Value = ImageList.Images[2];
                    }
                    if (cell.OwningColumn.Name == "Excluir")
                    {
                        cell.Value = ImageList.Images[3];
                    }
                }
            }
        }
    }
}
