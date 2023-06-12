using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using web_app.Models;

namespace web_app.Repositories.ADO.SQLServer
{
    public class Login
    {
        private readonly string connectionString;
        public Login(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool check(Models.Login login)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id from login where usuario=@usuario and senha=@senha";
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = login.Usuario;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = login.Senha;

                    SqlDataReader dr = command.ExecuteReader();
                    result = dr.Read();
                }
            }

            return result;
        }

        public Models.Login pegarId(Models.Login loginR)
        {
            Models.Login login = new Models.Login();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id from login where usuario=@usuario and senha=@senha";
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = loginR.Usuario;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = loginR.Senha;

                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        login.Id = (int)dr["id"];
                    }
                }
            }

            return login;
        }

        public void add(Models.Login login)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into login(usuario, senha) values(@usuario, @senha)";
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = login.Usuario;
                    command.Parameters.Add(new SqlParameter("@senha", System.Data.SqlDbType.VarChar)).Value = login.Senha;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
