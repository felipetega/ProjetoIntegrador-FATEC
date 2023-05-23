using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly Repositories.ADO.SQL_Server.Produto repository;
        public ProdutoController()
        {
            repository = new Repositories.ADO.SQL_Server.Produto();
        }
        // GET: ProdutoController
        public ActionResult Index()
        {
            return View(repository.get());
        }

        // GET: ProdutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Produto produto, IFormFile imagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (imagem != null && imagem.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            imagem.CopyTo(memoryStream);
                            produto.Imagem = memoryStream.ToArray();
                        }
                    }

                    repository.add(produto);
                    return RedirectToAction(nameof(Index));
                }

                return View(produto);
            }
            catch
            {
                return View();
            }
        }


        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoController/Edit/5
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

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: ProdutoController/Delete/5
    }
}
