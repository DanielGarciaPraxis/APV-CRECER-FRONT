using System.ComponentModel.DataAnnotations;

namespace CanalesElectronicosAPV.Models.DTO
{
    public class ProductsDTO
    {
        public string? LineaProducto { get; set; }
        public string? Producto { get; set; }
        public string? Estado { get; set; }
        public decimal? Saldo { get; set; }
    }

    public class Objetivos
    {
        [Display(Name = "Nombre:")]
        public string? NombreO { get; set; }
        [Display(Name = "Tipo:")]
        public string? Tipo { get; set; }
        [Display(Name = "Fecha Meta:")]
        public string? FechaMeta { get; set; }
        [Display(Name = "Valor Meta:")]
        public string? ValorMeta { get; set; }

        [Display(Name = "Saldo Total:")]
        public string? Saldo { get; set; }

        [Display(Name = "Nombre:")]
        public string? NombreJubilacion { get; set; }

        [Display(Name = "Tipo:")]
        public string? TipoJUbilacion { get; set; }

        [Display(Name = "Fecha Meta:")]
        public string? FMJubilacion { get; set; }

        [Display(Name = "Valor Meta:")]
        public string? VMJubilacion { get; set; }

        [Display(Name = "Saldo Total:")]
        public string? STJubilacion { get; set; }
    }

    public class Distribucion
    {
        public string? NObjetivo { get; set; }
        public string? Consignacion { get; set; }



        public string? Deduccion { get; set; }



        public string? Debito { get; set; }






    }

    public class Beneficiarios
    {



        public string? NombreB { get; set; }
        public string? Parentesco { get; set; }



        public string? FechaNacimiento { get; set; }



        public string? Sexo { get; set; }
        public string? Porcentaje { get; set; }



    }

    public  class ProductosDTO
    {
        public List<ProductsDTO>? Productos { get; set; }
        public List<Distribucion>? Distribucion { get; set; }

        public List<Beneficiarios>? Beneficiario { get; set; }
        public Objetivos? objetivo {get;set;}
        public Beneficiarios? beneficiarios { get; set; }
        public Distribucion? distribucion { get; set; }

       

        

    }

   
}
