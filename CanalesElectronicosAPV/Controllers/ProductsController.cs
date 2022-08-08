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
            List<SaldoTotal> listst = new List<SaldoTotal>();
            List<ReporteMovimientos> listrm = new List<ReporteMovimientos>();

            Models.DTO.ProductsDTO p = new Models.DTO.ProductsDTO();
            Models.DTO.Objetivos objetivo = new Models.DTO.Objetivos();
            CuentasBancarias cuentas = new CuentasBancarias();
            p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMICO";
            p.Estado = "ACTIVO";
            p.Saldo = "$00.00";
            list.Add(p);
            p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMICO";
            p.Estado = "ACTIVO";
            p.Saldo = "$00.00";
            list.Add(p);
            p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMICO";
            p.Estado = "ACTIVO";
            p.Saldo = "$00.00";
            list.Add(p);
            p = new Models.DTO.ProductsDTO();
            p.LineaProducto = "AHORRO PREVISIONAL VOLUNTARIO CRECER BALANCEADO";
            p.Producto = "1 PLAN INDIVIDUAL - DINÁMICO";
            p.Estado = "ACTIVO";
            p.Saldo = "$00.00";
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
                       NObjetivo= "LIBERTAD FINANCIERA ", 
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


            for (int i = 0; i < 5; i++)
                listst.Add(new SaldoTotal
                {
                    NumeroCuenta = String.Empty,
                    TipoAhorro = String.Empty,
                    NombreCuenta = String.Empty,
                    SaldoDolares = "00.00",
                    Unidades =   "00.00000000"
                });
            for (int i = 0; i < 6; i++)
            {
                listrm.Add(new ReporteMovimientos{

                    FechaMovimiento = "DD/MM/YY",
                    NombreObjetivos = "AHORRO",
                    TipoMovto = "ACREDITACIÓN",
                    ValorMovto = "$00.00",
                    ValorCuota = "00.00000000", 
                    Unidades =   "00.00000000"


                });


            }

            cuentas.EntidadFinanciera = "BANCO PROMERICA S.A";
            cuentas.TipoCuenta = "CORRIENTE";
            cuentas.Proposito = "PAGO";
            cuentas.NumeroCuenta = "XXXXXXXXXXXXX";
            cuentas.TipoIdentificacion = "DOCUMENTO ÚNICO DE IDENTIFICACIÓN";
            cuentas.NumeroIdentificacion = "XXXXXXXX";
            cuentas.CuentaPreferida = "NO";
            cuentas.EstadoCuenta = "ACTIVA";


            ViewBag.Distribucion = lstdst;
            ViewBag.Beneficiarios = lstbene;
            productosDTO.Distribucion = lstdst;
            productosDTO.Beneficiario = lstbene;

            productosDTO.SaldosTotales = listst;
            productosDTO.ReporteMovtos = listrm;
            productosDTO.cuentasbancarias = cuentas;

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
