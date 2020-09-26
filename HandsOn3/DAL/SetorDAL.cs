using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SetorDAL
    {
        public static DataTable GetSetoresTabela()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Setores";
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

        public static IEnumerable<Setor> GetSetores()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            List<Setor> setores = new List<Setor>();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Setores";
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        setores.Add(new Setor()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nome = row["Nome"].ToString()
                        });
                    }
                    return setores;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetSetorTabela(int id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Setores Where id=" + id;
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

        public static Setor GetSetor(int id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Setor setor = new Setor();
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Setores Where id=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, DAL.DbConnection());
                    da.Fill(dt);
                    setor.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    setor.Nome = dt.Rows[0]["Nome"].ToString();
                    return setor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(string setor)
        {
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Setores(Nome) values (@nome)";
                    cmd.Parameters.AddWithValue("@nome", setor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(int setorId, string nome)
        {
            try
            {
                using (var cmd = DAL.DbConnection().CreateCommand())
                {
                        cmd.CommandText = "UPDATE Setores SET Nome=@Nome WHERE id = @Id";
                        cmd.Parameters.AddWithValue("@Id", setorId);
                        cmd.Parameters.AddWithValue("@Nome", nome);
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
                    cmd.CommandText = "DELETE FROM Setores Where id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
