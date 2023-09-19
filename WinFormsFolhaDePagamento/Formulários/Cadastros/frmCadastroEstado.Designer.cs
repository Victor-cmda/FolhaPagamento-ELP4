namespace WinFormsFolhaDePagamento
{
    partial class frmCadastroEstado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnPesquisarPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(216, 31);
            this.lblTitleBase.Text = "Cadastro Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.Location = new System.Drawing.Point(118, 65);
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(166, 20);
            this.txtNomeEstado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(287, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(290, 66);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(34, 20);
            this.txtUF.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(327, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(330, 65);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(163, 20);
            this.txtPais.TabIndex = 12;
            // 
            // btnPesquisarPais
            // 
            this.btnPesquisarPais.Location = new System.Drawing.Point(499, 63);
            this.btnPesquisarPais.Name = "btnPesquisarPais";
            this.btnPesquisarPais.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPais.TabIndex = 14;
            this.btnPesquisarPais.Text = "&Pesquisar";
            this.btnPesquisarPais.UseVisualStyleBackColor = true;
            this.btnPesquisarPais.Click += new System.EventHandler(this.btnPesquisarPais_Click);
            // 
            // frmCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisarPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEstado);
            this.Name = "frmCadastroEstado";
            this.Text = "Formulário de Cadastro de Estados";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.lblBase, 0);
            this.Controls.SetChildIndex(this.lblTitleBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtNomeEstado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnPesquisarPais;
    }
}
