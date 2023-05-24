using Microsoft.Data.SqlClient;
using web_app.Models;

namespace web_app.Repositories.ADO.SQL_Server
{
    public class Produto
    {
        public Produto() { }

        public void add(Models.Produto produto)
        {
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Produto(nome, descricao, preco, urlImagem) values(@nome, @descricao, @preco, @urlImagem)";
                    command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = produto.Nome;
                    command.Parameters.Add(new SqlParameter("@descricao", System.Data.SqlDbType.VarChar)).Value = produto.Descricao;
                    command.Parameters.Add(new SqlParameter("@preco", System.Data.SqlDbType.Decimal)).Value = produto.Preco;
                    command.Parameters.Add(new SqlParameter("@urlImagem", System.Data.SqlDbType.VarChar)).Value = produto.urlImagem;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Produto> get()
        {
            List<Models.Produto> produtos = new List<Models.Produto>();
            string connectionString = Configuration.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, descricao, preco, urlImagem from produto";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Produto produto = new Models.Produto();
                        produto.Id = (int)dr["id"];
                        produto.Nome = (string)dr["nome"];
                        produto.Descricao = (string)dr["descricao"];
                        produto.Preco = (decimal)dr["preco"];
                        produto.urlImagem = (string)dr["urlImagem"];
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
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
                    command.CommandText = "delete from produto where id=@id";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void edit(Models.Produto produto)
        {
            {
                string connectionString = Configuration.getConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into Produto(nome, descricao, preco, urlImagem) values(@nome, @descricao, @preco, @urlImagem)";
                        command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = produto.Nome;
                        command.Parameters.Add(new SqlParameter("@descricao", System.Data.SqlDbType.VarChar)).Value = produto.Descricao;
                        command.Parameters.Add(new SqlParameter("@preco", System.Data.SqlDbType.Decimal)).Value = produto.Preco;
                        command.Parameters.Add(new SqlParameter("@urlImagem", System.Data.SqlDbType.VarChar)).Value = produto.urlImagem;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
