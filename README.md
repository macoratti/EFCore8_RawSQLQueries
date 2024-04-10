SqlQuery - Retorna um conjunto de resultados (IQueryable) mapeados para um tipo especificado, 
seja uma entidade existente ou um tipo personalizado

Exemplo:

var resultado = await _context
    .Database
    .SqlQuery<ResultadoNomeado>($"Select Id, Nome from Clientes")
    .FirstOrDefaultAsync();

record ResultadoNomeado(int Id, string Nome);

Recursos:

- Escrever qualquer consulta SQL válida diretamente no código, incluindo instruções
- complexas com joins, funções de agregação, subconsultas e outros recursos avançados.

- Acessar tabelas, colunas ou views que não foram mapeadas para entidades no seu modelo de dados do EF Core.

- Executar procedimentos armazenados existentes no seu banco de dados diretamente do código C#.
