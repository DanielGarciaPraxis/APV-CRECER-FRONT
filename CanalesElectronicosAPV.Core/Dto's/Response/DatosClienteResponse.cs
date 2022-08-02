using System.Diagnostics.CodeAnalysis;

namespace CanalesElectronicosAPV.Core.Dto_s.Response
{

    [ExcludeFromCodeCoverage]
    public class DatosClienteMainResponse
    {
        public string NombreCompleto { get; set; }
        public string CodigoTipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string TipoPersona { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string genero { get; set; }
        public string FechaExpedicionIdentificacion { get; set; }
        public string Estado { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string EstadoAfiliado { get; set; }
        public string Segmento { get; set; }
        public string Nit { get; set; }
        public string NombreNacionalidad { get; set; }
        public string NombreOcupacion { get; set; }
        public string NombreAsesorAsignado { get; set; }
        public string PaisExpedicionIdentificacion { get; set; }
        public string CiudadExpedicionIdentificacion { get; set; }
        public string FechaVencimientoIdentificacion { get; set; }
        public string Anuencia { get; set; }
        public string PersonalNumeroCelular { get; set; }
        public string PersonalDireccion { get; set; }
        public string PersonalNumeroTelefonico { get; set; }
        public string PersonalCorreoElectronico { get; set; }
        public string LaboralNumeroCelular { get; set; }
        public string LaboralDireccion { get; set; }
        public string LaboralNumeroTelefonico { get; set; }

    }

}