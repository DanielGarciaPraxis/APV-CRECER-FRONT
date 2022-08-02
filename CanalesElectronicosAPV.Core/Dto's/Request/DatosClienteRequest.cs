using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicosAPV.Core.Dto_s.Request
{
    [ExcludeFromCodeCoverage]
    public class DatosClienteRequest
    {
        public Header Header { get; set; }
        public string? CodigoProducto { get; set; }
        public string? CodigoTipoIdentificacion { get; set; }
        public string? NumeroIdentificacion { get; set; }
        public string? IdPersona { get; set; }
        public string? FechaInicio { get; set; }
        public string? FechaFin { get; set; }
    }
    public class Header
    {
        public string? Usuario { get; set; }
        public string? Ip { get; set; }
        public string? Canal { get; set; }
    }
}
