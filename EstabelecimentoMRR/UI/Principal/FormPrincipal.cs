using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EstabelecimentoMRR.BusinessLogic;
using EstabelecimentoMRR.Enum;
using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;
using EstabelecimentoMRR.UI.renee;

namespace EstabelecimentoMRR.UI.Principal
{
    public partial class FormPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public List<Conta> ListaTodasContas { get; set; }
        FormCadastroConta form;       

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {
            dtDataInicial.Value = DateTime.Now.AddDays(-15);
            dtDataFinal.Value = DateTime.Now.AddDays(15);

            ListaTodasContas = CarregarContas();

            AjustarInformacoesTodasContas();
            FiltrarConta();
        }

        public void AjustarInformacoesTodasContas()
        {
            lblSaldo.Text = ContaLogic.CalcularSaldo(ListaTodasContas).ToString();
            lblValorAPagarAtradado.Text = ContaLogic.CalcularValorAPagarAtradado(DateTime.Now, ListaTodasContas).ToString();
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
                    l.DataVencimento.Date >= dtDataInicial.Value.Date &&
                    l.DataVencimento.Date <= dtDataFinal.Value.Date)
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
                listaFiltrada = listaFiltrada.Where(l => l.TipoConta != TipoConta.Despesa).ToList();
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
            if (conta.Status == Status.Pendente && conta.TipoConta == TipoConta.Despesa)
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
                form = new FormCadastroConta(conta);
                form.ShowDialog();
                ListaTodasContas = CarregarContas();

                AjustarInformacoesTodasContas();
                FiltrarConta();
                
            }
            else if (gridPrincipal.Columns[e.ColumnIndex].Name == "Excluir")
            {
                if (gridPrincipal.CurrentRow == null) return;
                var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
                if (conta.Id > 0)
                {
                    if (conta.Status == Enum.Status.Quitada || conta.Status == Enum.Status.Recebido)
                        MessageBox.Show(@"Impossivel Excluir conta.", "Aviso");
                    else
                    {
                        DialogResult result = MessageBox.Show("Deseja realmente Excluir este registro?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            ContaRep rep = new ContaRep();
                            rep.Delete(conta);
                            ListaTodasContas = CarregarContas();

                            AjustarInformacoesTodasContas();
                            FiltrarConta();
                            MessageBox.Show(@"Excluido com sucesso.", "Aviso");

                            
                        }
                        else return;
                    }
                }
                else return;                                                
            }            
        }

        private void btAdicionarConta_Click(object sender, EventArgs e)
        {            
            Conta oj = new Conta();                
            form = new FormCadastroConta(oj);
            form.ShowDialog();
            ListaTodasContas = CarregarContas();

            AjustarInformacoesTodasContas();
            FiltrarConta();
        }
            

        private void btEfetivo_Click(object sender, EventArgs e)
        {
            if (gridPrincipal.CurrentRow == null) return;
            var conta = (Conta)gridPrincipal.CurrentRow.DataBoundItem;
            string texto = conta.TipoConta == Enum.TipoConta.Despesa ? "Quitar" : "Receber";
            if (conta.Status == Enum.Status.Quitada || conta.Status == Enum.Status.Recebido)
            {
                MessageBox.Show("Impossivel Efetivar este registro.", "Aviso");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja realmente " + texto + " este registro?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ContaRep rep = new ContaRep();
                    conta.Status = texto == "Quitar" ? Enum.Status.Quitada : Enum.Status.Recebido;
                    rep.Efetivar(conta);
                    ListaTodasContas = CarregarContas();

                    AjustarInformacoesTodasContas();
                    FiltrarConta();
                    MessageBox.Show(@"Efetivado com sucesso.", "Aviso");

                    
                }
                else return;
            }

            Refresh();
        }

    }
}
