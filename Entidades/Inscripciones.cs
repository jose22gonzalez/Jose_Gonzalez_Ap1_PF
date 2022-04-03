using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime? Fecha { get; set; } = null;
        public int EstudianteId { get; set; }
        public string? DescripcionCurso { get; set; }

        [ForeignKey("InscripcionId")]
        public virtual List<InscripcionesDetalles> InscripcionesDetalles {get; set;} = new List<InscripcionesDetalles>();

        
    }
}