using System.ComponentModel.DataAnnotations;

namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Nacionalidades
    {
        [Key]
        public int NacionalidadId { get; set; }
        public string? Nacionalidad { get; set; }
    }
}