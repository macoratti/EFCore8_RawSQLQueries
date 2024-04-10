using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_SqlRaw.Context;
using Mvc_SqlRaw.Models;

namespace Mvc_SqlRaw.Controllers;

public class AlunosController : Controller
{
    private readonly AppDbContext _context;

    public AlunosController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var alunos = _context.Alunos.FromSql<Aluno>($@"SELECT
                                          Alunos.AlunoId,
                                          Alunos.Nome,
                                          Alunos.Cidade,
                                          Alunos.DataMatricula,
                                          Alunos.Ativo,
                                          Alunos.CursoId
                                         FROM
                                          Alunos");

        var resultado = await alunos.ToListAsync();

        return View(resultado);

    }
    public async Task<IActionResult> AlunosCursos(string cidadeSelecionada)
    {
        var alunos = _context.Database.SqlQuery<AlunoCurso>($@"SELECT
                                                            Alunos.AlunoId,
                                                            Alunos.Nome AS NomeAluno,
                                                            Alunos.Cidade AS CidadeAluno,
                                                            Alunos.DataMatricula AS DataMatriculaAluno,
                                                            Alunos.Ativo AS AlunoAtivo,
                                                            Cursos.Id AS CursoId,
                                                            Cursos.Nome AS NomeCurso,
                                                            Cursos.Inicio AS InicioCurso
                                                        FROM
                                                            Alunos
                                                        INNER JOIN
                                                            Cursos ON Alunos.CursoId = Cursos.Id
                                                        WHERE (Alunos.Cidade = {cidadeSelecionada} OR {cidadeSelecionada} = '') 
                                                                                                   OR ({cidadeSelecionada} IS NULL)
                                                        ORDER BY Alunos.Nome");

        var resultado = await alunos.ToListAsync();

        return View(resultado);
    }
}