using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;
using System;

namespace EstabelecimentoMRR
{
    public partial class FormEstabelecimento : MaterialSkin.Controls.MaterialForm
    {
        private Conta _fluxocaixa;
        private GeralRep _rep;

        public FormEstabelecimento()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            _fluxocaixa = new Conta();
            _rep = new GeralRep();
        }
        
        private void btn_Cadastrar_Click(object sender, System.EventArgs e)
        {
            _fluxocaixa.Nome = txt_Nome_Conta.Text;
            _fluxocaixa.DataLancamento = DateTime.Now;
            _fluxocaixa.DataVencimento = dtp_Data.Value;
            _fluxocaixa.Valor = decimal.Parse(txt_Valor.Text);
            _fluxocaixa.Status = chk_Status.Checked ? Enum.Status.Quitada: Enum.Status.Pendente;
            _fluxocaixa.Descricao = txt_Descricao.Text;
            
            //_rep.Insert(_fluxocaixa);
        }



        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //var x = _rep.BuscarTodas();
        }
    }
}
