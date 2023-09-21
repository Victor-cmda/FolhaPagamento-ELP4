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
            frmCadastroCidade = new frmCadastroCidade();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
        }

        public override void Inserir()
        {
            base.Inserir();
            this.frmCadastroCidade.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            this.frmCadastroCidade.ConhecaObj(cidade);
            this.frmCadastroCidade.Carregar();
            this.frmCadastroCidade.ShowDialog();
        }
    }
}
