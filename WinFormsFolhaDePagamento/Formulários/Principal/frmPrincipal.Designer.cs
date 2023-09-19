namespace WinFormsFolhaDePagamento
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.paísToolStripMenuItem,
            this.estadoToolStripMenuItem,
            this.cidadeToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paísToolStripMenuItem.Text = "País";
            this.paísToolStripMenuItem.Click += new System.EventHandler(this.paísToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoToolStripMenuItem.Text = "Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPrincipal";
            this.Text = "Bem-Vindo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
    }
}

