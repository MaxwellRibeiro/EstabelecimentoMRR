using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstabelecimentoMRR.UI.renee
{
    public partial class FormCadastroConta : MaterialSkin.Controls.MaterialForm
    {

        private Conta _fluxocaixa = new Conta();        
        private ContaRep _rep;
        private List<Conta> contas = new List<Conta>();

        public FormCadastroConta(Conta fluxo)
        {            
            InitializeComponent();
            _fluxocaixa = fluxo; ;

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {            
            _rep = new ContaRep();
            if (_fluxocaixa.Id > 0)
            {
                txt_Valor.Enabled = false;                
                btn_Alterar.Visible = true;
                btn_Cadastrar.Visible = false;
                txt_Nome_Conta.Text = _fluxocaixa.Nome;
                dtp_Data.Value = _fluxocaixa.DataVencimento;
                txt_Descricao.Text = _fluxocaixa.Descricao;
                txt_Valor.Text = _fluxocaixa.Valor.ToString();
                rb_Despesa.Enabled = false;
                rb_Receita.Enabled = false;
                chk_Status.Enabled = false;
                if (_fluxocaixa.TipoConta == Enum.TipoConta.Despesa)
                {                   
                    rb_Despesa.Checked = true;                    
                    chk_Status.Text = "Quitado";                    
                    if (_fluxocaixa.Status == Enum.Status.Pendente)
                        chk_Status.Checked = false;
                    else
                        chk_Status.Checked = true;
                }
                else 
                {                                        
                    chk_Status.Text = "Recebido";
                    rb_Receita.Checked = true;                    
                    
                    if (_fluxocaixa.Status == Enum.Status.Pendente)
                        chk_Status.Checked = false;
                    else
                        chk_Status.Checked = true;
                }
            }
            else
            {
                _fluxocaixa = new Conta();
                btn_Alterar.Visible = false;
                btn_Cadastrar.Visible = true;
                rb_Despesa.Checked = true;
                
            }                
        }


        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            _fluxocaixa.Nome = txt_Nome_Conta.Text;
            if (rb_Despesa.Checked == true)
            {
                _fluxocaixa.TipoConta = Enum.TipoConta.Despesa;
                _fluxocaixa.Status = chk_Status.Checked ? Enum.Status.Quitada : Enum.Status.Pendente;
            }
            else
            {
                _fluxocaixa.TipoConta = Enum.TipoConta.Receita;
                _fluxocaixa.Status = chk_Status.Checked ? Enum.Status.Recebido : Enum.Status.Pendente;
            }
            _fluxocaixa.DataLancamento = DateTime.Now;
            _fluxocaixa.DataVencimento = dtp_Data.Value;
            _fluxocaixa.Valor = decimal.Parse(txt_Valor.Text);
            _fluxocaixa.Descricao = txt_Descricao.Text;
            _fluxocaixa.IdUsuario = Session.Instance.IdUsuario;

            if (_rep.Insert(_fluxocaixa))
                MessageBox.Show("SALVO COM SUCESSO");
            else
                MessageBox.Show("Erro ao Salvar, tente novamente");                                            
            limpa_Campos();           
            this.Close();           
        }

            private void limpa_Campos()
        {
            txt_Nome_Conta.Clear();
            dtp_Data.Value = DateTime.Now;
            txt_Valor.Clear();
            chk_Status.Checked = false;
            txt_Descricao.Clear();
        }

        private void rb_Despesa_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Despesa.Checked == true)
                chk_Status.Text = "Quitado";
            else
                chk_Status.Text = "Recebido";
        }

        private void rb_Receita_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Receita.Checked == true)
                chk_Status.Text = "Recebido";
            else
                chk_Status.Text = "Quitado";
            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            _fluxocaixa.Nome = txt_Nome_Conta.Text;                        
            _fluxocaixa.DataVencimento = dtp_Data.Value;            
            _fluxocaixa.Descricao = txt_Descricao.Text;            

            if (_rep.Update(_fluxocaixa))            
                MessageBox.Show("ALTERADO COM SUCESSO");            
            else            
                MessageBox.Show("Erro ao Salvar, tente novamente");            
            limpa_Campos();            
            this.Close();
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


