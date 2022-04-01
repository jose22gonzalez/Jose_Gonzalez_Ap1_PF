namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Inscripciones
    {
        public int InscripcionId { get; set; }
        public DateTime? Fecha { get; set; } = null;
        public int EstudianteId { get; set; }

        public virtual List<InscripcionesDetalles> InscripcionesDetalles {get; set;} = new List<InscripcionesDetalles>();
        
    }
}