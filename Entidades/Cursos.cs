using System.ComponentModel.DataAnnotations;
namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Cursos
    {
         [Key]
        public int CursoId {get; set;}
        public string? Descripcion { get; set; }
   
    }
}