namespace Mvc_SqlRaw.Models;

public class Aluno
{
    public int AlunoId { get; set; }
    public string? Nome { get; set; }
    public string? Cidade { get; set; }
    public DateOnly? DataMatricula { get; set; }
    public bool Ativo { get; set; }
    public Curso? Curso { get; set; }
    public int CursoId { get; set; }
}
