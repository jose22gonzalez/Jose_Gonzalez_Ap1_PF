using System.ComponentModel.DataAnnotations;

namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class InscripcionesDetalles
    {
        [Key]
        public int Id { get; set; }
        public int InscripcionId { get; set; }
        public int GrupoId { get; set; }
        public string? DescripcionCurso { get; set; }
    }
}