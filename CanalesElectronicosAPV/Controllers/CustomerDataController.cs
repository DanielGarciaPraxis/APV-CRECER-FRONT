using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers
{


    public class CustomerDataController : Controller
    {
        private readonly IClienteUseCase _cliente;
        private string NumeroIdentificacion;
        public CustomerDataController(IClienteUseCase cliente)
        {
            _cliente = cliente;
            NumeroIdentificacion = "";
        }
        //public IActionResult Index(AfiliadoRequest data)
        //{
        //    ViewBag.NumeroDocumento = data.NumeroDocumento;
        //    return View();

        //}

        public IActionResult Index()
        {
            try
            {
                if(TempData["Afiliado"] == null)
                {
                    return RedirectToAction("VwLogin", "Login");
                }

                NumeroIdentificacion = TempData["Afiliado"]?.ToString();
                var info = TempData["LoginInfo"]?.ToString();
                
                DatosClienteRequest datosClienteRequest = new()
                {
                    CodigoProducto = TempData["CodigoProducto"].ToString(),
                    CodigoTipoIdentificacion = TempData["CodigoTipoIdentificacion"].ToString(),                
                    NumeroIdentificacion = TempData["NumeroIdentificacion"].ToString(),//"000349331",
                    IdPersona = TempData["IdPersona"].ToString(),
                    FechaInicio = TempData["FechaInicio"].ToString(),
                    FechaFin = TempData["FechaFin"].ToString(),
                    //Header = new()
                    //{
                    //    Usuario = "gmoreno",
                    //    Ip = "192.168.0.2",
                    //    Canal = "web"
                    //}
                };

                var response = _cliente.ConsultarDatos(datosClienteRequest).GetAwaiter().GetResult();
                if (response.Status.HttpCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    ViewBag.Error = "Error";
                    throw new Exception(response.Status.Message);
                }
                return View(response.Item);
            }
            catch (Exception er)
            {
                return BadRequest(er);
            }
        }
    }

}
