using System;
using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos
{
    public class Estado : BaseEntity
    {
        public string Nome;
        public string UF;
        public Pais Pais;

        public string Save()
        {
            string ok;
            string sql = "INSERT INTO Estado (Nome, UF, IdPais) VALUES(@Nome, @UF, @IdPais)";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@UF", this.UF);
                    cmd.Parameters.AddWithValue("@IdPais", this.Pais.Id);

                    cmd.ExecuteNonQuery();

                    sql = "SELECT @@IDENTITY";
                    cmd.CommandText = sql;
                    ok = cmd.ExecuteScalar().ToString();

                    this.Id = int.Parse(ok);
                }
            }

            return ok;
        }

        public bool Update()
        {
            string sql = "UPDATE Estado SET Nome = @Nome, UF = @UF, IdPais = @IdPais WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@UF", this.UF);
                    cmd.Parameters.AddWithValue("@IdPais", this.Pais.Id);
                    cmd.Parameters.AddWithValue("@Id", this.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Estado WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", this.Id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }
    }
}
