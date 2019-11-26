namespace EstabelecimentoMRR
{
    partial class FormEstabelecimento
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
            this.tab_contr_Contas = new MaterialSkin.Controls.MaterialTabControl();
            this.Pg_Pagar = new System.Windows.Forms.TabPage();
            this.btn_consultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.lbl_Status = new MaterialSkin.Controls.MaterialLabel();
            this.chk_Status = new MaterialSkin.Controls.MaterialCheckBox();
            this.txt_Descricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_Descricao = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Valor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_Valor = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Data = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Nome_Conta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_Nome_Conta = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Cadastrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Pg_Receber = new System.Windows.Forms.TabPage();
            this.tab_select_Contas = new MaterialSkin.Controls.MaterialTabSelector();
            this.tab_contr_Contas.SuspendLayout();
            this.Pg_Pagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_contr_Contas
            // 
            this.tab_contr_Contas.Controls.Add(this.Pg_Pagar);
            this.tab_contr_Contas.Controls.Add(this.Pg_Receber);
            this.tab_contr_Contas.Depth = 0;
            this.tab_contr_Contas.Location = new System.Drawing.Point(0, 123);
            this.tab_contr_Contas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_contr_Contas.Name = "tab_contr_Contas";
            this.tab_contr_Contas.SelectedIndex = 0;
            this.tab_contr_Contas.Size = new System.Drawing.Size(1316, 657);
            this.tab_contr_Contas.TabIndex = 2;
            // 
            // Pg_Pagar
            // 
            this.Pg_Pagar.BackColor = System.Drawing.Color.White;
            this.Pg_Pagar.Controls.Add(this.btn_consultar);
            this.Pg_Pagar.Controls.Add(this.dtp_Data);
            this.Pg_Pagar.Controls.Add(this.lbl_Status);
            this.Pg_Pagar.Controls.Add(this.chk_Status);
            this.Pg_Pagar.Controls.Add(this.txt_Descricao);
            this.Pg_Pagar.Controls.Add(this.lbl_Descricao);
            this.Pg_Pagar.Controls.Add(this.txt_Valor);
            this.Pg_Pagar.Controls.Add(this.lbl_Valor);
            this.Pg_Pagar.Controls.Add(this.lbl_Data);
            this.Pg_Pagar.Controls.Add(this.txt_Nome_Conta);
            this.Pg_Pagar.Controls.Add(this.lbl_Nome_Conta);
            this.Pg_Pagar.Controls.Add(this.btn_Cadastrar);
            this.Pg_Pagar.Location = new System.Drawing.Point(4, 25);
            this.Pg_Pagar.Name = "Pg_Pagar";
            this.Pg_Pagar.Padding = new System.Windows.Forms.Padding(3);
            this.Pg_Pagar.Size = new System.Drawing.Size(1308, 628);
            this.Pg_Pagar.TabIndex = 0;
            this.Pg_Pagar.Text = "Contas a Pagar";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consultar.Depth = 0;
            this.btn_consultar.Location = new System.Drawing.Point(658, 504);
            this.btn_consultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Primary = true;
            this.btn_consultar.Size = new System.Drawing.Size(277, 44);
            this.btn_consultar.TabIndex = 14;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(467, 201);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(200, 22);
            this.dtp_Data.TabIndex = 13;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Depth = 0;
            this.lbl_Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Status.Location = new System.Drawing.Point(379, 337);
            this.lbl_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(68, 24);
            this.lbl_Status.TabIndex = 12;
            this.lbl_Status.Text = "Status:";
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Depth = 0;
            this.chk_Status.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk_Status.Location = new System.Drawing.Point(467, 337);
            this.chk_Status.Margin = new System.Windows.Forms.Padding(0);
            this.chk_Status.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Ripple = true;
            this.chk_Status.Size = new System.Drawing.Size(91, 30);
            this.chk_Status.TabIndex = 4;
            this.chk_Status.Text = "Quitada";
            this.chk_Status.UseVisualStyleBackColor = true;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Descricao.Depth = 0;
            this.txt_Descricao.Hint = "";
            this.txt_Descricao.Location = new System.Drawing.Point(467, 401);
            this.txt_Descricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.PasswordChar = '\0';
            this.txt_Descricao.SelectedText = "";
            this.txt_Descricao.SelectionLength = 0;
            this.txt_Descricao.SelectionStart = 0;
            this.txt_Descricao.Size = new System.Drawing.Size(471, 28);
            this.txt_Descricao.TabIndex = 5;
            this.txt_Descricao.UseSystemPasswordChar = false;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Depth = 0;
            this.lbl_Descricao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Descricao.Location = new System.Drawing.Point(344, 401);
            this.lbl_Descricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(94, 24);
            this.lbl_Descricao.TabIndex = 9;
            this.lbl_Descricao.Text = "Descricao";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Valor.Depth = 0;
            this.txt_Valor.Hint = "";
            this.txt_Valor.Location = new System.Drawing.Point(467, 263);
            this.txt_Valor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.PasswordChar = '\0';
            this.txt_Valor.SelectedText = "";
            this.txt_Valor.SelectionLength = 0;
            this.txt_Valor.SelectionStart = 0;
            this.txt_Valor.Size = new System.Drawing.Size(471, 28);
            this.txt_Valor.TabIndex = 3;
            this.txt_Valor.UseSystemPasswordChar = false;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Depth = 0;
            this.lbl_Valor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Valor.Location = new System.Drawing.Point(379, 263);
            this.lbl_Valor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(59, 24);
            this.lbl_Valor.TabIndex = 5;
            this.lbl_Valor.Text = "Valor:";
            // 
            // lbl_Data
            // 
            this.lbl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Depth = 0;
            this.lbl_Data.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Data.Location = new System.Drawing.Point(385, 199);
            this.lbl_Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(53, 24);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data:";
            // 
            // txt_Nome_Conta
            // 
            this.txt_Nome_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome_Conta.Depth = 0;
            this.txt_Nome_Conta.Hint = "";
            this.txt_Nome_Conta.Location = new System.Drawing.Point(467, 133);
            this.txt_Nome_Conta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Nome_Conta.Name = "txt_Nome_Conta";
            this.txt_Nome_Conta.PasswordChar = '\0';
            this.txt_Nome_Conta.SelectedText = "";
            this.txt_Nome_Conta.SelectionLength = 0;
            this.txt_Nome_Conta.SelectionStart = 0;
            this.txt_Nome_Conta.Size = new System.Drawing.Size(471, 28);
            this.txt_Nome_Conta.TabIndex = 1;
            this.txt_Nome_Conta.UseSystemPasswordChar = false;
            // 
            // lbl_Nome_Conta
            // 
            this.lbl_Nome_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nome_Conta.AutoSize = true;
            this.lbl_Nome_Conta.Depth = 0;
            this.lbl_Nome_Conta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Nome_Conta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Nome_Conta.Location = new System.Drawing.Point(291, 133);
            this.lbl_Nome_Conta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Nome_Conta.Name = "lbl_Nome_Conta";
            this.lbl_Nome_Conta.Size = new System.Drawing.Size(147, 24);
            this.lbl_Nome_Conta.TabIndex = 1;
            this.lbl_Nome_Conta.Text = "Nome da Conta:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Depth = 0;
            this.btn_Cadastrar.Location = new System.Drawing.Point(348, 504);
            this.btn_Cadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Primary = true;
            this.btn_Cadastrar.Size = new System.Drawing.Size(277, 44);
            this.btn_Cadastrar.TabIndex = 0;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Pg_Receber
            // 
            this.Pg_Receber.Location = new System.Drawing.Point(4, 25);
            this.Pg_Receber.Name = "Pg_Receber";
            this.Pg_Receber.Padding = new System.Windows.Forms.Padding(3);
            this.Pg_Receber.Size = new System.Drawing.Size(1308, 628);
            this.Pg_Receber.TabIndex = 1;
            this.Pg_Receber.Text = "Contas a Receber";
            this.Pg_Receber.UseVisualStyleBackColor = true;
            // 
            // tab_select_Contas
            // 
            this.tab_select_Contas.BaseTabControl = this.tab_contr_Contas;
            this.tab_select_Contas.Depth = 0;
            this.tab_select_Contas.Location = new System.Drawing.Point(0, 64);
            this.tab_select_Contas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_select_Contas.Name = "tab_select_Contas";
            this.tab_select_Contas.Size = new System.Drawing.Size(1316, 58);
            this.tab_select_Contas.TabIndex = 3;
            // 
            // frm_EstabelecimentoMRR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 782);
            this.Controls.Add(this.tab_select_Contas);
            this.Controls.Add(this.tab_contr_Contas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEstabelecimentoMrr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estabelecimento MRR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_contr_Contas.ResumeLayout(false);
            this.Pg_Pagar.ResumeLayout(false);
            this.Pg_Pagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tab_contr_Contas;
        private System.Windows.Forms.TabPage Pg_Pagar;
        private System.Windows.Forms.TabPage Pg_Receber;
        private MaterialSkin.Controls.MaterialTabSelector tab_select_Contas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Nome_Conta;
        private MaterialSkin.Controls.MaterialLabel lbl_Nome_Conta;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cadastrar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Descricao;
        private MaterialSkin.Controls.MaterialLabel lbl_Descricao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Valor;
        private MaterialSkin.Controls.MaterialLabel lbl_Valor;
        private MaterialSkin.Controls.MaterialLabel lbl_Data;
        private MaterialSkin.Controls.MaterialLabel lbl_Status;
        private MaterialSkin.Controls.MaterialCheckBox chk_Status;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private MaterialSkin.Controls.MaterialRaisedButton btn_consultar;
    }
}

