using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class RepresentanteLegal
    {
        [Key]
        public int IdRepresentanteLegal { get; set; }

        [Required]
        public int IdPersona { get; set; }
        public string? TipoRepresentante { get; set; }
        [MaxLength(150)]
        public string? PrimerNombre { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? SegundoNombre { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? ApPaterno { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? ApMaterno { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? Cargo { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? IDActConst { get; set; } = string.Empty;
    }
}
