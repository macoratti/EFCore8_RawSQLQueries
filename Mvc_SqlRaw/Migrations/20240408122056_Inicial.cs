using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mvc_SqlRaw.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inicio = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataMatricula = table.Column<DateOnly>(type: "date", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "Id", "Inicio", "Nome" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 3, 1), "Inglês" },
                    { 2, new DateOnly(2024, 3, 2), "Matemática" },
                    { 3, new DateOnly(2024, 3, 1), "Ciências" },
                    { 4, new DateOnly(2024, 3, 1), "Química" },
                    { 5, new DateOnly(2024, 6, 2), "Música" }
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Ativo", "Cidade", "CursoId", "DataMatricula", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Santos", 1, new DateOnly(2024, 2, 14), "João" },
                    { 2, true, "Guarujá", 1, new DateOnly(2024, 2, 10), "Maria" },
                    { 3, false, "Guarujá", 2, new DateOnly(2024, 1, 24), "Pedro" },
                    { 4, true, "Bertioga", 2, new DateOnly(2024, 3, 5), "Ana" },
                    { 5, true, "Santos", 3, new DateOnly(2024, 2, 10), "Carlos" },
                    { 6, false, "Bertioga", 3, new DateOnly(2024, 3, 7), "Mariana" },
                    { 7, true, "Santos", 4, new DateOnly(2024, 1, 30), "Lucas" },
                    { 8, true, "Santos", 4, new DateOnly(2024, 2, 11), "Juliana" },
                    { 9, false, "Peruíbe", 1, new DateOnly(2024, 3, 9), "Rodrigo" },
                    { 10, true, "Santos", 2, new DateOnly(2024, 1, 30), "Fernanda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
