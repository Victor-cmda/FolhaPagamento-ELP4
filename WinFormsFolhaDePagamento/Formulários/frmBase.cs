using System;
using System.Windows.Forms;

namespace WinFormsFolhaDePagamento
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        public virtual void Sair()
        {
            Close();
        }

        public virtual void ConhecaObj(object obj)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
