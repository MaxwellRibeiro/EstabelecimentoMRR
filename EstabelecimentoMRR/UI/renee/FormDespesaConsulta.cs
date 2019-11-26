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
    public partial class FormDespesaConsulta : MaterialSkin.Controls.MaterialForm
    {
        public FormDespesaConsulta()
        {
            InitializeComponent();
        }

        private Conta _fluxocaixa;
        private ContaRep _rep;
        private List<Conta> contas = new List<Conta>();

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _rep.Select_All();
        }
        private void FormDespesaConsulta_Load(object sender, EventArgs e)
        {
            _fluxocaixa = new Conta();
            _rep = new ContaRep();
        }
    }
}
