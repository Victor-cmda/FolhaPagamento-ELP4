using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaPais : WinFormsFolhaDePagamento.frmConsulta
    {
        Pais pais;
        frmCadastroPais frmCadastroPais;
        public frmConsultaPais()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            pais = (Pais)obj;
        }

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroPais.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroPais.ConhecaObj(pais);
            frmCadastroPais.Carregar();
            frmCadastroPais.ShowDialog();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadastroPais = (frmCadastroPais)obj;
            }
        }
    }
}
