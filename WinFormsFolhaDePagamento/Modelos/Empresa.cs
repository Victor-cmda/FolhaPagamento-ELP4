using System;
using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos
{
    public class Empresa : BaseEntity
    {
        public string RazaoSocial;
        public string Cnpj;
        public int NumFuncionarios;

        public string Save()
        {
            string ok;
            string sql = "INSERT INTO Empresas (RazaoSocial, Cnpj, NumFuncionarios) VALUES(@RazaoSocial, @Cnpj, @NumFuncionarios)";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RazaoSocial", this.RazaoSocial);
                    cmd.Parameters.AddWithValue("@Cnpj", this.Cnpj);
                    cmd.Parameters.AddWithValue("@NumFuncionarios", this.NumFuncionarios);

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
            string sql = "UPDATE Empresas SET RazaoSocial = @RazaoSocial, Cnpj = @Cnpj, NumFuncionarios = @NumFuncionarios WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@RazaoSocial", this.RazaoSocial);
                    cmd.Parameters.AddWithValue("@Cnpj", this.Cnpj);
                    cmd.Parameters.AddWithValue("@NumFuncionarios", this.NumFuncionarios);
                    cmd.Parameters.AddWithValue("@Id", this.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Empresas WHERE Id = @Id";

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
