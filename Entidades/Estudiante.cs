using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
       
        public string? Nombre { get; set; }

        public string? ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string? Sexo { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public int Edad { get; set; }
        public int CantidadAsistencias { get; set; }

        public int NacionalidadId { get; set; }

        public string? Descripcion { get; set; }

    }
}