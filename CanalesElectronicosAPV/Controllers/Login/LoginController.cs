using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers.Login
{
    public class LoginController : Controller
    {
        private readonly IClienteUseCase _cliente;
        private string NumeroIdentificacion;
        public LoginController(IClienteUseCase cliente)
        {
            _cliente = cliente;
            NumeroIdentificacion = "";
        }

        public IActionResult VwLogin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([FromForm]AfiliadoRequest data)
        {
            try
            {
                if (string.IsNullOrEmpty(data.NumeroDocumento))
                {
                    return View("VwLogin");
                }
                TempData["Afiliado"]=data.NumeroDocumento;
                data.TipoDocumento = "DUI";
                var response = _cliente.InformacionUsuario(data).GetAwaiter().GetResult();
                //if (response.Status == null || response.Status.HttpCode != System.Net.HttpStatusCode.OK)
                //{
                //    ViewBag.Error = "Ocurrio un Error";
                //    return View();
                //}
                string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd");
                TempData["CodigoProducto"] = response.Item==null?"": response.Item.IdProducto;
                TempData["CodigoTipoIdentificacion"] = "DUI";
                TempData["NumeroIdentificacion"] = data.NumeroDocumento == null ? "" : data.NumeroDocumento;
                TempData["IdPersona"] = response.Item == null ? "" : response.Item.IdCliente;
                TempData["FechaInicio"] = fechaHoy;
                TempData["FechaFin"] = fechaHoy;
                //throw (new Exception());
                return RedirectToAction("index", "CustomerData");
                //("~/Views/CustomerData/index.cshtml", data);
            }
            catch
            {
                return View("VwLogin");
            }
        }

    }
}
