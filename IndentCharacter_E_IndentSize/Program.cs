using System.Text.Json;

namespace IndentCharacter_E_IndentSize;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Testes com .NET 9 | Indentation options *****");

        var livros = new Livro[]
        {
            new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Codigo Limpo", AutorLivro ="Uncle Bob", AnoLivro = 2000,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" },
            new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Arquitetura Limpa", AutorLivro ="Uncle Bob", AnoLivro = 2019,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" }
        };

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 5
        };

        Console.WriteLine("*** Resultados da serializacao SEM a opção JsonSerializerOptions.Web ***");
        foreach (var livro in livros)
        {
            Console.WriteLine();
            Console.WriteLine(JsonSerializer.Serialize(livro,options));
        }        
    }
}

public class Livro
{
    public Guid IdLivro { get; set; }
    public string? TituloLivro { get; set; }
    public string? AutorLivro { get; set; }
    public int AnoLivro { get; set; }
    public string? EditoraLivro { get; set; }
    public string? GeneroLivro { get; set; }
}
