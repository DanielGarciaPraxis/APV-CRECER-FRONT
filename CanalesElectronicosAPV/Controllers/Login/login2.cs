using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers.Login
{
    public class login2 : Controller
    {
        // GET: login2
        public ActionResult Index()
        {
            return View();
        }

        // GET: login2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: login2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: login2/Create
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

        // GET: login2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: login2/Edit/5
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

        // GET: login2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: login2/Delete/5
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
