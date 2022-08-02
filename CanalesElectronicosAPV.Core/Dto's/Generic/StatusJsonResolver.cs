using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CanalesElectronicosAPV.Core.Dto_s.Generic
{
    [ExcludeFromCodeCoverage]
    public class StatusJsonResolver: DefaultContractResolver
    { 
         private Dictionary<string, string> propertyMapping { get; set; }
        public StatusJsonResolver()
        {
            this.propertyMapping = new Dictionary<string, string>
                {
                    {"HttpCode", "Code"},
                    {"Description", "Description"}
                };
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            string resolvedName = null;
            var resolved = this.propertyMapping.TryGetValue(propertyName, out resolvedName);
            return (resolved) ? resolvedName : base.ResolvePropertyName(propertyName);
        }
    }
}
