using System;
using System.Collections.Generic;
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
        public List<Conta> ListaTodasContas { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            dtDataInicial.Value = DateTime.Now.AddDays(-15);
            dtDataFinal.Value = DateTime.Now.AddDays(15);

            ListaTodasContas = CarregarContas();
            
            lblSaldo.Text = ContaLogic.CalcularSaldo(ListaTodasContas).ToString();
            lblValorAPagarAtradado.Text = ContaLogic.CalcularValorAPagarAtradado(DateTime.Now, ListaTodasContas).ToString();

            FiltrarConta();
        }

        public List<Conta> CarregarContas()
        {
            ContaRep rep = new ContaRep();
            return rep.Select_All();
        }

        public void FiltrarConta()
        {
            if(ListaTodasContas == null) return;

            var listaFiltrada = ListaTodasContas.Where(l =>
                    l.DataLancamento.Date >= dtDataInicial.Value.Date &&
                    l.DataLancamento.Date <= dtDataFinal.Value.Date)
                .ToList();

            if (!ckEfetivo.Checked)
            {
                listaFiltrada = listaFiltrada.Where(l => l.Status != Status.Quitada && l.Status != Status.Recebido).ToList();
            }
            if (!ckPendente.Checked)
            {
                listaFiltrada = listaFiltrada.Where(l => l.Status != Status.Pendente).ToList();
            }
            if (!ckReceita.Checked)
            {
                listaFiltrada = listaFiltrada.Where(l => l.TipoConta != TipoConta.Receita).ToList();
            }
            if (!ckDispesa.Checked)
            {
                listaFiltrada = listaFiltrada.Where(l => l.TipoConta != TipoConta.Dispesa).ToList();
            }

            gridPrincipal.DataSource = listaFiltrada;

            lblValorAPagar.Text = ContaLogic.CalcularValorAPagar(listaFiltrada).ToString();
            lblValorAReceber.Text = ContaLogic.CalcularValorAReceber(listaFiltrada).ToString();
            lblGastoMedio.Text = ContaLogic.CalcularGastoMedio(listaFiltrada).ToString();

            CarregarImagensGrid();
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

        private void gridPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (gridPrincipal.CurrentRow == null) return;

            var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;

            btEfetivo.Visible = conta.Status == Status.Pendente;
            if (conta.Status == Status.Pendente && conta.TipoConta == TipoConta.Dispesa)
            {
                btEfetivo.Text = @"Quitar";
            }
            if (conta.Status == Status.Pendente && conta.TipoConta == TipoConta.Receita)
            {
                btEfetivo.Text = @"Receber";
            }
        }

        private void dtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void dtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void ckReceita_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void ckDispesa_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void ckEfetivo_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void ckPendente_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarConta();
        }

        private void gridPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPrincipal.Columns[e.ColumnIndex].Name == "Alterar")
            {
                if (gridPrincipal.CurrentRow == null) return;
                var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
                MessageBox.Show(@"Alterar " + conta.Nome);
            }
            if (gridPrincipal.Columns[e.ColumnIndex].Name == "Excluir")
            {
                if (gridPrincipal.CurrentRow == null) return;
                var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
                MessageBox.Show(@"Excluir " + conta.Nome);
            }
        }

        private void btAdicionarConta_Click(object sender, EventArgs e)
        {
            if (gridPrincipal.CurrentRow == null) return;
            var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
        }

        private void btEfetivo_Click(object sender, EventArgs e)
        {
            if (gridPrincipal.CurrentRow == null) return;
            var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
        }
    }
}
