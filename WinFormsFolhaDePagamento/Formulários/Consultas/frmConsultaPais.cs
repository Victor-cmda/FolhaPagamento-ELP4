using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;
using WinFormsFolhaDePagamento.Modelos.Banco;

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

        public override void CarregaListView()
        {
            listViewOfConsulta.Items.Clear();

            var query = "SELECT * FROM Pais";
            List<Pais> paises = Banco.SelectAll(query, ConvertToPais);

            foreach (var pais in paises)
            {
                ListViewItem item = new ListViewItem(pais.Id.ToString());

                item.SubItems.Add(pais.Nome);
                item.SubItems.Add(pais.Sigla);
                item.SubItems.Add(pais.Moeda);

                listViewOfConsulta.Tag = pais;

                listViewOfConsulta.Items.Add(item);
            }

            base.CarregaListView();
        }

        private static Pais ConvertToPais(SqlDataReader reader)
        {
            return new Pais
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nome = reader["Nome"].ToString(),
                Moeda = reader["Moeda"].ToString(),
                Sigla = reader["Sigla"].ToString()
            };
        }

        public override void Inserir()
        {
            frmCadastroPais.Limpar();
            frmCadastroPais.ShowDialog();
            base.Inserir();

            CarregaListView();
        }

        public override void Alterar()
        {
            if (listViewOfConsulta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um país para alterar.");
                return;
            }

            var selectedItem = listViewOfConsulta.SelectedItems[0];

            string id = selectedItem.SubItems[0].Text;
            string nome = selectedItem.SubItems[1].Text;
            string sigla = selectedItem.SubItems[2].Text;
            string moeda = selectedItem.SubItems[3].Text;

            Pais pais = new Pais
            {
                Id = int.Parse(id),
                Nome = nome,
                Sigla = sigla,
                Moeda = moeda
            };

            frmCadastroPais.ConhecaObj(pais);
            frmCadastroPais.Carregar();
            frmCadastroPais.ShowDialog();

            base.Alterar();

            CarregaListView();
        }

        public override void Excluir()
        {
            if (listViewOfConsulta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um país para excluir.");
                return;
            }

            var selectedItem = listViewOfConsulta.SelectedItems[0];

            string id = selectedItem.SubItems[0].Text;
            string nome = selectedItem.SubItems[1].Text;
            string sigla = selectedItem.SubItems[2].Text;
            string moeda = selectedItem.SubItems[3].Text;

            Pais pais = new Pais
            {
                Id = int.Parse(id),
                Nome = nome,
                Sigla = sigla,
                Moeda = moeda
            };

            frmCadastroPais.ConhecaObj(pais);
            frmCadastroPais.Carregar();
            frmCadastroPais.Bloquear();
            frmCadastroPais.Excluir(true);
            frmCadastroPais.ShowDialog();
            frmCadastroPais.Desbloquear();
            base.Excluir();
            frmCadastroPais.Excluir(false);

            CarregaListView();
        }

        public void Selecionar(bool aux)
        {
            if (aux)
            {
                btnSair.Text = "Selecionar";
            }
            else
            {
                btnSair.Text = "Sair";
            }
        }

        public override void Sair()
        {
            if (btnSair.Text == "Selecionar")
            {
                var PaisSelecionado = listViewOfConsulta.SelectedItems[0];

                pais.Id = int.Parse(PaisSelecionado.SubItems[0].Text);
                pais.Nome = PaisSelecionado.SubItems[1].Text;
                pais.Sigla = PaisSelecionado.SubItems[2].Text;
                pais.Moeda = PaisSelecionado.SubItems[3].Text;
            }

            base.Sair();
        }

        public override void Pesquisar()
        {
            listViewOfConsulta.Items.Clear();
            var filter = txtBase.Text;
            string query;
            if (!string.IsNullOrEmpty(filter))
            {
                if (int.TryParse(filter, out int id))
                {
                    query = $"SELECT * FROM Pais WHERE Id = {id}";
                }
                else
                {
                    query = $"SELECT * FROM Pais WHERE Nome like '%{filter}%' OR Sigla like '%{filter}%' OR Moeda like '%{filter}%'";
                }
                List<Pais> paises = Banco.SelectAll(query, ConvertToPais);

                foreach (var pais in paises)
                {
                    ListViewItem item = new ListViewItem(pais.Id.ToString());

                    item.SubItems.Add(pais.Nome);
                    item.SubItems.Add(pais.Sigla);
                    item.SubItems.Add(pais.Moeda);

                    listViewOfConsulta.Tag = pais;

                    listViewOfConsulta.Items.Add(item);
                }

                base.CarregaListView();
                base.Pesquisar();
            }
            else
            {
                CarregaListView();
            }
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
