using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicosAPV.Core.Dto_s.Response
{
    [ExcludeFromCodeCoverage]
    public class AfiliadoResponse
    {
        public int IdCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdProducto { get; set; }
        public int IdFondo { get; set; }
        public string Fondo { get; set; }
        public string Producto { get; set; }

    }
}
