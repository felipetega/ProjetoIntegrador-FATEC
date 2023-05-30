using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class LoginController : Controller
    {
        private readonly Repositories.ADO.SQL_Server.Login repository;
        public LoginController()
        {
            repository = new Repositories.ADO.SQL_Server.Login();
        }
        // GET: LoginController
        public ActionResult Index()
        {
            return View(repository.get());
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                repository.add(login);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: LoginController/Delete/5
    }
}
