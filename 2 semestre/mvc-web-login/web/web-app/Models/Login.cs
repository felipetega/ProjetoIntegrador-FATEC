namespace web_app.Models
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Login()
        {
            this.Usuario = string.Empty;
            this.Senha = string.Empty;
        }
    }
}

