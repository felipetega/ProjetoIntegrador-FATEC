using Microsoft.Data.SqlClient;

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

    }
}
