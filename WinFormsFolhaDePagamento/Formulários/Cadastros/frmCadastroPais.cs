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
    public partial class frmCadastroPais : WinFormsFolhaDePagamento.frmCadastro
    {
        Pais pais = new Pais();
        public frmCadastroPais()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            pais = (Pais)obj;
        }

        public override void Salvar()
        {
            base.Salvar();
            pais.Nome = txtNomePais.Text;
            pais.Sigla = txtSiglaPais.Text;
            pais.Moeda = txtMoeda.Text;
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomePais.Clear();
            txtSiglaPais.Clear();
            txtMoeda.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtBase.Text = pais.Id.ToString();
            txtNomePais.Text = pais.Nome;
            txtSiglaPais.Text = pais.Sigla;
            txtMoeda.Text = pais.Moeda;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomePais.Enabled = false;
            txtSiglaPais.Enabled = false;
            txtMoeda.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Bloquear();
            txtNomePais.Enabled = true;
            txtSiglaPais.Enabled = true;
            txtMoeda.Enabled = true;
        }
    }
}
