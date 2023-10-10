using System;
using WinFormsFolhaDePagamento.Modelos;
using WinFormsFolhaDePagamento.Modelos.Interface;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastroCidade : WinFormsFolhaDePagamento.frmCadastro
    {
        frmConsultaEstado frmConsultaEstado;
        Cidade cidade = new Cidade();
        
        public frmCadastroCidade()
        {
            InitializeComponent();
            cidade.Estado = new Estado();
        }

        public override void ConhecaObj(object obj)
        {
            cidade = (Cidade)obj;
        }

        private void btnPesquisarEstado_Click(object sender, EventArgs e)
        {
            frmConsultaEstado.ShowDialog();
        }

        public void SetConsultaEstado(object obj)
        {
            frmConsultaEstado = (frmConsultaEstado) obj;
        }

        public override void Salvar()
        {
            base.Salvar();
            //cidade.Id = int.Parse(txtBase.Text);
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
            txtBase.Text = cidade.Id.ToString();
            txtNomeCidade.Text = cidade.Nome;
            txtEstado.Text = cidade.Estado.Nome;
            txtDDD.Text = cidade.DDD;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtBase.Enabled = false;
            txtNomeCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtDDD.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Desbloquear();
            txtBase.Enabled = true;
            txtNomeCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtDDD.Enabled = true;
        }
    }
}
