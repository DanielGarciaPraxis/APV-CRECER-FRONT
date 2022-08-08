using System.ComponentModel.DataAnnotations;

namespace CanalesElectronicosAPV.Models.DTO
{
    public class ProductsDTO
    {
        public string? LineaProducto { get; set; }
        public string? Producto { get; set; }
        public string? Estado { get; set; }
        public string? Saldo { get; set; }
    }

    public class Objetivos
    {
        [Display(Name = "NOMBRE:")]
        public string? NombreO { get; set; }
        [Display(Name = "TIPO:")]
        public string? Tipo { get; set; }
        [Display(Name = "FECHA META:")]
        public string? FechaMeta { get; set; }
        [Display(Name = "VALOR META:")]
        public string? ValorMeta { get; set; }

        [Display(Name = "SALDO TOTAL:")]
        public string? Saldo { get; set; }

        [Display(Name = "NOMBRE:")]
        public string? NombreJubilacion { get; set; }

        [Display(Name = "TIPO:")]
        public string? TipoJUbilacion { get; set; }

        [Display(Name = "FECHA META:")]
        public string? FMJubilacion { get; set; }

        [Display(Name = "VALOR META:")]
        public string? VMJubilacion { get; set; }

        [Display(Name = "SALDO META:")]
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

    public class CuentasBancarias
    {
        [Display(Name ="ENTIDAD FINANCIERA:")]
        public string EntidadFinanciera { get; set; }
        [Display(Name = "TIPO DE CUENTA BANCARIA:")]
        public string TipoCuenta{ get; set; }
        [Display(Name = "PROPÓSITO DE LA CUENTA BANCARIA:")]
        public string Proposito { get; set; }
        [Display(Name = "NÚMERO DE LA CUENTA BANCARIA:")]
        public string NumeroCuenta { get; set; }
        [Display(Name = "TIPO DE IDENTIFICACIÓN DEL CLIENTE TITULAR:")]
        public string TipoIdentificacion { get; set; }
        [Display(Name = "NÚMERO DE IDENTIFICACION DEL CLIENTE TITULAR:")]
        public string NumeroIdentificacion { get; set; }
        [Display(Name = "CUENTA PREFERIDA:")]
        public string CuentaPreferida { get; set; }
        [Display(Name = "ESTADO DE LA CUENTA EN AFP:")]
        public string EstadoCuenta { get; set; }

    }
    public  class ProductosDTO
    {
        public List<ProductsDTO>? Productos { get; set; }
        public List<Distribucion>? Distribucion { get; set; }
        public List<Beneficiarios>? Beneficiario { get; set; }
        public Objetivos? objetivo {get;set;}
        public Beneficiarios? beneficiarios { get; set; }
        public Distribucion? distribucion { get; set; }
        public CuentasBancarias cuentasbancarias { get; set; }

    }

   
}
