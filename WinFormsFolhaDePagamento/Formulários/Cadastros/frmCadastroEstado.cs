using System;
using System.Windows.Forms;
using System.Drawing;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmCadastroEstado : WinFormsFolhaDePagamento.frmCadastro
    {
        Estado estado = new Estado();

        frmConsultaPais frmConsultaPais;
        private bool estamosExcluindo = false;

        public frmCadastroEstado()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            estado = (Estado)obj;
        }

        public override void Salvar()
        {
            bool isValid = true;

            ResetarVisualizacaoControles();

            if (string.IsNullOrWhiteSpace(txtNomeEstado.Text))
            {
                MostrarErro(txtNomeEstado, "O nome do estado é obrigatório.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtUF.Text))
            {
                MostrarErro(txtUF, "A UF do estado é obrigatória.");
                isValid = false;
            }
            else if (txtUF.Text.Length != 2)
            {
                MostrarErro(txtUF, "A UF do estado deve ter exatamente 2 letras.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MostrarErro(txtPais, "O nome do país é obrigatório.");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            var idEstado= txtBase.Text.Trim();
            estado.Nome = txtNomeEstado.Text.Trim();
            estado.UF = txtUF.Text.Trim().ToUpper();
            // Atribuir o país pelo nome pode requerer uma busca no banco para obter o objeto país correto.
            estado.Pais = new Pais { Nome = txtPais.Text.Trim() };

            try
            {
                if (estamosExcluindo && MessageBox.Show("Tem certeza que deseja excluir este estado?", "Confirmar Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool resultado = estado.Delete();
                    if (!resultado) throw new Exception("Erro ao excluir o estado.");
                }
                else
                {
                    if (string.IsNullOrEmpty(idEstado))
                    {
                        string resultado = estado.Save();
                        if (resultado == "error") throw new Exception("Erro ao inserir o estado.");
                    }
                    else
                    {
                        bool resultado = estado.Update();
                        if (!resultado) throw new Exception("Erro ao atualizar o estado.");
                    }
                }

                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
        private void btnPesquisarPais_Click(object sender, EventArgs e)
        {
            estado.Pais = new Pais();
            frmConsultaPais.Selecionar(true);
            frmConsultaPais.ConhecaObj(estado.Pais);
            frmConsultaPais.ShowDialog();
            txtPais.Text = estado.Pais.Nome;
            frmConsultaPais.Selecionar(false);
        }

        private void ResetarVisualizacaoControles()
        {
            txtNomeEstado.BackColor = Color.White;
            txtUF.BackColor = Color.White;
            txtPais.BackColor = Color.White;
        }

        public override void Limpar()
        {
            base.Limpar();
            txtNomeEstado.Clear();
            txtUF.Clear();
            txtPais.Clear();
        }

        public override void Carregar()
        {
            base.Carregar();
            txtNomeEstado.Text = estado.Nome;
            txtUF.Text = estado.UF;
            // Aqui também seria necessário garantir que o objeto país está correto no estado
            txtPais.Text = estado.Pais?.Nome;
        }

        public override void Bloquear()
        {
            base.Bloquear();
            txtNomeEstado.Enabled = false;
            txtUF.Enabled = false;
            txtPais.Enabled = false;
        }

        public override void Desbloquear()
        {
            base.Desbloquear(); 
            txtNomeEstado.Enabled = true;
            txtUF.Enabled = true;
            txtPais.Enabled = true;
        }

        public void SetConsultaPais(object obj)
        {
            frmConsultaPais = (frmConsultaPais)obj;
        }

        public void Excluir(bool delete)
        {
            estamosExcluindo = delete;
        }
    }
}
