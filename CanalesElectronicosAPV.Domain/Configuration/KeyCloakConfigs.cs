using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanalesElectronicosAPV.Domain.Configuration
{
    [ExcludeFromCodeCoverage]
    public class KeyCloakConfigs
    {
        public string ?ClientId { get; set; }
        public string ?ClientSecret { get; set; }
        public string ?KeycloakUrl { get; set; }
        public string ?Realm { get; set; }
      
    }
}
