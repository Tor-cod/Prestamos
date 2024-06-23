using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class Accionista
    {
        [Key]
        public int IdAccionista { get; set; }

        [Required]
        public int IdPersona { get; set; }

        [MaxLength(150)]
        public string? PrimerNombre { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? SegundoNombre { get; set; } = string.Empty;
    }
}
