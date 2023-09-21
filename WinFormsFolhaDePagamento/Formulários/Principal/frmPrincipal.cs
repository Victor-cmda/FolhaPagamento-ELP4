using System;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;
using WinFormsFolhaDePagamento.Modelos.Interface;

namespace WinFormsFolhaDePagamento
{
    public partial class frmPrincipal : Form
    {
        private Interfaces aInter;

        Empresa empresa;
        Funcionario funcionario;
        Pais pais;
        Estado estado;
        Cidade cidade;

        public frmPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();

            empresa = new Empresa();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.ModalConsultaEmpresas(empresa);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.ModalConsultaFuncionarios(funcionario);
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.ModalConsultaPaises(pais);
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.ModalConsultaEstados(estado);
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.ModalConsultaCidades(cidade);
        }
    }
}
