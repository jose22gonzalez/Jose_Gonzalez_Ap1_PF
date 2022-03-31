namespace Jose_Gonzalez_Ap1_PF.Entidades
{
    public class Grupos
    {
        public int GrupoId { get; set; }
        public int ProfesorId { get; set; }
        public string? Descripcion { get; set; }
        public int AulaId { get; set; }
        public int CursoId { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public int Tiempo { get; set; }
        public decimal Capacidad { get; set; }
        public decimal CuposDisponible { get; set; }
    }
}