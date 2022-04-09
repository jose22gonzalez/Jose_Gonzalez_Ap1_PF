using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public int ProfesorId { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la descrincion curso")]
        public string? DescripcionCurso { get; set; }
        public int AulaId { get; set; }
        public int CursoId { get; set; }
        [Required(ErrorMessage = "Es obligatorio indicar la fecha de comienzo")]
        public DateTime? Desde { get; set; } = null;
        [Required(ErrorMessage = "Es obligatorio indicar la fecha de final")]
        public DateTime? Hasta { get; set; } = null;

        [Required(ErrorMessage = "Es obligatorio indicar el tiempo")]
        public int Tiempo { get; set; }

        [Required(ErrorMessage = "Es osbligatorio introducir la capacidad")]
        [Range(15, 30, ErrorMessage = "La capacidad de ser mayor a 15 y  maximo 30")]
        public decimal Capacidad { get; set; }
        [Required(ErrorMessage = "Es osbligatorio introducir los cupos disponible")]

        [Range(1, 30, ErrorMessage = "La capacidad de ser mayor a 1 y  maximo 30")]
        public decimal CuposDisponible { get; set; }


    }
}