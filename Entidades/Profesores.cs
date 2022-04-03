using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Profesores
    {
        [Key]
        public int ProfesorId { get; set; }
        public int GrupoId { get; set; }
        public string? Nombre { get; set; }
        public string? DescripcionCurso { get; set; }

    }
}