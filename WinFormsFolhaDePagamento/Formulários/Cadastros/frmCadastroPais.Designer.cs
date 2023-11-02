namespace WinFormsFolhaDePagamento
{
    partial class frmCadastroPais
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomePais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiglaPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(182, 31);
            this.lblTitleBase.Text = "Cadastro País";
            // 
            // txtNomePais
            // 
            this.txtNomePais.Location = new System.Drawing.Point(118, 65);
            this.txtNomePais.MaxLength = 100;
            this.txtNomePais.Name = "txtNomePais";
            this.txtNomePais.Size = new System.Drawing.Size(165, 20);
            this.txtNomePais.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(286, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sigla";
            // 
            // txtSiglaPais
            // 
            this.txtSiglaPais.Location = new System.Drawing.Point(289, 65);
            this.txtSiglaPais.MaxLength = 3;
            this.txtSiglaPais.Name = "txtSiglaPais";
            this.txtSiglaPais.Size = new System.Drawing.Size(35, 20);
            this.txtSiglaPais.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(327, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Moeda";
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(330, 65);
            this.txtMoeda.MaxLength = 4;
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(100, 20);
            this.txtMoeda.TabIndex = 10;
            // 
            // frmCadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiglaPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePais);
            this.Name = "frmCadastroPais";
            this.Text = "Formulário de Cadastro de País";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.lblBase, 0);
            this.Controls.SetChildIndex(this.lblTitleBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtNomePais, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSiglaPais, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiglaPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoeda;
    }
}
