namespace web_app.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        //public bool IsAdm { get; set; }

        public Login()
        {
            this.Id = 0;
            this.Usuario = string.Empty;
            this.Senha = string.Empty;
            //this.IsAdm = false;
        }
    }
}

