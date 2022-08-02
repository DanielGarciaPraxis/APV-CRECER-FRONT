using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;

namespace CanalesElectronicosAPV.Core.Dto_s.Common
{
    [ExcludeFromCodeCoverage]
    public class ConsultService
    {
        public string BaseAddress { get; set; }
        public string ConfigUrls { get; set; }
        public HttpMethod Method { get; set; }
    }
}
