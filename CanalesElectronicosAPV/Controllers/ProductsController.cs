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
            CustumerDataDTO dto= new CustumerDataDTO(); 
            ProductosDTO productosDTO = new ProductosDTO();
            List<ProductsDTO> list = new List<ProductsDTO>();
            Models.DTO.ProductsDTO p = new Models.DTO.ProductsDTO();
            Models.DTO.Objetivos objetivo = new Models.DTO.Objetivos();
            p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMIC";
            p.Estado = "ACTIVO";
            p.Saldo = 0;
            list.Add(p);


            objetivo.NombreO = "LIBERTAD FINANCIERA";
            objetivo.Tipo = "INVERSIÓN";
            objetivo.FechaMeta = "08/2026";
            objetivo.ValorMeta = "$25,000.00";
            objetivo.Saldo = "$1,023.63";
            objetivo.NombreJubilacion = "JUBILACIÓN ANTICIPADA";
            objetivo.TipoJUbilacion = "PENSIÓN";
            objetivo.FMJubilacion = "08/2026";
            objetivo.VMJubilacion = "$50,000.00";
            objetivo.STJubilacion = "$1,023.63";
            objetivo.NombreO = "LIBERTAD FINANCIERA";
            objetivo.Tipo = "INVERSIÓN";
            objetivo.FechaMeta = "08/2026";
            objetivo.ValorMeta = "$25,000.00";
            objetivo.Saldo = "$1,023.63";
            objetivo.NombreJubilacion = "JUBILACIÓN ANTICIPADA";
            objetivo.TipoJUbilacion = "PENSIÓN";
            objetivo.FMJubilacion = "08/2026";
            objetivo.VMJubilacion = "$50,000.00";
            objetivo.STJubilacion = "$1,023.63";
            productosDTO.objetivo = objetivo;
            productosDTO.Productos = list;
            List<SelectListItem> items = new List<SelectListItem>();
            ViewBag.items = items;
            ViewBag.Distribucion = string.Empty;
            ViewBag.Beneficiarios = string.Empty;

        
            
        //    list(objetivo);
            List<Models.DTO.Distribucion> lstdst = new();
            List<Models.DTO.Beneficiarios> lstbene = new();
            lstdst.Add(new Distribucion
                   {
                       NObjetivo= "LIBERTAD FINANCIERA", 
                       Consignacion = "50%", 
                      Deduccion  = "50%",
                     Debito = "%"
    });
                 lstdst.Add(new Distribucion
                   {
                       NObjetivo = "JUBILACIÓN ANTICIPADA",
                       Consignacion = "50%",
                       Deduccion = "50%",
                       Debito = "%"

                   });
                   lstdst.Add(new Distribucion
                   {
                       NObjetivo = "LIBERTAD FINANCIERA",
                       Consignacion = "50%",
                       Deduccion = "50%",
                       Debito = "%"

                   });
            lstdst.Add(new Distribucion
            {
                NObjetivo = "JUBILACIÓN ANTICIPADA",
                Consignacion = "50%",
                Deduccion = "50%",
                Debito = "%"

            });
            lstbene.Add(new Beneficiarios
                      {
                       NombreB = "OBEDISA QUIJADA DURAN",
                       Parentesco = "XXXX",
                       FechaNacimiento = "XX/XX/XXXX",
                       Sexo = "XXX",
                       Porcentaje = "%"

                  });
            lstbene.Add(new Beneficiarios
            {
                NombreB = "OBEDISA QUIJADA DURAN",
                Parentesco = "XXXX",
                FechaNacimiento = "XX/XX/XXXX",
                Sexo = "XXX",
                Porcentaje = "%"

            });
            lstbene.Add(new Beneficiarios
            {
                NombreB = "OBEDISA QUIJADA DURAN",
                Parentesco = "XXXX",
                FechaNacimiento = "XX/XX/XXXX",
                Sexo = "XXX",
                Porcentaje = "%"

            });
            lstbene.Add(new Beneficiarios
            {
                NombreB = "OBEDISA QUIJADA DURAN",
                Parentesco = "XXXX",
                FechaNacimiento = "XX/XX/XXXX",
                Sexo = "XXX",
                Porcentaje = "%"

            });
            lstbene.Add(new Beneficiarios
            {
                NombreB = "OBEDISA QUIJADA DURAN",
                Parentesco = "XXXX",
                FechaNacimiento = "XX/XX/XXXX",
                Sexo = "XXX",
                Porcentaje = "%"

            });



            ViewBag.Distribucion = lstdst;
            ViewBag.Beneficiarios = lstbene;
            productosDTO.Distribucion = lstdst;
            productosDTO.Beneficiario = lstbene; 
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
