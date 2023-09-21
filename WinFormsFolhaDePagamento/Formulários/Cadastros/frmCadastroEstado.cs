using System;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastroEstado : WinFormsFolhaDePagamento.frmCadastro
    {
        frmConsultaPais frmConsultaPais;
        Estado estado;
        public frmCadastroEstado()
        {
            InitializeComponent();
            frmConsultaPais = new frmConsultaPais();

        }

        public override void ConhecaObj(object obj)
        {
            estado = (Estado)obj;
        }

        public override void Salvar()
        {
            base.Salvar();
            estado.Nome = txtNomeEstado.Text;
            estado.UF = txtUF.Text;
            estado.Pais = (Pais)frmConsultaPais.Selecionado;
        }

        private void btnPesquisarPais_Click(object sender, EventArgs e)
        {
            frmConsultaPais.ShowDialog();
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomeEstado.Clear();
            txtUF.Clear();
            txtPais.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtNomeEstado.Text = estado.Nome;
            txtUF.Text = estado.UF;
            txtPais.Text = estado.Pais.Nome;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomeEstado.Enabled = false;
            txtUF.Enabled = false;
            txtPais.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Bloquear();
            txtNomeEstado.Enabled = true;
            txtUF.Enabled = true;
            txtPais.Enabled = true;
        }
    }
}
