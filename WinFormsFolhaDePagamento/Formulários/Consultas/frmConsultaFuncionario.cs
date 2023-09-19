using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaFuncionario : WinFormsFolhaDePagamento.frmConsulta
    {
        Funcionario funcionario;
        frmCadastroFuncionario frmCadastroFuncionario;
        public frmConsultaFuncionario()
        {
            InitializeComponent();
            frmCadastroFuncionario = new frmCadastroFuncionario();

        }

        public override void ConhecaObj(object obj)
        {
            funcionario = (Funcionario)obj;
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroFuncionario.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroFuncionario.ConhecaObj(funcionario);
            frmCadastroFuncionario.Carregar();
            frmCadastroFuncionario.ShowDialog();
        }
    }
}
