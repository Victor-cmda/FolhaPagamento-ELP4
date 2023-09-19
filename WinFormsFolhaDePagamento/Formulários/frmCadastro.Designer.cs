namespace WinFormsFolhaDePagamento
{
    partial class frmCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Text = "0";
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(190, 31);
            this.lblTitleBase.Text = "Cadastro Base";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(632, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastro";
            this.Text = "Formulário de Cadastro";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.lblBase, 0);
            this.Controls.SetChildIndex(this.lblTitleBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnSalvar;
    }
}
