namespace web_app.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string urlImagem { get; set; }

        public Produto()
        {
            this.Id = 0;
            this.Nome = string.Empty;
            this.Descricao = string.Empty;
            this.Preco = 0;
            this.urlImagem = string.Empty;
        }
    }
}
