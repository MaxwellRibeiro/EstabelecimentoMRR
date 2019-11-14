﻿using EstabelecimentoMRR.Model;
using EstabelecimentoMRR.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EstabelecimentoMRR
{
    public partial class frm_EstabelecimentoMRR : MaterialSkin.Controls.MaterialForm
    {
        public frm_EstabelecimentoMRR()
        {
            InitializeComponent();
        }
        private Conta fluxocaixa;
        ContaRep rep;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            fluxocaixa = new Conta();
            rep = new ContaRep();
        }



        private void btn_Cadastrar_Click(object sender, System.EventArgs e)
        {
            fluxocaixa.Nome = txt_Nome_Conta.Text;
            fluxocaixa.DataLancamento = DateTime.Now;
            fluxocaixa.DataVencimento = dtp_Data.Value;
            fluxocaixa.Valor = decimal.Parse(txt_Valor.Text);
            fluxocaixa.Status = chk_Status.Checked ? Enum.Status.Quitada: Enum.Status.Pendente;
            fluxocaixa.Descricao = txt_Descricao.Text;

            

            rep.Insert(fluxocaixa);

            
        }



        private void btn_consultar_Click(object sender, EventArgs e)
        {
            var x = rep.Query<Conta>("select * from fluxocaixa").ToList();
        }
    }
}
