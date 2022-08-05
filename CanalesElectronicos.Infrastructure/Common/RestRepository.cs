using CanalesElectronicosAPV.Core.Dto_s.Common;
using CanalesElectronicosAPV.Core.Dto_s.Response;
//using KeycloakTokenManager;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Log4Net_Logging;
using Microsoft.Extensions.Options;

namespace CanalesElectronicos.Infrastructures.Common
{
    public class RestRepository : IRestRepository
    {
        public virtual HttpClient cliente { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        //private readonly ITokenManager manager;
        private readonly ConfigUrls _url;
        private readonly EmailConfig _emailConfig;

        //public RestRepository(ITokenManager _manager, IOptions<ConfigUrls> url, IOptions<EmailConfig> emailConfig)
        //{
        //    manager = _manager ?? throw new ArgumentNullException(nameof(_manager));
        //    cliente = new HttpClient();
        //    _url = url.Value ?? throw new ArgumentNullException(nameof(url));
        //    _emailConfig = emailConfig.Value ?? throw new ArgumentNullException(nameof(emailConfig));

        //    Log.SetUp(Assembly.GetEntryAssembly(), "log4net.config");
        //}
        //public RestRepository(IOptions<ConfigUrls> url, IOptions<EmailConfig> emailConfig)
        //{
           
        //    cliente = new HttpClient();
        //    _url = url.Value ?? throw new ArgumentNullException(nameof(url));
        //    _emailConfig = emailConfig.Value ?? throw new ArgumentNullException(nameof(emailConfig));

        //    Log.SetUp(Assembly.GetEntryAssembly(), "log4net.config");
        //}

        public async Task<RestRepositoryDto> DatosConsumerAsync(ConsultService datos, object request)
        {
            RestRepositoryDto response = new RestRepositoryDto();
            //return response;
            try
            {
                ConsultService datosServicio = new ConsultService();
                //string token = await manager.GetAccessTokenAsync();
                string uri = $"{datos.BaseAddress}{datos.ConfigUrls}";
                HttpRequestMessage messageRequest = new HttpRequestMessage
                {
                    Method = datos.Method,
                    RequestUri = new Uri(uri)

                };
                messageRequest.Headers.Accept.Clear();
                messageRequest.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //messageRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, token);
                //if (_url.NotificadorApv.Equals(datos.BaseAddress))
                //{
                //    messageRequest.Headers.Add("userName", _emailConfig.UsrApvCliente);
                //    messageRequest.Headers.Add("version", _emailConfig.VersionApvCliente);

                //}
                if (Headers != null)
                {
                    foreach (var item in Headers)
                        messageRequest.Headers.Add(item.Key, item.Value);
                }
                if (cliente.BaseAddress == null)
                {
                    cliente.BaseAddress = new Uri(uri);
                }


                var serializarRequest = JsonConvert.SerializeObject(request);
                messageRequest.Content = new StringContent(serializarRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage message = await cliente.SendAsync(messageRequest);
                response.Json = await message.Content.ReadAsStringAsync();

                if (!message.IsSuccessStatusCode)
                {
                    response.Status = new ResponseStatus()
                    {
                        HttpCode = message.StatusCode,
                        Description = $"Error en la respuesta del servicio {message.RequestMessage.RequestUri}"
                    };

                    Log.War(this, $"Error en la respuesta del servicio {message.RequestMessage.RequestUri}");
                }
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(this, $"Error al consumir el servicio {datos.BaseAddress}{datos.ConfigUrls}--{ex.Message} {ex.InnerException}");
                response = new RestRepositoryDto
                {
                    Status = new ResponseStatus()
                    {
                        HttpCode = System.Net.HttpStatusCode.InternalServerError,
                        Description = $"Error al consumir el servicio {datos.BaseAddress}{datos.ConfigUrls}",
                        Message = $"{ex.Message} {ex.InnerException}"
                    }
                };
                return response;
            }
        }

        public async Task<RestRepositoryDto> DatosAsyncGet(ConsultService datos)
        {
            RestRepositoryDto responseGet = new RestRepositoryDto();
            return responseGet;
            //try
            //{
            //    ConsultService datosServicioGet = new ConsultService();
            //    string tokenGet = await manager.GetAccessTokenAsync();
            //    string uriGet = $"{datos.BaseAddress}{datos.ConfigUrls}";
            //    HttpRequestMessage messageRequestGet = new HttpRequestMessage
            //    {
            //        Method = datos.Method,
            //        RequestUri = new Uri(uriGet)

            //    };
            //    messageRequestGet.Headers.Accept.Clear();
            //    messageRequestGet.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //    messageRequestGet.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, tokenGet);
               
            //    if (Headers != null)
            //    {
            //        foreach (var item in Headers)
            //            messageRequestGet.Headers.Add(item.Key, item.Value);
            //    }
            //    if (cliente.BaseAddress == null)
            //    {
            //        cliente.BaseAddress = new Uri(uriGet);
            //    }

            //    HttpResponseMessage messageGet = await cliente.SendAsync(messageRequestGet);
            //    responseGet.Json = await messageGet.Content.ReadAsStringAsync();

            //    if (!messageGet.IsSuccessStatusCode)
            //    {
            //        responseGet.Status = new ResponseStatus()
            //        {
            //            HttpCode = messageGet.StatusCode,
            //            Description = $"Error en la respuesta del servicio {messageGet.RequestMessage.RequestUri}"
            //        };

            //        Log.War(this, $"Error en la respuesta del servicio {messageGet.RequestMessage.RequestUri}");
            //    }
            //    return responseGet;
            //}
            //catch (Exception ex)
            //{
            //    Log.Error(this, $"Error al tratar de consumir el servicio {datos.BaseAddress}{datos.ConfigUrls}--{ex.Message} {ex.InnerException}");
            //    responseGet = new RestRepositoryDto
            //    {
            //        Status = new ResponseStatus()
            //        {
            //            HttpCode = System.Net.HttpStatusCode.InternalServerError,
            //            Description = $"Error al tratar de consumir el servicio {datos.BaseAddress}{datos.ConfigUrls}",
            //            Message = $"{ex.Message} {ex.InnerException}"
            //        }
            //    };
            //    return responseGet;
            //}
        }

    }
}
