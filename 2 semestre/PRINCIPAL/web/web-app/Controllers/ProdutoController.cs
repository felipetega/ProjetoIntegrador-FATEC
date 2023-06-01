using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_app.Filters;

namespace web_app.Controllers
{
    [UsuarioLogado]
    public class ProdutoController : Controller
    {
        private readonly Repositories.ADO.SQL_Server.Produto repository;

        public ProdutoController(IConfiguration configuration) // objeto configuration => parte do framework que permite ler o arquivo appsettings.json - GetConnectionString => método do framework que permite ler a chave ConnectionStrings deste arquivo.
        {
            this.repository = new Repositories.ADO.SQL_Server.Produto(configuration.GetConnectionString(Configurations.Appsettings.getKeyConnectionString()));//configuration.GetConnectionString(Configurations.Appsettings.getKeyConnectionString()));
            //Configurations.Appsettings.getKeyConnectionString => nossa classe de configuração para trazer a chave que deve ser lida, neste caso: DefaultConnection.
        }

        // GET: ProdutoController
        [HttpGet]
        public ActionResult Index()
        {
            return View(this.repository.get());
        }

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Produto produto)
        {
            try
            {
                this.repository.add(produto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.repository.getById(id));
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.Produto produto)
        {
            try
            {
                this.repository.update(id, produto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            this.repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
