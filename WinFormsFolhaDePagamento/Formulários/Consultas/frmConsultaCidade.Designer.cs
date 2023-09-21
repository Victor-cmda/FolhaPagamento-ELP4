namespace WinFormsFolhaDePagamento
{
    partial class frmConsultaCidade
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
            this.SuspendLayout();
            // 
            // listViewOfConsulta
            // 
            this.listViewOfConsulta.Location = new System.Drawing.Point(12, 92);
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(260, 31);
            this.lblTitleBase.Text = "Consulta de Cidade";
            // 
            // frmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsultaCidade";
            this.Text = "Formulário de Consulta de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
