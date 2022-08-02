using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicosAPV.Core.Dto_s.Request
{
    [ExcludeFromCodeCoverage]
    public class AfiliadoRequest
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
