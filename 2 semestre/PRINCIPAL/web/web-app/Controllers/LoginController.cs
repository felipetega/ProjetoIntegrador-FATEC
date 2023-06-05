using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_app.Services;

namespace web_app.Controllers
{
    public class LoginController : Controller
    {
        private readonly Repositories.ADO.SQLServer.Login repository;
        private readonly Services.ISessao sessao;

        public LoginController(IConfiguration configuration,                                    Services.ISessao sessao)
        {
            this.repository = new Repositories.ADO.SQLServer.Login(configuration.GetConnectionString(Configurations.Appsettings.getKeyConnectionString()));
            this.sessao = sessao;
        }
            
        public ActionResult Login()
        {
            return this.sessao.get() == null ? View() : RedirectToAction("Index", "Postagem");
        }

        [HttpPost]
        public ActionResult Login(Models.Login login)
        {
            if (this.repository.check(login))
            {
                this.sessao.add(login);
                return RedirectToAction("Index", "Postagem");
            }
            
            return View();
        }

        public ActionResult Logout()
        {
            this.sessao.delete();
            return RedirectToAction("Login", "Login");
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Login login)
        {
            try
            {
                this.repository.add(login);

                return RedirectToAction("Login", "Login");
            }
            catch
            {
                return View();
            }
        }
    }
}
