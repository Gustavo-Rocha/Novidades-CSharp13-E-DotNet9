using System.Text.Json;
using IntList = System.Collections.Generic.List<int>;

internal class Program
{
    private static void Main(string[] args)
    {
        //Novidades do .NET 9: serialização utilizando JsonSerializerOptions.Web (no padrão do ASP.NET Core)
        Console.WriteLine("***** Testes com .NET 9 | Serializacao com Default web options *****");

        var livros = new Livro[]
        {
            new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Codigo Limpo", AutorLivro ="Uncle Bob", AnoLivro = 2000,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" },
            new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Arquitetura Limpa", AutorLivro ="Uncle Bob", AnoLivro = 2019,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" }
        };

        Console.WriteLine("*** Resultados da serializacao SEM a opção JsonSerializerOptions.Web ***");
        foreach (var livro in livros)
        {
            Console.WriteLine();
            Console.WriteLine(JsonSerializer.Serialize(livro));
        }
        Console.WriteLine();

        Console.WriteLine("*** Resultados da serializacao COM JsonSerializerOptions.Web ***");
        foreach (var livro in livros)
        {
            Console.WriteLine();
            Console.WriteLine(JsonSerializer.Serialize(livro, JsonSerializerOptions.Web));
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