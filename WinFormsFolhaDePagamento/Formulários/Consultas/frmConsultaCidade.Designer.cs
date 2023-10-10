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
            this.nomeCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DDDCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeEstadoCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOfConsulta
            // 
            this.listViewOfConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeCidade,
            this.DDDCidade,
            this.nomeEstadoCidade});
            this.listViewOfConsulta.Location = new System.Drawing.Point(12, 92);
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(260, 31);
            this.lblTitleBase.Text = "Consulta de Cidade";
            // 
            // nomeCidade
            // 
            this.nomeCidade.Text = "Cidade";
            this.nomeCidade.Width = 200;
            // 
            // DDDCidade
            // 
            this.DDDCidade.Text = "DDD";
            // 
            // nomeEstadoCidade
            // 
            this.nomeEstadoCidade.Text = "Estado";
            this.nomeEstadoCidade.Width = 200;
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

        private System.Windows.Forms.ColumnHeader nomeCidade;
        private System.Windows.Forms.ColumnHeader DDDCidade;
        private System.Windows.Forms.ColumnHeader nomeEstadoCidade;
    }
}
