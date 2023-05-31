using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using web_app.Models;

namespace web_app.Repositories.ADO.SQLServer
{
    public class Carro
    {
        private readonly string connectionString; //Declarado para toda a classe. Possível alterar somente no construtor.
        public Carro(string connectionString) //Quem invocar o construtor do repositório deve enviar a string de conexão.
        {
            this.connectionString = connectionString; //atualização do atributo por meio do valor que veio no parâmetro do construtor..
        }

        public void add(Models.Carro carro) 
        {            
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into carro (nome, cor, dataFabricacao, valor) values (@nome,@cor,@datafabricacao,@valor); select convert(int,@@identity) as id;;";
                    
                    command.Parameters.Add(new SqlParameter ("@nome", System.Data.SqlDbType.VarChar)).Value = carro.Nome;
                    command.Parameters.Add(new SqlParameter("@cor", System.Data.SqlDbType.VarChar)).Value = carro.Cor;
                    command.Parameters.Add(new SqlParameter("@datafabricacao", System.Data.SqlDbType.Date)).Value = carro.DataFabricacao;
                    command.Parameters.Add(new SqlParameter("@valor", System.Data.SqlDbType.Decimal)).Value = carro.Valor;
                                        
                    carro.Id = (int) command.ExecuteScalar(); // o homem do saco leva os dados até o sgbd e volta com o valor do id => ExecuteScalar retorna um único valor. Observe que o CommandText foi alterado com mais uma instrução. Então, as duas instruções são executadas e temos como retorno o valor do id que foi gerado pelo sgbd na tabela carro. Assim, conseguimos atualizar o valor do id do objeto carro que antes da inserção era 0.
                }
            }            
        }

        public List<Models.Carro> get()
        {
            List<Models.Carro> carros = new List<Models.Carro>();
                        
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, cor, dataFabricacao, valor from carro;";
                   
                    SqlDataReader dr =  command.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        Models.Carro carro = new Models.Carro();
                        carro.Id = (int)dr["id"];
                        carro.Nome = dr["nome"].ToString();
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
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from carro where id = @id;";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }

        public Models.Carro getById(int id) //somente 1 carro.
        {
            Models.Carro carro = new Models.Carro();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, cor, dataFabricacao, valor from carro where id=@id;";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        carro.Id = (int)dr["id"];
                        carro.Nome = dr["nome"].ToString();
                        carro.Cor = (string)dr["cor"];
                        carro.DataFabricacao = (DateTime)dr["dataFabricacao"];
                        carro.Valor = (decimal)dr["valor"];
                    }
                }
            }

            return carro;
        }

        public void update(int id, Models.Carro carro)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update carro set nome = @nome, cor = @cor, dataFabricacao = @dataFabricacao, valor = @valor where id=@id;";

                    command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = carro.Nome;
                    command.Parameters.Add(new SqlParameter("@cor", System.Data.SqlDbType.VarChar)).Value = carro.Cor;
                    command.Parameters.Add(new SqlParameter("@datafabricacao", System.Data.SqlDbType.Date)).Value = carro.DataFabricacao;
                    command.Parameters.Add(new SqlParameter("@valor", System.Data.SqlDbType.Decimal)).Value = carro.Valor;
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
