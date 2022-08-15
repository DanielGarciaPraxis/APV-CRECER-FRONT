using System.ComponentModel;

namespace CanalesElectronicosAPV.Models.DTO
{
    public class ContactUsDTO
    {
        public string TipoConsulta { get; set; }
        [DisplayName("Mensaje*")]
        public string Mensaje { get; set; }
        public string Archivo { get; set; }
    }
}
