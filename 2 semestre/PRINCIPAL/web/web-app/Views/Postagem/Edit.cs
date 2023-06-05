using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Views.Postagem
{
    public class Edit : Controller
    {
        // GET: Edit
        public ActionResult Index()
        {
            return View();
        }

        // GET: Edit/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Edit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Edit/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Edit/Edit/5
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

        // GET: Edit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Edit/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
