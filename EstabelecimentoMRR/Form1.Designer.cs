namespace EstabelecimentoMRR
{
    partial class frm_EstabelecimentoMRR
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
            this.rb_Pendente = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_Quitada = new MaterialSkin.Controls.MaterialRadioButton();
            this.txt_Descricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_Descricao = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Valor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_Valor = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Data = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.tab_contr_Contas.Location = new System.Drawing.Point(0, 93);
            this.tab_contr_Contas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_contr_Contas.Name = "tab_contr_Contas";
            this.tab_contr_Contas.SelectedIndex = 0;
            this.tab_contr_Contas.Size = new System.Drawing.Size(1316, 687);
            this.tab_contr_Contas.TabIndex = 2;
            // 
            // Pg_Pagar
            // 
            this.Pg_Pagar.BackColor = System.Drawing.Color.White;
            this.Pg_Pagar.Controls.Add(this.rb_Pendente);
            this.Pg_Pagar.Controls.Add(this.rb_Quitada);
            this.Pg_Pagar.Controls.Add(this.txt_Descricao);
            this.Pg_Pagar.Controls.Add(this.lbl_Descricao);
            this.Pg_Pagar.Controls.Add(this.txt_Valor);
            this.Pg_Pagar.Controls.Add(this.lbl_Valor);
            this.Pg_Pagar.Controls.Add(this.txt_Data);
            this.Pg_Pagar.Controls.Add(this.lbl_Data);
            this.Pg_Pagar.Controls.Add(this.txt_Nome_Conta);
            this.Pg_Pagar.Controls.Add(this.lbl_Nome_Conta);
            this.Pg_Pagar.Controls.Add(this.btn_Cadastrar);
            this.Pg_Pagar.Location = new System.Drawing.Point(4, 25);
            this.Pg_Pagar.Name = "Pg_Pagar";
            this.Pg_Pagar.Padding = new System.Windows.Forms.Padding(3);
            this.Pg_Pagar.Size = new System.Drawing.Size(1308, 658);
            this.Pg_Pagar.TabIndex = 0;
            this.Pg_Pagar.Text = "Contas a Pagar";
            // 
            // rb_Pendente
            // 
            this.rb_Pendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Pendente.AutoSize = true;
            this.rb_Pendente.Depth = 0;
            this.rb_Pendente.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_Pendente.Location = new System.Drawing.Point(697, 328);
            this.rb_Pendente.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Pendente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_Pendente.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_Pendente.Name = "rb_Pendente";
            this.rb_Pendente.Ripple = true;
            this.rb_Pendente.Size = new System.Drawing.Size(103, 30);
            this.rb_Pendente.TabIndex = 12;
            this.rb_Pendente.TabStop = true;
            this.rb_Pendente.Text = "Pendente";
            this.rb_Pendente.UseVisualStyleBackColor = true;
            // 
            // rb_Quitada
            // 
            this.rb_Quitada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_Quitada.AutoSize = true;
            this.rb_Quitada.Depth = 0;
            this.rb_Quitada.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_Quitada.Location = new System.Drawing.Point(472, 328);
            this.rb_Quitada.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Quitada.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_Quitada.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_Quitada.Name = "rb_Quitada";
            this.rb_Quitada.Ripple = true;
            this.rb_Quitada.Size = new System.Drawing.Size(90, 30);
            this.rb_Quitada.TabIndex = 11;
            this.rb_Quitada.TabStop = true;
            this.rb_Quitada.Text = "Quitada";
            this.rb_Quitada.UseVisualStyleBackColor = true;
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
            this.txt_Descricao.TabIndex = 10;
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
            this.txt_Valor.TabIndex = 6;
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
            // txt_Data
            // 
            this.txt_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Data.Depth = 0;
            this.txt_Data.Hint = "";
            this.txt_Data.Location = new System.Drawing.Point(467, 195);
            this.txt_Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.PasswordChar = '\0';
            this.txt_Data.SelectedText = "";
            this.txt_Data.SelectionLength = 0;
            this.txt_Data.SelectionStart = 0;
            this.txt_Data.Size = new System.Drawing.Size(471, 28);
            this.txt_Data.TabIndex = 4;
            this.txt_Data.UseSystemPasswordChar = false;
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
            this.txt_Nome_Conta.TabIndex = 2;
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
            this.lbl_Nome_Conta.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Depth = 0;
            this.btn_Cadastrar.Location = new System.Drawing.Point(467, 481);
            this.btn_Cadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Primary = true;
            this.btn_Cadastrar.Size = new System.Drawing.Size(277, 23);
            this.btn_Cadastrar.TabIndex = 0;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Pg_Receber
            // 
            this.Pg_Receber.Location = new System.Drawing.Point(4, 25);
            this.Pg_Receber.Name = "Pg_Receber";
            this.Pg_Receber.Padding = new System.Windows.Forms.Padding(3);
            this.Pg_Receber.Size = new System.Drawing.Size(1308, 658);
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
            this.tab_select_Contas.Size = new System.Drawing.Size(1316, 23);
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
            this.Name = "frm_EstabelecimentoMRR";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Data;
        private MaterialSkin.Controls.MaterialLabel lbl_Data;
        private MaterialSkin.Controls.MaterialRadioButton rb_Pendente;
        private MaterialSkin.Controls.MaterialRadioButton rb_Quitada;
    }
}

