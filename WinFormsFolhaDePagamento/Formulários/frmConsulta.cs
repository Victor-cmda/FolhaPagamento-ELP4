using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsulta : WinFormsFolhaDePagamento.frmBase
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        public virtual void Pesquisar()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Inserir()
        {

        }
        public virtual void Alterar()
        {

        }

        public override void ConhecaObj(object obj)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
