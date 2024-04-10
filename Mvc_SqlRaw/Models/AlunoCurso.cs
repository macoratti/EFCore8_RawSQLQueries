namespace Mvc_SqlRaw.Models;

public class AlunoCurso
{
    public string? NomeAluno { get; set; }
    public string? CidadeAluno { get; set; }
    public DateOnly? DataMatriculaAluno { get; set; }
    public bool AlunoAtivo { get; set; }
    public string? NomeCurso { get; set; }
    public DateOnly? InicioCurso { get; set; }
}
