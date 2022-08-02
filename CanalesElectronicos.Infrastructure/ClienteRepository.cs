using CanalesElectronicos.Infrastructures.Common;
using CanalesElectronicosAPV.Core.Dto_s.Common;
using CanalesElectronicosAPV.Core.Dto_s.Generic;
using CanalesElectronicosAPV.Core.Dto_s.Request;
using CanalesElectronicosAPV.Core.Dto_s.Response;
using CanalesElectronicosAPV.Core.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net;

namespace CanalesElectronicos.Infrastructure
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IRestRepository _consumer;
        private readonly ConfigUrls _url;

        public ClienteRepository(IRestRepository consumer, IOptions<ConfigUrls> url)
        {
            _url = url.Value ?? throw new ArgumentNullException(nameof(url));
            _consumer = consumer ?? throw new ArgumentNullException(nameof(consumer));
        }
        public async Task<GenericResponse<DatosClienteMainResponse>> ConsultarDatos(DatosClienteRequest clienteRequest)
        {
            GenericResponse<DatosClienteMainResponse>? response = new();
            //DatosClienteResponse? response = new();
            ConsultService servicio = new ()
            {
                BaseAddress = _url.ClienteApv,
                ConfigUrls = Constants.ConsultaCliente,
                Method = HttpMethod.Post
            };

            RestRepositoryDto consultaCliente = await _consumer.DatosConsumerAsync(servicio, clienteRequest);
            if (consultaCliente.Json == null)
            {
                response.Status = new ResponseStatus
                {

                    HttpCode = HttpStatusCode.NotFound
                };
                return response;

            }
           
            response = JsonConvert.DeserializeObject<GenericResponse<DatosClienteMainResponse>>(consultaCliente.Json);
            response.Status = new ResponseStatus
            {

                HttpCode = HttpStatusCode.OK
            };
            return response;
        }

        public async Task<GenericResponse<AfiliadoResponse>> InformacionUsuario(AfiliadoRequest data)
        {
            ResponseStatus response = new ResponseStatus();
            GenericResponse<AfiliadoResponse> afiliadoResponse = new GenericResponse<AfiliadoResponse>();
            ConsultService servicio = new ConsultService()
            {
                BaseAddress = _url.ClienteApv,
                ConfigUrls = Constants.VerificarCliente,
                Method = HttpMethod.Post
            };
            var sfcliente = await _consumer.DatosConsumerAsync(servicio, data);
            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new StatusJsonResolver();
            if (sfcliente.Json != null)
            {
                afiliadoResponse = JsonConvert.DeserializeObject<GenericResponse<AfiliadoResponse>>(sfcliente.Json, settings);
            }
            else
            {
                afiliadoResponse.Status = sfcliente.Status;
            }
            return afiliadoResponse;
        }
    }
}
