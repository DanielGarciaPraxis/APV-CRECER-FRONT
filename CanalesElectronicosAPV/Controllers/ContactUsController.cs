using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CanalesElectronicosAPV.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            ViewBag.TpoConsulta = items;
            return View();
        }
    }
}
