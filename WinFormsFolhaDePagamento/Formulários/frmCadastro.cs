using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastro : WinFormsFolhaDePagamento.frmBase
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        public virtual void Salvar()
        {
            Sair();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public virtual void Limpar()
        {
            this.txtBase.Clear();
        }

        public virtual void Carregar()
        {

        }

        public override void ConhecaObj(object obj)
        {

        }

        public virtual void Bloquear()
        {
            this.txtBase.Enabled = false;
        }

        public virtual void Desbloquear()
        {
            this.txtBase.Enabled = true;
        }

        public virtual void MostrarErro(Control control, string mensagem)
        {
            control.BackColor = Color.LightPink;

            MessageBox.Show(mensagem);

            control.Focus();
        }
    }
}
