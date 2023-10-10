namespace WinFormsFolhaDePagamento
{
    partial class frmConsultaEmpresa
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
            this.nomeEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnpjEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrFuncEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewOfConsulta
            // 
            this.listViewOfConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeEmpresa,
            this.cnpjEmpresa,
            this.nrFuncEmpresa});
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(277, 31);
            this.lblTitleBase.Text = "Consulta de Empresa";
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.Text = "Empresa";
            this.nomeEmpresa.Width = 200;
            // 
            // cnpjEmpresa
            // 
            this.cnpjEmpresa.Text = "CNPJ";
            this.cnpjEmpresa.Width = 200;
            // 
            // nrFuncEmpresa
            // 
            this.nrFuncEmpresa.Text = "Qtd. Funcionários";
            this.nrFuncEmpresa.Width = 100;
            // 
            // frmConsultaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsultaEmpresa";
            this.Text = "Formulário de Consulta de Empresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nomeEmpresa;
        private System.Windows.Forms.ColumnHeader cnpjEmpresa;
        private System.Windows.Forms.ColumnHeader nrFuncEmpresa;
    }
}
