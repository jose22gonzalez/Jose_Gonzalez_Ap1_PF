using System.ComponentModel.DataAnnotations;
namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Aulas
    {
        [Key]
        public int AulaId {get; set;}

        public string? Nombre { get; set; }
        public int VecesAsignada {get; set; }

    }
}