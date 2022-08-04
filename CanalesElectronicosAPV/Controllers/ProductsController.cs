using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CanalesElectronicosAPV.Models.DTO;

namespace CanalesElectronicosAPV.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductosController
        public ActionResult Index()
        {
            ProductosDTO productosDTO = new ProductosDTO();
            List<ProductsDTO> list = new List<ProductsDTO>();
            Models.DTO.ProductsDTO p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMIC";
            p.Estado = "ACTIVO";
            p.Saldo = 0;
            list.Add(p);
            productosDTO.Productos = list;
            List<SelectListItem> items = new List<SelectListItem>();
            ViewBag.items = items;
            ViewBag.Distribucion = string.Empty;
            ViewBag.Beneficiarios = string.Empty;
            return View(productosDTO);
        }

        // GET: ProductosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductosController/Create
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

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductosController/Edit/5
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

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductosController/Delete/5
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
