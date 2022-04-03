using Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.Entidades;
namespace Jose_Gonzalez_Ap1_PF.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupo { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public DbSet<Profesores> Profesor { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }

        
        public Contexto(DbContextOptions<Contexto> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nacionalidades>().HasData(new Nacionalidades {
                NacionalidadId = 1,
                Nacionalidad = "Dominicano"
            });

             modelBuilder.Entity<Cursos>().HasData(new Cursos {
                CursoId = 1,
                Descripcion = "Programacion",
                
            });

             modelBuilder.Entity<Aulas>().HasData(new Aulas {
                AulaId = 1,
            });

            modelBuilder.Entity<Estudiante>().HasData(new Estudiante {
                EstudianteId = 1,
            });
            
        }
    }
}