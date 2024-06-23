using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class DatoPersonal
    {
        [Key]
        public int IdDatoPersonal { get; set; }

        [Required]
        public int IdPersona { get; set; }
        public string? estadocivil { get; set; }
        public string? regimenconyugal { get; set; }
        public string? CasadoCon { get; set; }
        public string? Ocupacion { get; set; }
    }
}
