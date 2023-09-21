using System;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmPrincipal : Form
    {
        Empresa empresa = new Empresa();

        public frmPrincipal()
        {
            InitializeComponent();
            empresa.Id = 1;
            empresa.RazaoSocial = "Empresa 1";
            empresa.Cnpj = "123456789";
            empresa.NumFuncionarios = 10;
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpresa frm = new frmConsultaEmpresa();
            frm.ConhecaObj(empresa);
            frm.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario frm = new frmConsultaFuncionario();
            frm.ShowDialog();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPais frm = new frmConsultaPais();
            frm.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstado frm = new frmConsultaEstado();
            frm.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCidade frm = new frmConsultaCidade();
            frm.ShowDialog();
        }
    }
}
