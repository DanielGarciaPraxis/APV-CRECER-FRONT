using System.ComponentModel.DataAnnotations;

namespace CanalesElectronicosAPV.Models.DTO
{
    public class ServicesDTO
    {
        public int TipoServicio { get; set; }
        [Display(Name = "Periodo*")]
        public string Periodo { get; set; }
        [Display(Name = "Fecha de Corte")]
        public string FechaCorte { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Código cliente:")]
        public string CodigoCliente { get; set; }
        [Display(Name = "NPE:")]
        public string NPE { get; set; }
    }
}
