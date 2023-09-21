using System;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastroFuncionario : WinFormsFolhaDePagamento.frmCadastro
    {
        frmConsultaCidade frmConsultaCidade;
        Funcionario funcionario;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            frmConsultaCidade = new frmConsultaCidade();

        }

        public override void ConhecaObj(object obj)
        {
            funcionario = (Funcionario)obj;
        }

        private void btnPesquisarCidadeFuncionario_Click(object sender, EventArgs e)
        {
            frmConsultaCidade.ShowDialog();
        }

        public override void Salvar()
        {
            base.Salvar();
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.Idade = Convert.ToInt32(txtIdade.Text);
            funcionario.cidade.Nome = txtCidadeFuncionario.Text;
            funcionario.Matricula = Convert.ToInt32(txtMatricula.Text);
            funcionario.NumDep = Convert.ToInt32(txtNumDepartamento.Text);
            funcionario.SalarioBase = Convert.ToDouble(txtSalarioFuncionario.Text);

            if (sexoMasculino.Checked)
            {
                funcionario.Sexo = "Masculino";
            }
            else
            {
                funcionario.Sexo = "Feminino";
            }
            if (cargoChefe.Checked)
            {
                funcionario.Cargo = "Chefe";
            }
            else
            {
                funcionario.Cargo = "Apoio";
            }
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomeFuncionario.Clear();
            txtIdade.Clear();
            txtCidadeFuncionario.Clear();
            txtMatricula.Clear();
            txtNumDepartamento.Clear();
            txtSalarioFuncionario.Clear();
            sexoFeminino.Checked = false;
            sexoMasculino.Checked = false;
            cargoChefe.Checked = false;
            cargoApoio.Checked = false;
        }

        public override void Carregar()
        {
            base.Carregar();
            txtBase.Text = funcionario.Id.ToString();
            txtNomeFuncionario.Text = funcionario.Nome;
            txtIdade.Text = funcionario.Idade.ToString();
            txtCidadeFuncionario.Text = funcionario.cidade.Nome;
            txtMatricula.Text = funcionario.Matricula.ToString();
            txtNumDepartamento.Text = funcionario.NumDep.ToString();
            txtSalarioFuncionario.Text = funcionario.SalarioBase.ToString();

            if (funcionario.Sexo == "Masculino")
            {
                sexoMasculino.Checked = true;
            }
            else
            {
                sexoFeminino.Checked = false;
            }
            if (funcionario.Cargo == "Chefe")
            {
                cargoChefe.Checked = false;
            }
            else
            {
                cargoApoio.Checked = false;
            }
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomeFuncionario.Enabled = false;
            txtIdade.Enabled = false;
            txtCidadeFuncionario.Enabled = false;
            txtMatricula.Enabled = false;
            txtNumDepartamento.Enabled = false;
            txtSalarioFuncionario.Enabled = false;
            sexoFeminino.Enabled = false;
            sexoMasculino.Enabled = false;
            cargoChefe.Enabled = false;
            cargoApoio.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Bloquear();
            txtNomeFuncionario.Enabled = true;
            txtIdade.Enabled = true;
            txtCidadeFuncionario.Enabled = true;
            txtMatricula.Enabled = true;
            txtNumDepartamento.Enabled = true;
            txtSalarioFuncionario.Enabled = true;
            sexoFeminino.Enabled = true;
            sexoMasculino.Enabled = true;
            cargoChefe.Enabled = true;
            cargoApoio.Enabled = true;
        }
    }
}
