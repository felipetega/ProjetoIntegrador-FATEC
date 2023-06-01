using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class PostagemController : Controller
    {
        private readonly Repositories.ADO.SQL_Server.Postagem repository;

        public PostagemController(IConfiguration configuration) // objeto configuration => parte do framework que permite ler o arquivo appsettings.json - GetConnectionString => método do framework que permite ler a chave ConnectionStrings deste arquivo.
        {
            this.repository = new Repositories.ADO.SQL_Server.Postagem(configuration.GetConnectionString(Configurations.Appsettings.getKeyConnectionString()));
            //Configurations.Appsettings.getKeyConnectionString => nossa classe de configuração para trazer a chave que deve ser lida, neste caso: DefaultConnection.
        }
        // GET: PostagemController
        public ActionResult Index()
        {
            return View(repository.get());
        }

        // GET: PostagemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostagemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostagemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Postagem postagem)
        {
            try
            {
                repository.add(postagem);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostagemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostagemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostagemController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: PostagemController/Delete/5
    }
}
