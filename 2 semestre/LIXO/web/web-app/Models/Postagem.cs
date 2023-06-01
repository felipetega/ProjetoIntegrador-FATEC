namespace web_app.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string UrlImagem { get; set; }
        public string Descricao { get; set; }
        public int Curtidas { get; set; }

        public Postagem()
        {
            this.Id = 0;
            this.Usuario = string.Empty;
            this.UrlImagem = string.Empty;
            this.Descricao = string.Empty;
            this.Curtidas = 0;
        }
    }
}
