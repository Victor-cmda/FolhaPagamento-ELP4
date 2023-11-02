using System;
using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos
{
    public class Cidade : BaseEntity
    {
        public string Nome;
        public string DDD;
        public Estado Estado;

        public string Save()
        {
            string ok;
            string sql = "INSERT INTO Cidades (Nome, DDD, IdEstado) VALUES(@Nome, @DDD, @IdEstado)";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@DDD", this.DDD);
                    cmd.Parameters.AddWithValue("@IdEstado", this.Estado.Id);

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
            string sql = "UPDATE Cidades SET Nome = @Nome, DDD = @DDD, IdEstado = @IdEstado WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@DDD", this.DDD);
                    cmd.Parameters.AddWithValue("@IdEstado", this.Estado.Id);
                    cmd.Parameters.AddWithValue("@Id", this.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Cidades WHERE Id = @Id";

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
