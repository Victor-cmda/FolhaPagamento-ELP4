﻿namespace WinFormsFolhaDePagamento
{
    partial class frmConsultaEstado
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
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(251, 31);
            this.lblTitleBase.Text = "Consulta de Estado";
            // 
            // frmConsultaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsultaEstado";
            this.Text = "Formulário de Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
