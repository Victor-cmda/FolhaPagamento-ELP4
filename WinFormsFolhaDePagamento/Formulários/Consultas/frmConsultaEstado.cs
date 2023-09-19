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
    public partial class frmConsultaEstado : WinFormsFolhaDePagamento.frmConsulta
    {
        Estado estado;
        frmCadastroEstado frmCadastroEstado;
        public frmConsultaEstado()
        {
            InitializeComponent();
            frmCadastroEstado = new frmCadastroEstado();

        }

        public override void ConhecaObj(object obj)
        {
            estado = (Estado)obj;
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroEstado.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroEstado.ConhecaObj(estado);
            frmCadastroEstado.Carregar();
            frmCadastroEstado.ShowDialog();
        }
    }
}
