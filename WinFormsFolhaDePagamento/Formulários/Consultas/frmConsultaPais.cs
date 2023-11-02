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

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadastroPais = (frmCadastroPais)obj;
            }
        }
    }
}
