namespace WinFormsFolhaDePagamento
{
    partial class frmCadastroEmpresa
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidadeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(242, 31);
            this.lblTitleBase.Text = "Cadastro Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(458, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade de Funcinários";
            // 
            // txtQuantidadeFuncionario
            // 
            this.txtQuantidadeFuncionario.Location = new System.Drawing.Point(461, 65);
            this.txtQuantidadeFuncionario.Name = "txtQuantidadeFuncionario";
            this.txtQuantidadeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeFuncionario.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(310, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(313, 65);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(142, 20);
            this.txtCNPJ.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(118, 65);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(189, 20);
            this.txtRazaoSocial.TabIndex = 11;
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantidadeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazaoSocial);
            this.Name = "frmCadastroEmpresa";
            this.Text = "Formulário de Cadastro de Empresas";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.lblBase, 0);
            this.Controls.SetChildIndex(this.lblTitleBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtRazaoSocial, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCNPJ, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtQuantidadeFuncionario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidadeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazaoSocial;
    }
}
