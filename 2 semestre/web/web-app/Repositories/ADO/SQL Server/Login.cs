using Microsoft.Data.SqlClient;
using web_app.Models;

namespace web_app.Repositories.ADO.SQL_Server
{
    public class Login
    {
        public Login() { }

        public void add(Models.Login login)
        {
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into tb_login(nome, senha, isAdm) values(@nome, @senha, @isAdm)";
                    command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = login.Nome;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = login.Senha;
                    command.Parameters.Add(new SqlParameter("@isAdm", System.Data.SqlDbType.Bit)).Value = login.IsAdm;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Login> get()
        {
            List<Models.Login> logins = new List<Models.Login>();
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, senha, isAdm from tb_login";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Login login = new Models.Login();
                        login.Id = (int)dr["id"];
                        login.Nome = (string)dr["nome"];
                        login.Senha = (string)dr["senha"];
                        login.IsAdm = (bool)dr["isAdm"];
                        logins.Add(login);
                    }
                }
            }
            return logins;
        }

        public void delete(int id)
        {
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from tb_login where id=@id";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void edit(Models.Login login)
        {
            {
                string connectionString = Configuration.getConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into tb_login(nome, senha, isAdm) values(@nome, @senha, @isAdm)";
                        command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = login.Nome;
                        command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = login.Senha;
                        command.Parameters.Add(new SqlParameter("@isAdm", System.Data.SqlDbType.Bit)).Value = login.IsAdm;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
