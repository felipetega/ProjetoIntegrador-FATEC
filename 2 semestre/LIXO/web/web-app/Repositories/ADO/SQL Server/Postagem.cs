using Microsoft.Data.SqlClient;
using web_app.Models;

namespace web_app.Repositories.ADO.SQL_Server
{
    public class Postagem
    {
        private readonly string connectionString; //Declarado para toda a classe. Possível alterar somente no construtor.
        public Postagem(string connectionString) //Quem invocar o construtor do repositório deve enviar a string de conexão.
        {
            this.connectionString = connectionString; //atualização do atributo por meio do valor que veio no parâmetro do construtor..
        }

        public void add(Models.Postagem postagem)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into postagem(usuario, descricao, urlImagem, curtidas) values(@usuario, @descricao, @urlImagem ,@curtidas)";
                    command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = postagem.Usuario;
                    command.Parameters.Add(new SqlParameter("@descricao", System.Data.SqlDbType.VarChar)).Value = postagem.Descricao;
                    command.Parameters.Add(new SqlParameter("@urlImagem", System.Data.SqlDbType.VarChar)).Value = postagem.UrlImagem;
                    command.Parameters.Add(new SqlParameter("@curtidas", System.Data.SqlDbType.Int)).Value = postagem.Curtidas;
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Models.Postagem> get()
        {
            List<Models.Postagem> postagens = new List<Models.Postagem>();
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, usuario, descricao, urlImagem, curtidas from postagem";
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Postagem postagem = new Models.Postagem();
                        postagem.Id = (int)dr["id"];
                        postagem.Usuario = (string)dr["usuario"];
                        postagem.Descricao = (string)dr["descricao"];
                        postagem.UrlImagem = (string)dr["urlImagem"];
                        postagem.Curtidas = (int)dr["curtidas"];
                        postagens.Add(postagem);
                    }
                }
            }
            return postagens;
        }

        public void delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from postagem where id=@id";
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public void edit(Models.Postagem postagem)
        {
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into postagem(usuario, descricao, curtidas, urlImagem) values(@usuario, @descricao, @curtidas, @urlImagem)";
                        command.Parameters.Add(new SqlParameter("@usuario", System.Data.SqlDbType.VarChar)).Value = postagem.Usuario;
                        command.Parameters.Add(new SqlParameter("@descricao", System.Data.SqlDbType.VarChar)).Value = postagem.Descricao;
                        command.Parameters.Add(new SqlParameter("@curtidas", System.Data.SqlDbType.Int)).Value = postagem.Curtidas;
                        command.Parameters.Add(new SqlParameter("@urlImagem", System.Data.SqlDbType.VarChar)).Value = postagem.UrlImagem;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
