namespace WinFormsFolhaDePagamento
{
    partial class frmCadastroFuncionario
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
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.txtNumDepartamento = new System.Windows.Forms.TextBox();
            this.cargoChefe = new System.Windows.Forms.RadioButton();
            this.cargoApoio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarCidadeFuncionario = new System.Windows.Forms.Button();
            this.sexoFeminino = new System.Windows.Forms.RadioButton();
            this.sexoMasculino = new System.Windows.Forms.RadioButton();
            this.groupOfSexo = new System.Windows.Forms.GroupBox();
            this.groupOfCargo = new System.Windows.Forms.GroupBox();
            this.groupOfSexo.SuspendLayout();
            this.groupOfCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleBase
            // 
            this.lblTitleBase.Size = new System.Drawing.Size(278, 31);
            this.lblTitleBase.Text = "Cadastro Funcionário";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(118, 65);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(172, 20);
            this.txtNomeFuncionario.TabIndex = 5;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(295, 65);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFuncionario.TabIndex = 6;
            // 
            // txtNumDepartamento
            // 
            this.txtNumDepartamento.Location = new System.Drawing.Point(401, 65);
            this.txtNumDepartamento.Name = "txtNumDepartamento";
            this.txtNumDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtNumDepartamento.TabIndex = 7;
            // 
            // cargoChefe
            // 
            this.cargoChefe.AutoSize = true;
            this.cargoChefe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cargoChefe.Location = new System.Drawing.Point(18, 19);
            this.cargoChefe.Name = "cargoChefe";
            this.cargoChefe.Size = new System.Drawing.Size(53, 17);
            this.cargoChefe.TabIndex = 9;
            this.cargoChefe.TabStop = true;
            this.cargoChefe.Text = "Chefe";
            this.cargoChefe.UseVisualStyleBackColor = true;
            // 
            // cargoApoio
            // 
            this.cargoApoio.AutoSize = true;
            this.cargoApoio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cargoApoio.Location = new System.Drawing.Point(77, 19);
            this.cargoApoio.Name = "cargoApoio";
            this.cargoApoio.Size = new System.Drawing.Size(52, 17);
            this.cargoApoio.TabIndex = 10;
            this.cargoApoio.TabStop = true;
            this.cargoApoio.Text = "Apoio";
            this.cargoApoio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(292, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Salário Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(398, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "N. Departamento";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(507, 65);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(504, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Matricula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(610, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(613, 65);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(31, 20);
            this.txtIdade.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cidade";
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(12, 109);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(172, 20);
            this.txtCidadeFuncionario.TabIndex = 18;
            // 
            // btnPesquisarCidadeFuncionario
            // 
            this.btnPesquisarCidadeFuncionario.Location = new System.Drawing.Point(190, 107);
            this.btnPesquisarCidadeFuncionario.Name = "btnPesquisarCidadeFuncionario";
            this.btnPesquisarCidadeFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCidadeFuncionario.TabIndex = 20;
            this.btnPesquisarCidadeFuncionario.Text = "&Pesquisar";
            this.btnPesquisarCidadeFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarCidadeFuncionario.Click += new System.EventHandler(this.btnPesquisarCidadeFuncionario_Click);
            // 
            // sexoFeminino
            // 
            this.sexoFeminino.AutoSize = true;
            this.sexoFeminino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sexoFeminino.Location = new System.Drawing.Point(83, 19);
            this.sexoFeminino.Name = "sexoFeminino";
            this.sexoFeminino.Size = new System.Drawing.Size(67, 17);
            this.sexoFeminino.TabIndex = 22;
            this.sexoFeminino.TabStop = true;
            this.sexoFeminino.Text = "Feminino";
            this.sexoFeminino.UseVisualStyleBackColor = true;
            // 
            // sexoMasculino
            // 
            this.sexoMasculino.AutoSize = true;
            this.sexoMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sexoMasculino.Location = new System.Drawing.Point(10, 19);
            this.sexoMasculino.Name = "sexoMasculino";
            this.sexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.sexoMasculino.TabIndex = 21;
            this.sexoMasculino.TabStop = true;
            this.sexoMasculino.Text = "Masculino";
            this.sexoMasculino.UseVisualStyleBackColor = true;
            // 
            // groupOfSexo
            // 
            this.groupOfSexo.Controls.Add(this.sexoMasculino);
            this.groupOfSexo.Controls.Add(this.sexoFeminino);
            this.groupOfSexo.Location = new System.Drawing.Point(271, 91);
            this.groupOfSexo.Name = "groupOfSexo";
            this.groupOfSexo.Size = new System.Drawing.Size(161, 48);
            this.groupOfSexo.TabIndex = 24;
            this.groupOfSexo.TabStop = false;
            this.groupOfSexo.Text = "Sexo";
            // 
            // groupOfCargo
            // 
            this.groupOfCargo.Controls.Add(this.cargoApoio);
            this.groupOfCargo.Controls.Add(this.cargoChefe);
            this.groupOfCargo.Location = new System.Drawing.Point(650, 45);
            this.groupOfCargo.Name = "groupOfCargo";
            this.groupOfCargo.Size = new System.Drawing.Size(138, 49);
            this.groupOfCargo.TabIndex = 25;
            this.groupOfCargo.TabStop = false;
            this.groupOfCargo.Text = "Cargo";
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupOfCargo);
            this.Controls.Add(this.groupOfSexo);
            this.Controls.Add(this.btnPesquisarCidadeFuncionario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidadeFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNumDepartamento);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Name = "frmCadastroFuncionario";
            this.Text = "Formulário de Cadastro de Funcionários";
            this.Controls.SetChildIndex(this.txtNomeFuncionario, 0);
            this.Controls.SetChildIndex(this.txtSalarioFuncionario, 0);
            this.Controls.SetChildIndex(this.txtNumDepartamento, 0);
            this.Controls.SetChildIndex(this.txtMatricula, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtIdade, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCidadeFuncionario, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidadeFuncionario, 0);
            this.Controls.SetChildIndex(this.groupOfSexo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtBase, 0);
            this.Controls.SetChildIndex(this.lblBase, 0);
            this.Controls.SetChildIndex(this.lblTitleBase, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.groupOfCargo, 0);
            this.groupOfSexo.ResumeLayout(false);
            this.groupOfSexo.PerformLayout();
            this.groupOfCargo.ResumeLayout(false);
            this.groupOfCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.TextBox txtNumDepartamento;
        private System.Windows.Forms.RadioButton cargoChefe;
        private System.Windows.Forms.RadioButton cargoApoio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.Button btnPesquisarCidadeFuncionario;
        private System.Windows.Forms.RadioButton sexoFeminino;
        private System.Windows.Forms.RadioButton sexoMasculino;
        private System.Windows.Forms.GroupBox groupOfSexo;
        private System.Windows.Forms.GroupBox groupOfCargo;
    }
}
