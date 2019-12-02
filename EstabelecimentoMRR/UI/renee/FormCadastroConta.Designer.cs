namespace EstabelecimentoMRR.UI.renee
{
    partial class FormCadastroConta
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
            this.rb_Despesa = new System.Windows.Forms.RadioButton();
            this.rb_Receita = new System.Windows.Forms.RadioButton();
            this.lbl_Tipo = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Alterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(295, 321);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(319, 22);
            this.dtp_Data.TabIndex = 2;
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
            this.lbl_Status.Location = new System.Drawing.Point(711, 252);
            this.lbl_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(68, 24);
            this.lbl_Status.TabIndex = 48;
            this.lbl_Status.Text = "Status:";
            // 
            // chk_Status
            // 
            this.chk_Status.AutoSize = true;
            this.chk_Status.Depth = 0;
            this.chk_Status.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk_Status.Location = new System.Drawing.Point(782, 250);
            this.chk_Status.Margin = new System.Windows.Forms.Padding(0);
            this.chk_Status.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_Status.Name = "chk_Status";
            this.chk_Status.Ripple = true;
            this.chk_Status.Size = new System.Drawing.Size(103, 30);
            this.chk_Status.TabIndex = 4;
            this.chk_Status.Text = "Recebido";
            this.chk_Status.UseVisualStyleBackColor = true;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Descricao.Depth = 0;
            this.txt_Descricao.Hint = "";
            this.txt_Descricao.Location = new System.Drawing.Point(295, 485);
            this.txt_Descricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.PasswordChar = '\0';
            this.txt_Descricao.SelectedText = "";
            this.txt_Descricao.SelectionLength = 0;
            this.txt_Descricao.SelectionStart = 0;
            this.txt_Descricao.Size = new System.Drawing.Size(892, 28);
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
            this.lbl_Descricao.Location = new System.Drawing.Point(163, 485);
            this.lbl_Descricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(94, 24);
            this.lbl_Descricao.TabIndex = 47;
            this.lbl_Descricao.Text = "Descricao";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Valor.Depth = 0;
            this.txt_Valor.Hint = "";
            this.txt_Valor.Location = new System.Drawing.Point(295, 409);
            this.txt_Valor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.PasswordChar = '\0';
            this.txt_Valor.SelectedText = "";
            this.txt_Valor.SelectionLength = 0;
            this.txt_Valor.SelectionStart = 0;
            this.txt_Valor.Size = new System.Drawing.Size(647, 28);
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
            this.lbl_Valor.Location = new System.Drawing.Point(207, 409);
            this.lbl_Valor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(59, 24);
            this.lbl_Valor.TabIndex = 46;
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
            this.lbl_Data.Location = new System.Drawing.Point(107, 321);
            this.lbl_Data.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(159, 24);
            this.lbl_Data.TabIndex = 43;
            this.lbl_Data.Text = "Data Vencimento:";
            // 
            // txt_Nome_Conta
            // 
            this.txt_Nome_Conta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome_Conta.Depth = 0;
            this.txt_Nome_Conta.Hint = "";
            this.txt_Nome_Conta.Location = new System.Drawing.Point(295, 171);
            this.txt_Nome_Conta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Nome_Conta.Name = "txt_Nome_Conta";
            this.txt_Nome_Conta.PasswordChar = '\0';
            this.txt_Nome_Conta.SelectedText = "";
            this.txt_Nome_Conta.SelectionLength = 0;
            this.txt_Nome_Conta.SelectionStart = 0;
            this.txt_Nome_Conta.Size = new System.Drawing.Size(647, 28);
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
            this.lbl_Nome_Conta.Location = new System.Drawing.Point(119, 171);
            this.lbl_Nome_Conta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Nome_Conta.Name = "lbl_Nome_Conta";
            this.lbl_Nome_Conta.Size = new System.Drawing.Size(147, 24);
            this.lbl_Nome_Conta.TabIndex = 41;
            this.lbl_Nome_Conta.Text = "Nome da Conta:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Depth = 0;
            this.btn_Cadastrar.Location = new System.Drawing.Point(432, 555);
            this.btn_Cadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Primary = true;
            this.btn_Cadastrar.Size = new System.Drawing.Size(453, 50);
            this.btn_Cadastrar.TabIndex = 6;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // rb_Despesa
            // 
            this.rb_Despesa.AutoSize = true;
            this.rb_Despesa.Location = new System.Drawing.Point(302, 255);
            this.rb_Despesa.Name = "rb_Despesa";
            this.rb_Despesa.Size = new System.Drawing.Size(80, 21);
            this.rb_Despesa.TabIndex = 49;
            this.rb_Despesa.TabStop = true;
            this.rb_Despesa.Text = "A Pagar";
            this.rb_Despesa.UseVisualStyleBackColor = true;
            this.rb_Despesa.CheckedChanged += new System.EventHandler(this.rb_Despesa_CheckedChanged);
            // 
            // rb_Receita
            // 
            this.rb_Receita.AutoSize = true;
            this.rb_Receita.Location = new System.Drawing.Point(460, 255);
            this.rb_Receita.Name = "rb_Receita";
            this.rb_Receita.Size = new System.Drawing.Size(96, 21);
            this.rb_Receita.TabIndex = 50;
            this.rb_Receita.TabStop = true;
            this.rb_Receita.Text = "A Receber";
            this.rb_Receita.UseVisualStyleBackColor = true;
            this.rb_Receita.CheckedChanged += new System.EventHandler(this.rb_Receita_CheckedChanged);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Depth = 0;
            this.lbl_Tipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Tipo.Location = new System.Drawing.Point(133, 250);
            this.lbl_Tipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(133, 24);
            this.lbl_Tipo.TabIndex = 51;
            this.lbl_Tipo.Text = "Tipo da Conta:";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Alterar.Depth = 0;
            this.btn_Alterar.Location = new System.Drawing.Point(432, 555);
            this.btn_Alterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Primary = true;
            this.btn_Alterar.Size = new System.Drawing.Size(453, 50);
            this.btn_Alterar.TabIndex = 52;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 646);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.rb_Receita);
            this.Controls.Add(this.rb_Despesa);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.chk_Status);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.txt_Nome_Conta);
            this.Controls.Add(this.lbl_Nome_Conta);
            this.Controls.Add(this.btn_Cadastrar);
            this.Name = "FormCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private MaterialSkin.Controls.MaterialLabel lbl_Status;
        private MaterialSkin.Controls.MaterialCheckBox chk_Status;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Descricao;
        private MaterialSkin.Controls.MaterialLabel lbl_Descricao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Valor;
        private MaterialSkin.Controls.MaterialLabel lbl_Valor;
        private MaterialSkin.Controls.MaterialLabel lbl_Data;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Nome_Conta;
        private MaterialSkin.Controls.MaterialLabel lbl_Nome_Conta;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Cadastrar;
        private System.Windows.Forms.RadioButton rb_Despesa;
        private System.Windows.Forms.RadioButton rb_Receita;
        private MaterialSkin.Controls.MaterialLabel lbl_Tipo;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Alterar;
    }
}