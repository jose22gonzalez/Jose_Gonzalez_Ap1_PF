using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jose_Gonzalez_Ap1_PF.Migrations
{
    public partial class ProyectoFinalAP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    AulaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.AulaId);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfesorId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescripcionCurso = table.Column<string>(type: "TEXT", nullable: false),
                    AulaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Desde = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Hasta = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacidad = table.Column<decimal>(type: "TEXT", nullable: false),
                    CuposDisponible = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescripcionCurso = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.InscripcionId);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    NacionalidadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nacionalidad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.NacionalidadId);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    DescripcionCurso = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.ProfesorId);
                });

            migrationBuilder.CreateTable(
                name: "InscripcionesDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InscripcionId = table.Column<int>(type: "INTEGER", nullable: false),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescripcionCurso = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionesDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InscripcionesDetalles_Inscripciones_InscripcionId",
                        column: x => x.InscripcionId,
                        principalTable: "Inscripciones",
                        principalColumn: "InscripcionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aulas",
                column: "AulaId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Descripcion" },
                values: new object[] { 1, "Programacion" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                column: "EstudianteId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "NacionalidadId", "Nacionalidad" },
                values: new object[] { 1, "Dominicano" });

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionesDetalles_InscripcionId",
                table: "InscripcionesDetalles",
                column: "InscripcionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "InscripcionesDetalles");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropTable(
                name: "Inscripciones");
        }
    }
}
