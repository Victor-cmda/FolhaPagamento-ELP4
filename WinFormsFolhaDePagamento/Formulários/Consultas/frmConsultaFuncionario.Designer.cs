namespace WinFormsFolhaDePagamento
{
    partial class frmConsultaFuncionario
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
            this.nomeFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sexoFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idadeFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidadeFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matriculaFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salarioFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gratProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numDepFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cargoFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(851, 415);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(770, 415);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(689, 415);
            // 
            // listViewOfConsulta
            // 
            this.listViewOfConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeFuncionario,
            this.sexoFuncionario,
            this.idadeFuncionario,
            this.cidadeFuncionario,
            this.matriculaFuncionario,
            this.salarioFuncionario,
            this.gratProd,
            this.numDepFuncionario,
            this.cargoFuncionario});
            this.listViewOfConsulta.Size = new System.Drawing.Size(995, 318);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(932, 415);
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(313, 31);
            this.lblTitleBase.Text = "Consulta de Funcionário";
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Text = "Funcionário";
            this.nomeFuncionario.Width = 200;
            // 
            // sexoFuncionario
            // 
            this.sexoFuncionario.Text = "Sexo";
            // 
            // idadeFuncionario
            // 
            this.idadeFuncionario.Text = "Idade";
            // 
            // cidadeFuncionario
            // 
            this.cidadeFuncionario.Text = "Cidade";
            this.cidadeFuncionario.Width = 150;
            // 
            // matriculaFuncionario
            // 
            this.matriculaFuncionario.Text = "Matricula";
            // 
            // salarioFuncionario
            // 
            this.salarioFuncionario.Text = "Salário";
            this.salarioFuncionario.Width = 100;
            // 
            // gratProd
            // 
            this.gratProd.Text = "Gratificação";
            this.gratProd.Width = 80;
            // 
            // numDepFuncionario
            // 
            this.numDepFuncionario.Text = "N. Departamento";
            this.numDepFuncionario.Width = 100;
            // 
            // cargoFuncionario
            // 
            this.cargoFuncionario.Text = "Cargo";
            this.cargoFuncionario.Width = 120;
            // 
            // frmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Name = "frmConsultaFuncionario";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nomeFuncionario;
        private System.Windows.Forms.ColumnHeader sexoFuncionario;
        private System.Windows.Forms.ColumnHeader idadeFuncionario;
        private System.Windows.Forms.ColumnHeader cidadeFuncionario;
        private System.Windows.Forms.ColumnHeader matriculaFuncionario;
        private System.Windows.Forms.ColumnHeader salarioFuncionario;
        private System.Windows.Forms.ColumnHeader gratProd;
        private System.Windows.Forms.ColumnHeader numDepFuncionario;
        private System.Windows.Forms.ColumnHeader cargoFuncionario;
    }
}
