using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;
using WinFormsFolhaDePagamento.Modelos.Banco;

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

        public override void CarregaListView()
        {
            listViewOfConsulta.Items.Clear();

            var query = "SELECT * FROM Estado";
            List<Estado> estados = Banco.SelectAll(query, ConvertToEstado);

            foreach (var est in estados)
            {
                ListViewItem item = new ListViewItem(est.Id.ToString());
                item.SubItems.Add(est.Nome);
                item.SubItems.Add(est.UF);
                item.SubItems.Add(est.Pais.Nome);

                listViewOfConsulta.Items.Add(item);
            }

            base.CarregaListView();
        }

        private static Estado ConvertToEstado(SqlDataReader reader)
        {
            Pais pais = new Pais
            {
                Id = Convert.ToInt32(reader["PaisId"]),  
            };

            return new Estado
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nome = reader["Nome"].ToString(),
                UF = reader["UF"].ToString(),
                Pais = pais
            };
        }

        public override void Inserir()
        {
            frmCadastroEstado.Limpar();
            frmCadastroEstado.ShowDialog();
            base.Inserir();

            CarregaListView();
        }

        public override void Alterar()
        {
            if (listViewOfConsulta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um estado para alterar.");
                return;
            }

            var selectedItem = listViewOfConsulta.SelectedItems[0];

            estado = new Estado
            {
                Id = int.Parse(selectedItem.SubItems[0].Text),
                Nome = selectedItem.SubItems[1].Text,
                UF = selectedItem.SubItems[2].Text,
                // Pais deve ser carregado ou atribuído aqui conforme a necessidade
            };

            frmCadastroEstado.ConhecaObj(estado);
            frmCadastroEstado.Carregar();
            frmCadastroEstado.ShowDialog();

            base.Alterar();

            CarregaListView();
        }

        public override void Excluir()
        {
            if (listViewOfConsulta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um estado para excluir.");
                return;
            }

            var selectedItem = listViewOfConsulta.SelectedItems[0];
            estado = new Estado
            {
                Id = int.Parse(selectedItem.SubItems[0].Text)
            };

            frmCadastroEstado.ConhecaObj(estado);
            frmCadastroEstado.Carregar();
            frmCadastroEstado.Bloquear();
            frmCadastroEstado.Excluir(true);
            frmCadastroEstado.ShowDialog();
            frmCadastroEstado.Desbloquear();
            base.Excluir();
            frmCadastroEstado.Excluir(false);

            CarregaListView();
        }

        public override void SetFrmCadastro(object obj)
        {
            frmCadastroEstado = obj as frmCadastroEstado;
        }
    }
}
