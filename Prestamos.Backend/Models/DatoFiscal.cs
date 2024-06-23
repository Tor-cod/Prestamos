using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class DatoFiscal
    {
        [Key]
        public int IdDatoFiscal { get; set; }

        [Required]
        public int IdPersona { get; set; }

        [MaxLength(250)]
        public string? NombrNegocio { get; set; } = string.Empty;

        public DateOnly FechaAltaSAT { get; set; }
        public DateOnly FechaIniOps { get; set; }

        [Required]
        public string? SerieFiel { get; set; } = string.Empty;

        [Required]
        [MaxLength(14)]
        public string? rfc { get; set; } = string.Empty;

        public string? regimenfiscal { get; set; }
        public string? ActividadEco { get; set; }
        public string? DomicilioFiscal { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? pais { get; set; }
        public string? CodigoPostal { get; set; }
        public string? ActividadSAT { get; set; }
        public string? ActividadCNBV { get; set; }
    }
}
