using Microsoft.EntityFrameworkCore;
using Mvc_SqlRaw.Models;

namespace Mvc_SqlRaw.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>().HasData(
           new Curso { Id = 1, Nome = "Inglês", Inicio=new DateOnly(2024,03,01)},
           new Curso { Id = 2, Nome = "Matemática",  Inicio = new DateOnly(2024, 03, 02) },
           new Curso { Id = 3, Nome = "Ciências", Inicio = new DateOnly(2024, 03, 01) },
           new Curso { Id = 4, Nome = "Química", Inicio = new DateOnly(2024, 03, 01) },
           new Curso { Id = 5, Nome = "Música", Inicio = new DateOnly(2024, 06, 02) }
       );

        modelBuilder.Entity<Aluno>().HasData(
            new Aluno { AlunoId = 1, Nome = "João", Cidade="Santos", DataMatricula = new DateOnly(2024,02,14), Ativo = true, CursoId = 1 },
            new Aluno { AlunoId = 2, Nome = "Maria", Cidade = "Guarujá", DataMatricula = new DateOnly(2024, 02, 10), Ativo = true, CursoId = 1 },
            new Aluno { AlunoId = 3, Nome = "Pedro", Cidade = "Guarujá", DataMatricula = new DateOnly(2024, 01, 24), Ativo = false, CursoId = 2 },
            new Aluno { AlunoId = 4, Nome = "Ana", Cidade = "Bertioga", DataMatricula = new DateOnly(2024, 03, 05), Ativo = true, CursoId = 2 },
            new Aluno { AlunoId = 5, Nome = "Carlos", Cidade = "Bertioga", DataMatricula = new DateOnly(2024, 02, 10), Ativo = true, CursoId = 3 },
            new Aluno { AlunoId = 6, Nome = "Mariana", Cidade = "Bertioga", DataMatricula = new DateOnly(2024, 03, 07), Ativo = false, CursoId = 3 },
            new Aluno { AlunoId = 7, Nome = "Lucas", Cidade = "Santos", DataMatricula = new DateOnly(2024, 01, 30), Ativo = true, CursoId = 4 },
            new Aluno { AlunoId = 8, Nome = "Juliana", Cidade = "Santos", DataMatricula = new DateOnly(2024, 02, 11), Ativo = true, CursoId = 4 },
            new Aluno { AlunoId = 9, Nome = "Rodrigo", Cidade = "Peruíbe", DataMatricula = new DateOnly(2024, 03, 09), Ativo = false, CursoId = 1 },
            new Aluno { AlunoId = 10, Nome = "Fernanda", Cidade = "Santos", DataMatricula = new DateOnly(2024, 01, 30), Ativo = true, CursoId = 2 }
        );
    }
}
