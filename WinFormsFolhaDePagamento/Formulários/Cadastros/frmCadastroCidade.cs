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
    public partial class frmCadastroCidade : WinFormsFolhaDePagamento.frmCadastro
    {
        frmConsultaEstado frmConsultaEstado;
        Cidade cidade;
        public frmCadastroCidade()
        {
            InitializeComponent();
            frmConsultaEstado = new frmConsultaEstado();

        }

        public override void ConhecaObj(object obj)
        {
            cidade = (Cidade)obj;
        }

        private void btnPesquisarEstado_Click(object sender, EventArgs e)
        {
            frmConsultaEstado.ShowDialog();
        }

        public override void Salvar()
        {
            base.Salvar();
            cidade.Nome = txtNomeCidade.Text;
            cidade.Estado.Nome = txtEstado.Text;
            cidade.DDD = txtDDD.Text;
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomeCidade.Clear();
            txtEstado.Clear();
            txtDDD.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtNomeCidade.Text = cidade.Nome;
            txtEstado.Text = cidade.Estado.Nome;
            txtDDD.Text = cidade.DDD;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomeCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtDDD.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Desbloquear();
            txtNomeCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtDDD.Enabled = true;
        }
    }
}
