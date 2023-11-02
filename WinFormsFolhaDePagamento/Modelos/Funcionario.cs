using System;
using System.Data.SqlClient;

namespace WinFormsFolhaDePagamento.Modelos
{
    public class Funcionario : Pessoa
    {
        public int Matricula { get; set; }
        public double SalarioBase { get; set; }
        public double GratProd { get; set; }
        public int NumDep { get; set; }
        public string Cargo { get; set; }

        public string Save()
        {
            string sql = "INSERT INTO Funcionarios (Nome, Sexo, Idade, IdCidade, Matricula, SalarioBase, GratProd, NumDep, Cargo) " +
                         "VALUES (@Nome, @Sexo, @Idade, @IdCidade, @Matricula, @SalarioBase, @GratProd, @NumDep, @Cargo); " +
                         "SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@Idade", Idade);
                    cmd.Parameters.AddWithValue("@IdCidade", Cidade.Id);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);
                    cmd.Parameters.AddWithValue("@SalarioBase", SalarioBase);
                    cmd.Parameters.AddWithValue("@GratProd", GratProd);
                    cmd.Parameters.AddWithValue("@NumDep", NumDep);
                    cmd.Parameters.AddWithValue("@Cargo", Cargo);

                    Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return Id.ToString();
        }

        public bool Update()
        {
            string sql = "UPDATE Funcionarios SET Nome = @Nome, Sexo = @Sexo, Idade = @Idade, IdCidade = @IdCidade, " +
                         "Matricula = @Matricula, SalarioBase = @SalarioBase, GratProd = @GratProd, NumDep = @NumDep, Cargo = @Cargo " +
                         "WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@Idade", Idade);
                    cmd.Parameters.AddWithValue("@IdCidade", Cidade.Id);
                    cmd.Parameters.AddWithValue("@Matricula", Matricula);
                    cmd.Parameters.AddWithValue("@SalarioBase", SalarioBase);
                    cmd.Parameters.AddWithValue("@GratProd", GratProd);
                    cmd.Parameters.AddWithValue("@NumDep", NumDep);
                    cmd.Parameters.AddWithValue("@Cargo", Cargo);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Funcionarios WHERE Id = @Id";

            using (SqlConnection conn = Banco.Banco.Open())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
        }
    }
}
