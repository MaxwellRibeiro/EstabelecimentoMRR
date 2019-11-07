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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_select_Contas = new MaterialSkin.Controls.MaterialTabSelector();
            this.tab_contr_Contas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_contr_Contas
            // 
            this.tab_contr_Contas.Controls.Add(this.tabPage1);
            this.tab_contr_Contas.Controls.Add(this.tabPage2);
            this.tab_contr_Contas.Depth = 0;
            this.tab_contr_Contas.Location = new System.Drawing.Point(0, 93);
            this.tab_contr_Contas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_contr_Contas.Name = "tab_contr_Contas";
            this.tab_contr_Contas.SelectedIndex = 0;
            this.tab_contr_Contas.Size = new System.Drawing.Size(1067, 463);
            this.tab_contr_Contas.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1059, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_select_Contas
            // 
            this.tab_select_Contas.BaseTabControl = this.tab_contr_Contas;
            this.tab_select_Contas.Depth = 0;
            this.tab_select_Contas.Location = new System.Drawing.Point(0, 64);
            this.tab_select_Contas.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_select_Contas.Name = "tab_select_Contas";
            this.tab_select_Contas.Size = new System.Drawing.Size(1067, 23);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tab_contr_Contas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tab_select_Contas;
    }
}

