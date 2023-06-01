namespace web_app.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public DateTime DataFabricacao { get; set; }
        public decimal Valor { get; set; }

        public Carro()
        {
            this.Id = 0;
            this.Nome = string.Empty;
            this.Cor = string.Empty;
            this.DataFabricacao = DateTime.Now;
            this.Valor = 0;
        }
    }
}
