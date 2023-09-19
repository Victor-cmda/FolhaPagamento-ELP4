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
    public partial class frmConsultaEmpresa : WinFormsFolhaDePagamento.frmConsulta
    {
        Empresa empresa;
        frmCadastroEmpresa frmCadastroEmpresa;
        public frmConsultaEmpresa()
        {
            InitializeComponent();
            frmCadastroEmpresa = new frmCadastroEmpresa();

        }

        public override void ConhecaObj(object obj)
        {
            empresa = (Empresa)obj;
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroEmpresa.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroEmpresa.ConhecaObj(empresa);
            frmCadastroEmpresa.Carregar();
            frmCadastroEmpresa.ShowDialog();
        }
    }
}
