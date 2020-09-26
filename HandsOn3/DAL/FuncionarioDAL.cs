using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FuncionarioDAL
    {
        public static DataTable GetFuncionariosTabela()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Funcionarios";
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetFuncionarioTabela(int id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Funcionarios Where id=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Funcionario GetSetor(int id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Funcionario funcionario = new Funcionario();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Funcionarios Where id=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);
                    funcionario.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    funcionario.Nome = dt.Rows[0]["Nome"].ToString();
                    return funcionario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(string funcionario, string setor)
        {
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Funcionarios (Nome, Setor_Id) values (@nome, (SELECT id FROM Setores WHERE nome = '{setor}'))";
                    cmd.Parameters.AddWithValue("@nome", funcionario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(int funcionarioId, string nome, string setor)
        {
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE Funcionarios SET Nome=@Nome, Setor_id=@Setor WHERE id = @Id";
                    cmd.Parameters.AddWithValue("@Id", funcionarioId);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Setor", GetSetorIdByName(setor));
                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Funcionarios Where id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetSetorIdByName(string nomeSetor)
        {
            try
            {
                SqlDataAdapter da = null;
                DataTable dt = new DataTable();
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT id FROM Setores Where nome='{nomeSetor}'";
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);
                    return Convert.ToInt32(dt.Rows[0]["id"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
