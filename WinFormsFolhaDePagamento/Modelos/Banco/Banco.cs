using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsFolhaDePagamento.Modelos.Banco
{
    public static class Banco
    {
        public static SqlConnection Open()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\victo\OneDrive\Documentos\Faculdade\ELP4FolhaPagamento\FolhaPagamento-ELP4\WinFormsFolhaDePagamento\Database\DatabaseFolhaPagamento.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static List<T> SelectAll<T>(string query, Func<SqlDataReader, T> convert)
        {
            List<T> listOfObjects = new List<T>();

            using (SqlConnection conn = Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T obj = convert(reader);
                            listOfObjects.Add(obj);
                        }
                    }
                }
            }
            return listOfObjects;
        }

    }
}
