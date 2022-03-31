using Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.Entidades;
namespace Jose_Gonzalez_Ap1_PF.Contexto
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupo { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nacionalidades>().HasData(new Nacionalidades {
                NacionalidadId = 1,
                Nacionalidad = "Dominicano"
            });
        }
    }
}