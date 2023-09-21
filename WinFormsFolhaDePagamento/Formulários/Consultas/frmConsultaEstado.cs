using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaEstado : WinFormsFolhaDePagamento.frmConsulta
    {
        Estado estado;
        frmCadastroEstado frmCadastroEstado;
        public frmConsultaEstado()
        {
            InitializeComponent();

        }

        public override void ConhecaObj(object obj)
        {
            estado = (Estado)obj;
        }

        

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroEstado.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroEstado.ConhecaObj(estado);
            frmCadastroEstado.Carregar();
            frmCadastroEstado.ShowDialog();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadastroEstado = (frmCadastroEstado)obj;
            }
        }
    }
}
