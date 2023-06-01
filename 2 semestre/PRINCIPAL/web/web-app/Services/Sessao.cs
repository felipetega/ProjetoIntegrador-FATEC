using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace web_app.Services
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly string chaveSessao;
        public Sessao(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.chaveSessao = "login";
        }

        public void add(Models.Login login)
        {
            string loginJSon = JsonConvert.SerializeObject(login);
            this.httpContextAccessor.HttpContext?.Session.SetString(this.chaveSessao, loginJSon);
        }

        public Models.Login get()
        {
            string? loginJson = this.httpContextAccessor.HttpContext?.Session.GetString(this.chaveSessao);
            return loginJson != null ? JsonConvert.DeserializeObject<Models.Login>(loginJson) : null;
        }

        public void delete()
        {
            this.httpContextAccessor.HttpContext?.Session.Remove(this.chaveSessao);
        }

    }
}