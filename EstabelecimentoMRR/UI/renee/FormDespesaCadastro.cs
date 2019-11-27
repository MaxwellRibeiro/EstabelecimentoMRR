using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstabelecimentoMRR.UI.Despesa
{
    public partial class FormDespesaCadastro : MaterialSkin.Controls.MaterialForm
    {

        private Conta _fluxocaixa;
        private ContaRep _rep;
        private List<Conta> contas = new List<Conta>();

        public FormDespesaCadastro()
        {
            InitializeComponent();
        }

        private void FormDispesaCadastro_Load(object sender, EventArgs e)
        {
            _fluxocaixa = new Conta();
            _rep = new ContaRep();
        }

        
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            _fluxocaixa.Nome = txt_Nome_Conta.Text;
            _fluxocaixa.TipoConta = Enum.TipoConta.Dispesa;
            _fluxocaixa.DataLancamento = DateTime.Now;
            _fluxocaixa.DataVencimento = dtp_Data.Value;
            _fluxocaixa.Valor = decimal.Parse(txt_Valor.Text);
            _fluxocaixa.Status = chk_Status.Checked ? Enum.Status.Quitada : Enum.Status.Pendente;
            _fluxocaixa.Descricao = txt_Descricao.Text;
            _fluxocaixa.IdUsuario = 1;

            contas = _rep.Insert(_fluxocaixa);
            limpa_Campos();
            _fluxocaixa = new Conta();
            _rep = new ContaRep();
        }

        private void limpa_Campos()
        {
            txt_Nome_Conta.Clear();                     
            dtp_Data.Value = DateTime.Now;
            txt_Valor.Clear();
            chk_Status.Checked = false;
            txt_Descricao.Clear();            
        }
    }
}
