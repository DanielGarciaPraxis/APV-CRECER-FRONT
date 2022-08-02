using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using ClientesApv.Core.Dto_s.Common;
using ClientesApv.Core.Dto_s.Request;
using ClientesApv.Core.Dto_s.Response;
using ClientesApv.Core.UseCases.Interfaces;
using Log4Net_Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;




namespace ClientesApv.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosExpressController : ControllerBase
    {
        private readonly IServicioExpressUseCase _extracto;
        private readonly IAfiliadoUseCase _afiliado;
        private readonly IBitacoraApvUseCase _bitacora;
        private readonly BitacoraConfig _bitacoraParameters;
        private readonly IMapper _map;
        public ServiciosExpressController(IServicioExpressUseCase _extractoUseCase, IAfiliadoUseCase _afiliadoUseCase, IBitacoraApvUseCase _bitacoraUseCase, IOptions<BitacoraConfig> bitacoraParameters, IMapper map)
        
        {
            _extracto = _extractoUseCase ?? throw new ArgumentNullException(nameof(_extractoUseCase));
            _afiliado = _afiliadoUseCase ?? throw new ArgumentNullException(nameof(_afiliadoUseCase));
            _bitacora = _bitacoraUseCase ?? throw new ArgumentNullException(nameof(_bitacoraUseCase));
            _bitacoraParameters = bitacoraParameters.Value;
            _map = map;
            Log.SetUp(Assembly.GetEntryAssembly(), "Log4Net.config");
        }

        [HttpPost]
        [Route("~/api/ServiciosExpress")]
        [Authorize(policy: "gestionar-afiliados-apv-web")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseServiciosExpress))]
        [ProducesErrorResponseType(typeof(ResponseServiciosExpress))]
        public async Task<IActionResult> ConsultarServiciosExpress([FromBody] DatosBasicosRequest datosBasicoExpressRequest)
        {
            ResponseStatus response = new ResponseStatus();
            ResponseServiciosExpress servicio = new ResponseServiciosExpress();

            List<string> listaServiciosBitacora = new List<string>();

            var buscarAfiliado = _map.Map<AfiliadoRequest>(datosBasicoExpressRequest);

            var afiliado = await _afiliado.verificarCliente(buscarAfiliado);
            var bitacoraRequest = _map.Map<BitacoraApvRequest>(afiliado.Item);
            if (afiliado.Status.HttpCode == System.Net.HttpStatusCode.InternalServerError)
            {
                servicio.ClienteApv = afiliado.Status;
                servicio.ClienteApv.DescriptionHttp = "ERR_SERVICE_BUSCARCLIENTE";
                Log.Error(this, afiliado.Status.Description);
                return StatusCode(StatusCodes.Status500InternalServerError, servicio);
            }
            else if (afiliado.Item == null)
            {
                servicio.ClienteApv = afiliado.Status;
                servicio.ClienteApv.DescriptionHttp = "SUC_CLIENTE_NO_EXISTE";
                Log.War(this, afiliado.Status.Description);
                return Ok(servicio);
            }
            else if (string.IsNullOrEmpty(afiliado.Item.CorreoElectronico))
            {
                servicio.ClienteApv = afiliado.Status;
                servicio.ClienteApv.DescriptionHttp = "SUC_NO_CORREO";
                Log.War(this, afiliado.Status.Description);
                return Ok(servicio);
            }
            else if (datosBasicoExpressRequest.ExtractoSaldo == "true" || datosBasicoExpressRequest.Carne == "true" || datosBasicoExpressRequest.GenerarEstado == "true" || datosBasicoExpressRequest.GenerarHistorico == "true")
            {
                if (datosBasicoExpressRequest.ExtractoSaldo == "true")
                {
                    response = await _extracto.GenerarExtractoSaldo(datosBasicoExpressRequest, afiliado.Item);
                    if (response.HttpCode == System.Net.HttpStatusCode.OK)
                    {
                        servicio.ExtractoSaldo = response;
                        servicio.ClienteApv = response;

                        listaServiciosBitacora.Add(_bitacoraParameters.ExtractoSaldo);

                    }
                    else
                    {
                        servicio.ExtractoSaldo = response;
                        Log.Error(this, $"{response.Description} {response.Message}");
                    }

                }
                if (datosBasicoExpressRequest.Carne == "true")
                {

                    response = await _extracto.GenerarCarne(datosBasicoExpressRequest, afiliado.Item);
                    if (response.HttpCode == System.Net.HttpStatusCode.OK)
                    {
                        servicio.Carne = response;
                        servicio.ClienteApv = response;

                        listaServiciosBitacora.Add(_bitacoraParameters.Carne);

                    }
                    else
                    {
                        servicio.Carne = response;
                        Log.Error(this, $"{response.Description} {response.Message}");
                    }

                }
                if (datosBasicoExpressRequest.GenerarEstado == "true") {
                  
                   
                    
                    var periodo = await _extracto.ObtenerUltimoPeriodo();

                    if (periodo.Item != null) {
                        response = await _extracto.GenerarEstadoCuenta(datosBasicoExpressRequest, afiliado.Item, periodo.Item);
                        if (response.HttpCode == System.Net.HttpStatusCode.OK)
                        {
                            servicio.GenerarEstado = response;
                            servicio.ClienteApv = response;

                            listaServiciosBitacora.Add(_bitacoraParameters.ESTADOCUENTA);

                        }
                        else
                        {
                            servicio.GenerarEstado = response;
                            Log.Error(this, $"{response.Description} {response.Message}");
                        }
                    }
                    else
                    {
                        ResponseStatus generarEstadoError = new ResponseStatus();
                        generarEstadoError.HttpCode = System.Net.HttpStatusCode.InternalServerError;
                        generarEstadoError.Description = periodo.Status.Description;
                        generarEstadoError.Message = periodo.Status.Message;
                        generarEstadoError.DescriptionHttp = periodo.Status.DescriptionHttp;
                        servicio.GenerarEstado = generarEstadoError;
                        Log.Error(this, $"{generarEstadoError.Description} {generarEstadoError.Message}");
                    }


                }
                if (datosBasicoExpressRequest.GenerarHistorico == "true")
                {

                    response = await _extracto.GenerarHistoricoMovimientos(datosBasicoExpressRequest, afiliado.Item);
                    if (response.HttpCode == System.Net.HttpStatusCode.OK)
                    {
                        servicio.HistoricoMovimiento = response;
                        servicio.ClienteApv = response;

                        listaServiciosBitacora.Add(_bitacoraParameters.HistoricoMovimiento);


                    }
                    else
                    {
                        servicio.HistoricoMovimiento = response;
                        Log.Error(this, $"{response.Description} {response.Message}");
                    }

                }
                if ((datosBasicoExpressRequest.ExtractoSaldo == "true" && servicio.ExtractoSaldo.HttpCode == System.Net.HttpStatusCode.OK)
                    || (datosBasicoExpressRequest.Carne == "true" && servicio.Carne.HttpCode == System.Net.HttpStatusCode.OK)
                    || (datosBasicoExpressRequest.GenerarEstado == "true" && servicio.GenerarEstado.HttpCode == System.Net.HttpStatusCode.OK)
                    || (datosBasicoExpressRequest.GenerarHistorico == "true" && servicio.HistoricoMovimiento.HttpCode == System.Net.HttpStatusCode.OK))
                {
                   var bitacora = await _bitacora.GuardarBitacoraApv(bitacoraRequest, listaServiciosBitacora, datosBasicoExpressRequest.CanalServicio);

                    servicio.BitacoraApv = bitacora;
                    return Ok(servicio);
                }
                else 
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, servicio);
                }



            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}