using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos.Banco
{
    public static class Banco
    {
        public static SqlConnection Open()
        {
            string connectionString = @"Data Source=DESKTOP-5Q9Q0NQ\SQLEXPRESS;Initial Catalog=folha_de_pagamento;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
