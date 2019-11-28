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
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "Img")
                    {
                        cell.Value = imageList1.Images[0];
                    }
                }
            }
        }
    }
}
