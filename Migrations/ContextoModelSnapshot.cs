﻿// <auto-generated />
using System;
using Jose_Gonzalez_Ap1_PF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jose_Gonzalez_Ap1_PF.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Aulas", b =>
                {
                    b.Property<int>("AulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesAsignada")
                        .HasColumnType("INTEGER");

                    b.HasKey("AulaId");

                    b.ToTable("Aulas");

                    b.HasData(
                        new
                        {
                            AulaId = 1,
                            Nombre = "A-32",
                            VecesAsignada = 7
                        });
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Cursos", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesInscrito")
                        .HasColumnType("INTEGER");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            Descripcion = "Edificio 1",
                            VecesInscrito = 4
                        });
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Estudiante", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadAsistencias")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("NacionalidadId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new
                        {
                            EstudianteId = 1,
                            ApellidoMaterno = "Sanchez",
                            ApellidoPaterno = "Perez",
                            CantidadAsistencias = 5,
                            Descripcion = "Programacion",
                            Direccion = "Calle F-H, Las Guaranas, San Francisco de Macoris",
                            Edad = 22,
                            Email = "Sanchez2001@gmail.com",
                            FechaNacimiento = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NacionalidadId = 0,
                            Nombre = "Juan",
                            Sexo = "Masculino",
                            Telefono = "809-567-9912"
                        });
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Grupos", b =>
                {
                    b.Property<int>("GrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AulaId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Capacidad")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CuposDisponible")
                        .HasColumnType("TEXT");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionCurso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Desde")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Hasta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("GrupoId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Inscripciones", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionCurso")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("InscripcionId");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.InscripcionesDetalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionCurso")
                        .HasColumnType("TEXT");

                    b.Property<int>("GrupoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InscripcionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InscripcionId");

                    b.ToTable("InscripcionesDetalles");
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Nacionalidades", b =>
                {
                    b.Property<int>("NacionalidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("TEXT");

                    b.HasKey("NacionalidadId");

                    b.ToTable("Nacionalidades");

                    b.HasData(
                        new
                        {
                            NacionalidadId = 1,
                            Nacionalidad = "Dominicano"
                        });
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Profesores", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionCurso")
                        .HasColumnType("TEXT");

                    b.Property<int>("GrupoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ProfesorId");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.InscripcionesDetalles", b =>
                {
                    b.HasOne("Jose_Gonzalez_Ap1_PF.Entidades.Inscripciones", null)
                        .WithMany("InscripcionesDetalles")
                        .HasForeignKey("InscripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jose_Gonzalez_Ap1_PF.Entidades.Inscripciones", b =>
                {
                    b.Navigation("InscripcionesDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
