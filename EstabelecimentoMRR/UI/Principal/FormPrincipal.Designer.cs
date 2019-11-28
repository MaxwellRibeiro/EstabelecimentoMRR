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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblValorAPagar = new System.Windows.Forms.Label();
            this.lblValorAPagarAtradado = new System.Windows.Forms.Label();
            this.lblValorAReceber = new System.Windows.Forms.Label();
            this.lblGastoMedio = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.Situacao = new System.Windows.Forms.DataGridViewImageColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorAPagar.Location = new System.Drawing.Point(758, 104);
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
            this.lblValorAPagarAtradado.Location = new System.Drawing.Point(179, 104);
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
            this.lblValorAReceber.Location = new System.Drawing.Point(603, 104);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(149, 49);
            this.lblValorAReceber.TabIndex = 2;
            this.lblValorAReceber.Text = "Valor à Receber";
            this.lblValorAReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGastoMedio
            // 
            this.lblGastoMedio.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGastoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoMedio.ForeColor = System.Drawing.Color.White;
            this.lblGastoMedio.Location = new System.Drawing.Point(913, 104);
            this.lblGastoMedio.Name = "lblGastoMedio";
            this.lblGastoMedio.Size = new System.Drawing.Size(149, 49);
            this.lblGastoMedio.TabIndex = 3;
            this.lblGastoMedio.Text = "Gasto Médio";
            this.lblGastoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(24, 104);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(149, 49);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AutoGenerateColumns = false;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoContaDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.Situacao,
            this.Alterar,
            this.Excluir});
            this.gridPrincipal.DataSource = this.contaBindingSource;
            this.gridPrincipal.Location = new System.Drawing.Point(27, 222);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.Size = new System.Drawing.Size(1059, 260);
            this.gridPrincipal.TabIndex = 5;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "clock.png");
            this.ImageList.Images.SetKeyName(1, "V.png");
            this.ImageList.Images.SetKeyName(2, "Edit.png");
            this.ImageList.Images.SetKeyName(3, "X.png");
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
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
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
            this.descricaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "";
            this.Situacao.Name = "Situacao";
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 595);
            this.Controls.Add(this.lblValorAReceber);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblValorAPagar);
            this.Controls.Add(this.lblGastoMedio);
            this.Controls.Add(this.lblValorAPagarAtradado);
            this.Controls.Add(this.gridPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValorAPagar;
        private System.Windows.Forms.Label lblValorAPagarAtradado;
        private System.Windows.Forms.Label lblValorAReceber;
        private System.Windows.Forms.Label lblGastoMedio;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.BindingSource contaBindingSource;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Situacao;
        private System.Windows.Forms.DataGridViewImageColumn Alterar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
    }
}