namespace WinFormsFolhaDePagamento
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTitleBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 65);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBase.Location = new System.Drawing.Point(12, 49);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Código";
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.AutoSize = true;
            this.lblTitleBase.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleBase.Location = new System.Drawing.Point(12, 15);
            this.lblTitleBase.Name = "lblTitleBase";
            this.lblTitleBase.Size = new System.Drawing.Size(71, 31);
            this.lblTitleBase.TabIndex = 3;
            this.lblTitleBase.Text = "Base";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnSair);
            this.Name = "frmBase";
            this.Text = "Formulário Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.TextBox txtBase;
        protected System.Windows.Forms.Label lblBase;
        protected System.Windows.Forms.Label lblTitleBase;
    }
}