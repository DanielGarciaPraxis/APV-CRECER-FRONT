using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;


namespace CanalesElectronicosAPV.Core.Dto_s.Response
{
    [ExcludeFromCodeCoverage]
    public class ResponseStatus
    {
        public HttpStatusCode HttpCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string DescriptionHttp { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class ResponseItem <T>
    {
        public T Base64 { get; set; }
        public string mensaje { get; set; }
    }
}
