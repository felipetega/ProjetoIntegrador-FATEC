namespace web_app.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool IsAdm { get; set; }
        public Login()
        {
            this.Id = 0;
            this.Nome = string.Empty;
            this.Senha = string.Empty;
            this.IsAdm = false;
        }
    }
}
