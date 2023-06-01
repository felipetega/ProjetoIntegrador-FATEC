using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_app.Filters;

namespace web_app.Controllers
{
    [UsuarioLogado]
    public class CarrosController : Controller
    {
        private readonly Repositories.ADO.SQLServer.Carro repository;
        
        public CarrosController(IConfiguration configuration) // objeto configuration => parte do framework que permite ler o arquivo appsettings.json - GetConnectionString => método do framework que permite ler a chave ConnectionStrings deste arquivo.
        {            
            this.repository = new Repositories.ADO.SQLServer.Carro(configuration.GetConnectionString(Configurations.Appsettings.getKeyConnectionString()));
            //Configurations.Appsettings.getKeyConnectionString => nossa classe de configuração para trazer a chave que deve ser lida, neste caso: DefaultConnection.
        }

        // GET: CarrosController
        [HttpGet]
        public ActionResult Index()
        {            
            return View(this.repository.get());
        }
       
        // GET: CarrosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarrosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Carro carro)
        {
            try
            {
                this.repository.add(carro);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarrosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(this.repository.getById(id));
        }

        // POST: CarrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.Carro carro)
        {
            try
            {
                this.repository.update(id, carro);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarrosController/Delete/5
        public ActionResult Delete(int id)
        {
            this.repository.delete(id);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
