using ClientesApv.Core.Dto_s.Common;
using ClientesApv.Core.Dto_s.Generic;
using ClientesApv.Core.Dto_s.Request;
using ClientesApv.Core.Dto_s.Response;
using ClientesApv.Core.Interfaces;
using ClientesApv.Infrastructures.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApv.Infrastructures
{
    public class BitacoraApvRepository : IBitacoraApvRepository
    {
        private readonly IRestRepository _consumer;
        private readonly ConfigUrls _url;

        public BitacoraApvRepository(IRestRepository consumer, IOptions<ConfigUrls> url)
        {
            _url = url.Value ?? throw new ArgumentNullException(nameof(url));
            _consumer = consumer ?? throw new ArgumentNullException(nameof(consumer));
        }
        public async Task<ResponseStatus> GuardarBitacoraApv(List<BitacoraApvRequest> bitacora)
        {
            ResponseStatus response = new ResponseStatus();
            ConsultService servicio = new ConsultService()
            {
                BaseAddress = _url.BitacoraApv,
                ConfigUrls = Constants.GuardarBitacora,
                Method = HttpMethod.Post
            };
            var bitacoraApv = await _consumer.DatosConsumerAsync(servicio, bitacora);
            if (bitacoraApv.Json != null)
            {
                response = JsonConvert.DeserializeObject<ResponseStatus>(bitacoraApv.Json);
            }
            else
            {
                response = bitacoraApv.Status;

            }
            return response;
        }
    }
}
