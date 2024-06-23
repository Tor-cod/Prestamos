using System.ComponentModel.DataAnnotations;

namespace Prestamos.Backend.Models
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        public Tipoper tipoper { get; set; }

        [MaxLength(150)]
        public string? PrimerNombre { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? SegundoNombre { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? ApPaterno { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? ApMaterno { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? RazonSocial { get; set; } = string.Empty;

        [MaxLength(250)]
        public string? TipoSociedad { get; set; } = string.Empty;
        public DateOnly Fecha { get; set; }

        [Required]
        [MaxLength(14)]
        public string rfc { get; set; } = string.Empty;

        [MaxLength(18)]
        public string? curp { get; set; } = string.Empty;

        public Genero? genero { get; set; }

        public List<Domicilio> Domicilios { get; set; } = null!;

        public List<DatoPersonal> DatosPersonales { get; set; } = null!;

        public List<DatoFiscal> DatosFiscales { get; set; } = null!;

        public List<RepresentanteLegal> RepresentanteLegals { get; set; } = null!;

        public List<Accionista> Accionistas { get; set; } = null!;

    }
    public enum Tipoper
    {
        Fisica, Moral
    }

    public enum Genero
    {
        Hombre, Mujer, Otro
    }
}
