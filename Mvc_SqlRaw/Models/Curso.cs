namespace Mvc_SqlRaw.Models;

public class Curso
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public DateOnly? Inicio { get; set; }
    public List<Aluno>? Alunos { get; set; }
}
