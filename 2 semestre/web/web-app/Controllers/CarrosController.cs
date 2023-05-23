using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class CarrosController : Controller
    {
        private readonly Repositories.ADO.SQL_Server.Carro repository;
        public CarrosController()
        {
            repository = new Repositories.ADO.SQL_Server.Carro();
        }
        // GET: CarrosController
        public ActionResult Index()
        {
            return View(repository.get());
        }

        // GET: CarrosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                repository.add(carro);
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
            return View();
        }

        // POST: CarrosController/Edit/5
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

        // GET: CarrosController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: CarrosController/Delete/5
    }
}
