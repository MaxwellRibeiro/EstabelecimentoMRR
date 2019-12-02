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
            this.Situacao = new System.Windows.Forms.DataGridViewImageColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new MaterialSkin.Controls.MaterialLabel();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btAdicionarConta = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btEfetivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ckReceita = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckDispesa = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckEfetivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.ckPendente = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorAPagar
            // 
            this.lblValorAPagar.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagar.ForeColor = System.Drawing.Color.White;
            this.lblValorAPagar.Location = new System.Drawing.Point(589, 104);
            this.lblValorAPagar.Name = "lblValorAPagar";
            this.lblValorAPagar.Size = new System.Drawing.Size(180, 49);
            this.lblValorAPagar.TabIndex = 0;
            this.lblValorAPagar.Text = "Valor à Pagar";
            this.lblValorAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorAPagarAtradado
            // 
            this.lblValorAPagarAtradado.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAPagarAtradado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagarAtradado.ForeColor = System.Drawing.Color.White;
            this.lblValorAPagarAtradado.Location = new System.Drawing.Point(198, 104);
            this.lblValorAPagarAtradado.Name = "lblValorAPagarAtradado";
            this.lblValorAPagarAtradado.Size = new System.Drawing.Size(180, 49);
            this.lblValorAPagarAtradado.TabIndex = 1;
            this.lblValorAPagarAtradado.Text = "Valor à Pagar Atrasado";
            this.lblValorAPagarAtradado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorAReceber
            // 
            this.lblValorAReceber.BackColor = System.Drawing.Color.SteelBlue;
            this.lblValorAReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAReceber.ForeColor = System.Drawing.Color.White;
            this.lblValorAReceber.Location = new System.Drawing.Point(403, 104);
            this.lblValorAReceber.Name = "lblValorAReceber";
            this.lblValorAReceber.Size = new System.Drawing.Size(180, 49);
            this.lblValorAReceber.TabIndex = 2;
            this.lblValorAReceber.Text = "Valor à Receber";
            this.lblValorAReceber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGastoMedio
            // 
            this.lblGastoMedio.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGastoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoMedio.ForeColor = System.Drawing.Color.White;
            this.lblGastoMedio.Location = new System.Drawing.Point(775, 104);
            this.lblGastoMedio.Name = "lblGastoMedio";
            this.lblGastoMedio.Size = new System.Drawing.Size(180, 49);
            this.lblGastoMedio.TabIndex = 3;
            this.lblGastoMedio.Text = "Gasto Médio";
            this.lblGastoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(12, 104);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(180, 49);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AutoGenerateColumns = false;
            this.gridPrincipal.BackgroundColor = System.Drawing.Color.White;
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
            this.gridPrincipal.Location = new System.Drawing.Point(12, 206);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.ReadOnly = true;
            this.gridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrincipal.Size = new System.Drawing.Size(943, 254);
            this.gridPrincipal.TabIndex = 5;
            this.gridPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrincipal_CellClick);
            this.gridPrincipal.SelectionChanged += new System.EventHandler(this.gridPrincipal_SelectionChanged);
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // Alterar
            // 
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Infomações de todas contas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saldo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor à pagar atrasado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(403, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor à receber";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(589, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor à pagar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(775, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gasto Médio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(549, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Infomações consideradas do período selecionado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(390, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 84);
            this.panel1.TabIndex = 14;
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(103, 180);
            this.dtDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(89, 20);
            this.dtDataInicial.TabIndex = 44;
            this.dtDataInicial.ValueChanged += new System.EventHandler(this.dtDataInicial_ValueChanged);
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Depth = 0;
            this.lblDataInicial.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataInicial.Location = new System.Drawing.Point(11, 180);
            this.lblDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(88, 19);
            this.lblDataInicial.TabIndex = 45;
            this.lblDataInicial.Text = "Data Inicial:";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(280, 179);
            this.dtDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(89, 20);
            this.dtDataFinal.TabIndex = 46;
            this.dtDataFinal.ValueChanged += new System.EventHandler(this.dtDataFinal_ValueChanged);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Depth = 0;
            this.lblDataFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataFinal.Location = new System.Drawing.Point(196, 179);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(80, 19);
            this.lblDataFinal.TabIndex = 47;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 10);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(12, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 10);
            this.panel3.TabIndex = 49;
            // 
            // btAdicionarConta
            // 
            this.btAdicionarConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdicionarConta.Depth = 0;
            this.btAdicionarConta.Location = new System.Drawing.Point(819, 465);
            this.btAdicionarConta.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionarConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdicionarConta.Name = "btAdicionarConta";
            this.btAdicionarConta.Primary = true;
            this.btAdicionarConta.Size = new System.Drawing.Size(136, 36);
            this.btAdicionarConta.TabIndex = 50;
            this.btAdicionarConta.Text = "Adicionar Conta";
            this.btAdicionarConta.UseVisualStyleBackColor = true;
            this.btAdicionarConta.Click += new System.EventHandler(this.btAdicionarConta_Click);
            // 
            // btEfetivo
            // 
            this.btEfetivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEfetivo.Depth = 0;
            this.btEfetivo.Location = new System.Drawing.Point(679, 465);
            this.btEfetivo.Margin = new System.Windows.Forms.Padding(2);
            this.btEfetivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEfetivo.Name = "btEfetivo";
            this.btEfetivo.Primary = true;
            this.btEfetivo.Size = new System.Drawing.Size(136, 36);
            this.btEfetivo.TabIndex = 51;
            this.btEfetivo.Text = "Efetivo";
            this.btEfetivo.UseVisualStyleBackColor = true;
            this.btEfetivo.Visible = false;
            this.btEfetivo.Click += new System.EventHandler(this.btEfetivo_Click);
            // 
            // ckReceita
            // 
            this.ckReceita.AutoSize = true;
            this.ckReceita.Checked = true;
            this.ckReceita.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckReceita.Depth = 0;
            this.ckReceita.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckReceita.Location = new System.Drawing.Point(406, 173);
            this.ckReceita.Margin = new System.Windows.Forms.Padding(0);
            this.ckReceita.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckReceita.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckReceita.Name = "ckReceita";
            this.ckReceita.Ripple = true;
            this.ckReceita.Size = new System.Drawing.Size(130, 30);
            this.ckReceita.TabIndex = 52;
            this.ckReceita.Text = "Contas Receitas";
            this.ckReceita.UseVisualStyleBackColor = true;
            this.ckReceita.CheckedChanged += new System.EventHandler(this.ckReceita_CheckedChanged);
            // 
            // ckDispesa
            // 
            this.ckDispesa.AutoSize = true;
            this.ckDispesa.Checked = true;
            this.ckDispesa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDispesa.Depth = 0;
            this.ckDispesa.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckDispesa.Location = new System.Drawing.Point(540, 173);
            this.ckDispesa.Margin = new System.Windows.Forms.Padding(0);
            this.ckDispesa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckDispesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckDispesa.Name = "ckDispesa";
            this.ckDispesa.Ripple = true;
            this.ckDispesa.Size = new System.Drawing.Size(133, 30);
            this.ckDispesa.TabIndex = 53;
            this.ckDispesa.Text = "Contas Dispesas";
            this.ckDispesa.UseVisualStyleBackColor = true;
            this.ckDispesa.CheckedChanged += new System.EventHandler(this.ckDispesa_CheckedChanged);
            // 
            // ckEfetivo
            // 
            this.ckEfetivo.AutoSize = true;
            this.ckEfetivo.Checked = true;
            this.ckEfetivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEfetivo.Depth = 0;
            this.ckEfetivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckEfetivo.Location = new System.Drawing.Point(677, 173);
            this.ckEfetivo.Margin = new System.Windows.Forms.Padding(0);
            this.ckEfetivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckEfetivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckEfetivo.Name = "ckEfetivo";
            this.ckEfetivo.Ripple = true;
            this.ckEfetivo.Size = new System.Drawing.Size(126, 30);
            this.ckEfetivo.TabIndex = 54;
            this.ckEfetivo.Text = "Contas Efetivas";
            this.ckEfetivo.UseVisualStyleBackColor = true;
            this.ckEfetivo.CheckedChanged += new System.EventHandler(this.ckEfetivo_CheckedChanged);
            // 
            // ckPendente
            // 
            this.ckPendente.AutoSize = true;
            this.ckPendente.Checked = true;
            this.ckPendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckPendente.Depth = 0;
            this.ckPendente.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckPendente.Location = new System.Drawing.Point(807, 173);
            this.ckPendente.Margin = new System.Windows.Forms.Padding(0);
            this.ckPendente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckPendente.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckPendente.Name = "ckPendente";
            this.ckPendente.Ripple = true;
            this.ckPendente.Size = new System.Drawing.Size(142, 30);
            this.ckPendente.TabIndex = 55;
            this.ckPendente.Text = "Contas Pendentes";
            this.ckPendente.UseVisualStyleBackColor = true;
            this.ckPendente.CheckedChanged += new System.EventHandler(this.ckPendente_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(390, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 20);
            this.panel4.TabIndex = 56;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoContaDataGridViewTextBoxColumn
            // 
            this.tipoContaDataGridViewTextBoxColumn.DataPropertyName = "TipoConta";
            this.tipoContaDataGridViewTextBoxColumn.HeaderText = "TipoConta";
            this.tipoContaDataGridViewTextBoxColumn.Name = "tipoContaDataGridViewTextBoxColumn";
            this.tipoContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // contaBindingSource
            // 
            this.contaBindingSource.DataSource = typeof(EstabelecimentoMRR.Model.Conta);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 525);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ckPendente);
            this.Controls.Add(this.ckEfetivo);
            this.Controls.Add(this.ckDispesa);
            this.Controls.Add(this.ckReceita);
            this.Controls.Add(this.btEfetivo);
            this.Controls.Add(this.btAdicionarConta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtDataFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.dtDataInicial);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorAReceber);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblValorAPagar);
            this.Controls.Add(this.lblGastoMedio);
            this.Controls.Add(this.lblValorAPagarAtradado);
            this.Controls.Add(this.gridPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private MaterialSkin.Controls.MaterialLabel lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private MaterialSkin.Controls.MaterialLabel lblDataFinal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton btAdicionarConta;
        private MaterialSkin.Controls.MaterialRaisedButton btEfetivo;
        private MaterialSkin.Controls.MaterialCheckBox ckReceita;
        private MaterialSkin.Controls.MaterialCheckBox ckDispesa;
        private MaterialSkin.Controls.MaterialCheckBox ckEfetivo;
        private MaterialSkin.Controls.MaterialCheckBox ckPendente;
        private System.Windows.Forms.Panel panel4;
    }
}