using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstabelecimentoMRR.BusinessLogic;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;

namespace EstabelecimentoMRR.UI.Principal
{
    public partial class FormPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public List<Conta> ListaTodasContas { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            ListaTodasContas = CarregarContas();
            
            lblSaldo.Text = ContaLogic.CalcularSaldo(ListaTodasContas).ToString();
            lblValorAPagarAtradado.Text = ContaLogic.CalcularValorAPagarAtradado(DateTime.Now, ListaTodasContas).ToString();

            FiltrarConta();

            CarregarImagensGrid();
        }

        public List<Conta> CarregarContas()
        {
            ContaRep rep = new ContaRep();
            return rep.Select_All();
        }

        public void FiltrarConta()
        {
            gridPrincipal.DataSource = ListaTodasContas;

            lblValorAPagar.Text = ContaLogic.CalcularValorAPagar(ListaTodasContas).ToString();
            lblValorAReceber.Text = ContaLogic.CalcularValorAReceber(ListaTodasContas).ToString();
            lblGastoMedio.Text = ContaLogic.CalcularGastoMedioQuitado(ListaTodasContas).ToString();
        }

        public void CarregarImagensGrid()
        {
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
