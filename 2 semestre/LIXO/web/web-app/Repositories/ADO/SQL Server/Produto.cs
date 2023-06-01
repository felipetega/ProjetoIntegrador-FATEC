using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using web_app.Models;
using web_app.Repositories.ADO.SQLServer;

namespace web_app.Repositories.ADO.SQL_Server
{
    public class Produto
    {
        private readonly string connectionString; //Declarado para toda a classe. Possível alterar somente no construtor.
        public Produto(string connectionString) //Quem invocar o construtor do repositório deve enviar a string de conexão.
        {
            this.connectionString = connectionString; //atualização do atributo por meio do valor que veio no parâmetro do construtor..
        }

        public void add(Models.Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
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
                    produto.Id = (int)command.ExecuteScalar();
                }
            }
        }

        public List<Models.Produto> get()
        {
            List<Models.Produto> produtos = new List<Models.Produto>();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
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
            using (SqlConnection connection = new SqlConnection(this.connectionString))
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
                using (SqlConnection connection = new SqlConnection(this.connectionString))
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
        public Models.Produto getById(int id) //somente 1 carro.
        {
            Models.Produto produto = new Models.Produto();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, nome, descricao, preco, urlImagem from produto where id=@id;";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    SqlDataReader dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        produto.Id = (int)dr["id"];
                        produto.Nome = (string)dr["nome"];
                        produto.Descricao = (string)dr["descricao"];
                        produto.Preco = (decimal)dr["preco"];
                        produto.urlImagem = (string)dr["urlImagem"];
                    }
                }
            }

            return produto;
        }
        public void update(int id, Models.Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update produto set nome = @nome, descricao = @descricao, preco = @preco, urlImagem = @urlImagem where id=@id;";

                    command.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = produto.Nome;
                    command.Parameters.Add(new SqlParameter("@descricao", System.Data.SqlDbType.VarChar)).Value = produto.Descricao;
                    command.Parameters.Add(new SqlParameter("@preco", System.Data.SqlDbType.Decimal)).Value = produto.Preco;
                    command.Parameters.Add(new SqlParameter("@urlImagem", System.Data.SqlDbType.VarChar)).Value = produto.urlImagem;
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
