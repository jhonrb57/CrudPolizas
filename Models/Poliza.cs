using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Poliza
    {
        [Key]
        public int NumeroPoliza { get; set; }
        [Display(Name = "Cliente")]
        public string NombreCliente { get; set; }
        [Display(Name = "Id Cliente")]
        public string IdCliente { get; set; }
        [Display(Name = "Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Poliza")]
        public DateTime FechaPoliza { get; set; }
        public string Coberturas { get; set; }
        [Display(Name = "Valor Máximo")]
        public decimal ValorMaximo { get; set; }
        [Display(Name = "Poliza")]
        public string NombrePoliza { get; set; }
        [Display(Name = "Ciudad")]
        public string CiudadResidencia { get; set; }
        [Display(Name = "Dirección")]
        public string DireccionResidencia { get; set; }
        [Display(Name = "Placa")]
        public string PlacaAutomotor { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloAutomotor { get; set; }
        public char Inspeccion { get; set; }
    }
}
