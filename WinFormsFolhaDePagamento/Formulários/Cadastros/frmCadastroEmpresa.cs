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
    public partial class frmCadastroEmpresa : WinFormsFolhaDePagamento.frmCadastro
    {
        Empresa empresa;
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            empresa = (Empresa)obj;
        }

        public override void Salvar()
        {
            base.Salvar();
            empresa.RazaoSocial = txtRazaoSocial.Text;
            empresa.NumFuncionarios = Convert.ToInt32(txtQuantidadeFuncionario.Text);
            empresa.Cnpj = txtCNPJ.Text;
        }

        public override void Limpar()
        {
            base.Limpar();
            txtRazaoSocial.Clear();
            txtQuantidadeFuncionario.Clear();
            txtCNPJ.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtRazaoSocial.Text = empresa.RazaoSocial;
            txtQuantidadeFuncionario.Text = empresa.NumFuncionarios.ToString();
            txtCNPJ.Text = empresa.Cnpj;

        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtRazaoSocial.Enabled = false;
            txtQuantidadeFuncionario.Enabled = false;
            txtCNPJ.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Bloquear();
            txtRazaoSocial.Enabled = true;
            txtQuantidadeFuncionario.Enabled = true;
            txtCNPJ.Enabled = true;
        }
    }
}
