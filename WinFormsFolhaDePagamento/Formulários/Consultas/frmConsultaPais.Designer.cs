namespace WinFormsFolhaDePagamento
{
    partial class frmConsultaPais
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
            this.nomePais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siglaPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moedaPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOfConsulta
            // 
            this.listViewOfConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomePais,
            this.siglaPais,
            this.moedaPais});
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(217, 31);
            this.lblTitleBase.Text = "Consulta de País";
            // 
            // nomePais
            // 
            this.nomePais.Text = "País";
            this.nomePais.Width = 200;
            // 
            // siglaPais
            // 
            this.siglaPais.Text = "Sigla";
            // 
            // moedaPais
            // 
            this.moedaPais.Text = "Moeda";
            // 
            // frmConsultaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsultaPais";
            this.Text = "Formulário de Consulta de Países";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nomePais;
        private System.Windows.Forms.ColumnHeader siglaPais;
        private System.Windows.Forms.ColumnHeader moedaPais;
    }
}
