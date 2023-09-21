using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaEmpresa : WinFormsFolhaDePagamento.frmConsulta
    {
        Empresa empresa;
        frmCadastroEmpresa frmCadastroEmpresa;
        public frmConsultaEmpresa()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            empresa = (Empresa)obj;
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroEmpresa.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroEmpresa.ConhecaObj(empresa);
            frmCadastroEmpresa.Carregar();
            frmCadastroEmpresa.ShowDialog();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadastroEmpresa = (frmCadastroEmpresa)obj;
            }
        }
    }
}
