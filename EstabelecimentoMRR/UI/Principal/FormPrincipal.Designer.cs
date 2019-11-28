namespace EstabelecimentoMRR.UI.Principal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.lblValorAPagarAtradado = new System.Windows.Forms.Label();
            this.lblValorAReceber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorAPagar.Location = new System.Drawing.Point(12, 78);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(149, 49);
            this.lblValorAPagar.TabIndex = 0;
            this.lblValorAPagar.Text = "Valor à Pagar";
            this.lblValorAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorAPagarAtradado
            // 
            this.lblValorAPagarAtradado.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAPagarAtradado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagarAtradado.ForeColor = System.Drawing.Color.White;
            this.lblValorAPagarAtradado.Location = new System.Drawing.Point(167, 78);
            this.lblValorAPagarAtradado.Name = "lblValorAPagarAtradado";
            this.lblValorAPagarAtradado.Size = new System.Drawing.Size(149, 49);
            this.lblValorAPagarAtradado.TabIndex = 1;
            this.lblValorAPagarAtradado.Text = "Valor à Pagar Atrasado";
            this.lblValorAPagarAtradado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorAReceber
            // 
            this.lblValorAReceber.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAReceber.ForeColor = System.Drawing.Color.White;
            this.lblValorAReceber.Location = new System.Drawing.Point(322, 78);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(149, 49);
            this.lblValorAReceber.TabIndex = 2;
            this.lblValorAReceber.Text = "Valor à Receber";
            this.lblValorAReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor à Pagar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(632, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 49);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor à Pagar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoContaDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataSource = typeof(EstabelecimentoMRR.Model.Conta);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // tipoContaDataGridViewTextBoxColumn
            // 
            this.tipoContaDataGridViewTextBoxColumn.DataPropertyName = "TipoConta";
            this.tipoContaDataGridViewTextBoxColumn.HeaderText = "TipoConta";
            this.tipoContaDataGridViewTextBoxColumn.Name = "tipoContaDataGridViewTextBoxColumn";
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorAReceber);
            this.Controls.Add(this.lblValorAPagarAtradado);
            this.Controls.Add(this.lblValorAPagar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.Label lblValorAPagarAtradado;
        private System.Windows.Forms.Label lblValorAReceber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contaBindingSource;
    }
}