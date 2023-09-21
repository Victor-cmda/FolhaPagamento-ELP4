namespace WinFormsFolhaDePagamento.Modelos.Interface
{
    public class Interfaces
    {
        frmConsultaPais frmConsultaPais;
        frmConsultaEstado frmConsultaEstado;
        frmConsultaCidade frmConsultaCidade;
        frmConsultaFuncionario frmConsultaFuncionario;
        frmConsultaEmpresa frmConsultaEmpresa;

        frmCadastroPais frmCadastroPais;
        frmCadastroEstado frmCadastroEstado;
        frmCadastroCidade frmCadastroCidade;
        frmCadastroFuncionario frmCadastroFuncionario;
        frmCadastroEmpresa frmCadastroEmpresa;

        public Interfaces()
        {
            frmConsultaPais = new frmConsultaPais();
            frmConsultaEstado = new frmConsultaEstado();
            frmConsultaCidade = new frmConsultaCidade();
            frmConsultaFuncionario = new frmConsultaFuncionario();
            frmConsultaEmpresa = new frmConsultaEmpresa();

            frmCadastroPais = new frmCadastroPais();
            frmCadastroEstado = new frmCadastroEstado();
            frmCadastroCidade = new frmCadastroCidade();
            frmCadastroFuncionario = new frmCadastroFuncionario();
            frmCadastroEmpresa = new frmCadastroEmpresa();

            frmConsultaEmpresa.SetFrmCadastro(frmCadastroEmpresa);
            frmConsultaFuncionario.SetFrmCadastro(frmCadastroFuncionario);
            frmConsultaPais.SetFrmCadastro(frmCadastroPais);
            frmConsultaEstado.SetFrmCadastro(frmCadastroEstado);
            frmConsultaCidade.SetFrmCadastro(frmCadastroCidade);

            frmCadastroFuncionario.SetConsultaCidade(frmConsultaCidade);
            frmCadastroCidade.SetConsultaEstado(frmConsultaEstado);
            frmCadastroEstado.SetConsultaPais(frmConsultaPais);
        }

        public void ModalConsultaEmpresas(Empresa empresa)
        {
            frmConsultaEmpresa.ConhecaObj(empresa);
            frmConsultaEmpresa.ShowDialog();
        }

        public void ModalConsultaFuncionarios(Funcionario funcionario)
        {
            frmConsultaFuncionario.ConhecaObj(funcionario);
            frmConsultaFuncionario.ShowDialog();
        }

        public void ModalConsultaPaises(Pais pais)
        {
            frmConsultaPais.ConhecaObj(pais);
            frmConsultaPais.ShowDialog();
        }

        public void ModalConsultaEstados(Estado estado)
        {
            frmConsultaEstado.ConhecaObj(estado);
            frmConsultaEstado.ShowDialog();
        }

        public void ModalConsultaCidades(Cidade cidade)
        {
            frmConsultaCidade.ConhecaObj(cidade);
            frmConsultaCidade.ShowDialog();
        }
    }
}
