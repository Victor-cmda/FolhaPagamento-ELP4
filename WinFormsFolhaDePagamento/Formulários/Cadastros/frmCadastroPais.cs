using System.Windows.Forms;
using System;
using WinFormsFolhaDePagamento.Modelos;
using System.Drawing;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastroPais : WinFormsFolhaDePagamento.frmCadastro
    {
        Pais pais = new Pais();
        private bool estamosExcluindo = false;

        public frmCadastroPais()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            pais = (Pais)obj;
        }

        public override void Salvar()
        {
            bool isValid = true;

            ResetarVisualizacaoControles();

            if (string.IsNullOrWhiteSpace(txtNomePais.Text))
            {
                MostrarErro(txtNomePais, "O nome do país é obrigatório.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSiglaPais.Text))
            {
                MostrarErro(txtSiglaPais, "A sigla do país é obrigatória.");
                isValid = false;
            }
            else if (txtSiglaPais.Text.Length > 3)
            {
                MostrarErro(txtSiglaPais, "A sigla do país deve ter no máximo 3 letras.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMoeda.Text))
            {
                MostrarErro(txtMoeda, "A moeda do país é obrigatória.");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            var idPais = txtBase.Text.Trim();
            pais.Nome = txtNomePais.Text.Trim();
            pais.Sigla = txtSiglaPais.Text.Trim().ToUpper();
            pais.Moeda = txtMoeda.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(idPais))
                {
                    string resultado = pais.Save();
                    if (resultado == "error") throw new Exception("Erro ao inserir o país.");
                }
                else if (estamosExcluindo && MessageBox.Show("Tem certeza que deseja excluir este país?", "Confirmar Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool resultado = pais.Delete();
                    if (!resultado) throw new Exception("Erro ao excluir o país.");
                }
                else
                {
                    bool resultado = pais.Update();
                    if (!resultado) throw new Exception("Erro ao atualizar o país.");
                }

                base.Salvar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void ResetarVisualizacaoControles()
        {
            txtNomePais.BackColor = Color.White;
            txtSiglaPais.BackColor = Color.White;
            txtMoeda.BackColor = Color.White;
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomePais.Clear();
            txtSiglaPais.Clear();
            txtMoeda.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtBase.Text = pais.Id.ToString();
            txtNomePais.Text = pais.Nome;
            txtSiglaPais.Text = pais.Sigla;
            txtMoeda.Text = pais.Moeda;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomePais.Enabled = false;
            txtSiglaPais.Enabled = false;
            txtMoeda.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Bloquear();
            txtNomePais.Enabled = true;
            txtSiglaPais.Enabled = true;
            txtMoeda.Enabled = true;
        }

        public void Excluir(bool delete)
        {
            estamosExcluindo = delete;
        }
    }
}
