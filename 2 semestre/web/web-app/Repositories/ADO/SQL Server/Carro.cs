using Microsoft.Data.SqlClient;
using web_app.Models;

namespace web_app.Repositories.ADO.SQL_Server
{
    public class Carro
    {
        public Carro() { }

        public void add(Models.Carro carro)
        {
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into carro(nome, cor, dataFabricacao, valor) values(@nome, @cor, @dataFabricacao,@valor)";
                    command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = carro.Nome;
                    command.Parameters.Add(new SqlParameter("@cor", System.Data.SqlDbType.VarChar)).Value = carro.Cor;
                    command.Parameters.Add(new SqlParameter("@dataFabricacao", System.Data.SqlDbType.Date)).Value = carro.DataFabricacao;
                    command.Parameters.Add(new SqlParameter("@valor", System.Data.SqlDbType.Decimal)).Value = carro.Valor;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Carro> get()
        {
            List<Models.Carro> carros = new List<Models.Carro>();
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, cor, dataFabricacao, valor from carro";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Carro carro= new Models.Carro();
                        carro.Id = (int)dr["id"];
                        carro.Nome = (string)dr["nome"];
                        carro.Cor = (string)dr["cor"];
                        carro.DataFabricacao = (DateTime)dr["dataFabricacao"];
                        carro.Valor = (decimal)dr["valor"];
                        carros.Add(carro);
                    }
                }
            }
            return carros;
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
                    command.CommandText = "delete from carro where id=@id";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
