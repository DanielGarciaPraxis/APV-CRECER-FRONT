using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CanalesElectronicosAPV.Core.Dto_s.Common
{
    [ExcludeFromCodeCoverage]
    public class KeyCloakConfig
    {
        public string ServerAddress { get; set; }
        public string Realm { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
