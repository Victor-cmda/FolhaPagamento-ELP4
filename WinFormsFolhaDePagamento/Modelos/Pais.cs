using System;
using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos
{
    public class Pais : BaseEntity
    {
        public string Nome;
        public string Sigla;
        public string Moeda;

        public string Save()
        {
            string ok;
            string sql;

            sql = "INSERT Pais VALUES('" + this.Nome + "', '" + this.Sigla + "', '" + this.Moeda + "')";
            SqlCommand conn = new SqlCommand();
            conn.Connection = Banco.Banco.Open();
            conn.CommandText = sql;
            conn.ExecuteNonQuery();

            sql = "select @@identity";
            conn.CommandText = sql;
            conn.ExecuteNonQuery();
            ok = conn.ExecuteScalar().ToString();

            this.Id = int.Parse(ok);
            conn.Connection.Close();
            return ok;
        }

        public bool Update()
        {
            string sql = "UPDATE Pais SET Nome = @Nome, Sigla = @Sigla, Moeda = @Moeda WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@Sigla", this.Sigla);
                    cmd.Parameters.AddWithValue("@Moeda", this.Moeda);
                    cmd.Parameters.AddWithValue("@Id", this.Id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    conn.Close();

                    return rowsAffected == 1;
                }
            }
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Pais WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", this.Id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    conn.Close();

                    return rowsAffected == 1;
                }
            }
        }


    }


}
