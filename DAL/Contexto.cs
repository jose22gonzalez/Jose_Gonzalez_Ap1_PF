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
                VecesInscrito = 4
                
            });

             modelBuilder.Entity<Aulas>().HasData(new Aulas {
                AulaId = 1,
                Nombre = "A-32",
                VecesAsignada = 7
            });

            modelBuilder.Entity<Estudiante>().HasData(new Estudiante {
                EstudianteId = 1,
                Nombre = "Juan",
                ApellidoPaterno = "Perez",
                ApellidoMaterno = "Sanchez",
                FechaNacimiento = new DateTime(2000, 5, 5),
                Sexo = "Masculino",
                Direccion = "Calle F-H, Las Guaranas, San Francisco de Macoris",
                Telefono = "809-567-9912",
                Email = "Sanchez2001@gmail.com",
                Edad = 22,
                CantidadAsistencias = 5,
                Descripcion = "Programacion"
            });
            
        }
    }
}