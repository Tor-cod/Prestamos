using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class Domicilio
    {
        [Key]
        public int IdDomicilio { get; set; }

        [Required]
        public int IdPersona { get; set; }

        [Required]
        [MaxLength(250)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [MaxLength(6)]
        public string NoExt { get; set; } = string.Empty;

        [MaxLength(6)]
        public string? NoInt { get; set; } = string.Empty;

        [MaxLength(6)]
        public string? Referencia { get; set; } = string.Empty;

        [Required]
        public string Colonia { get; set; } = string.Empty;

        [Required]
        public string Municipio { get; set; } = string.Empty;

        [Required]
        public string Estado { get; set; } = string.Empty;

        [Required]
        public string Pais { get; set; } = string.Empty;

        [Required]
        public string CodPostal { get; set; } = string.Empty;

        [Required]
        public string Nacionalidad { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Telefono { get; set; } = string.Empty;
    }
}
