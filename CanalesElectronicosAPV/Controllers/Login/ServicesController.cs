using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CanalesElectronicosAPV.Models.DTO;

namespace CanalesElectronicosAPV.Controllers.Login
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            ServicesDTO services = new ServicesDTO();
            services.Nombre = "Juan Jose Franco Hernandez";
            services.CodigoCliente = "0791 1000 2494";
            services.NPE = "0791 1000 2494 45";
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem() { Text="Estado de Cuenta",Value="1"});
            lst.Add(new SelectListItem() { Text = "Extracto de Saldo", Value = "2" });
            lst.Add(new SelectListItem() { Text = "Carné", Value = "3" });
            ViewBag.TipoServicio = lst;
            return View(services);
        }
    }
}
