using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaCidade : WinFormsFolhaDePagamento.frmConsulta
    {
        Cidade cidade;
        frmCadastroCidade frmCadastroCidade;
        public frmConsultaCidade()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroCidade.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroCidade.ConhecaObj(cidade);
            frmCadastroCidade.Carregar();
            frmCadastroCidade.ShowDialog();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadastroCidade = (frmCadastroCidade)obj;
            }
        }
    }
}
