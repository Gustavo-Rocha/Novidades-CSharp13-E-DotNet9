using System.Text.Json;
using System.Text.Json.Nodes;

namespace JsonObject_Ordered_Itens;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Testes com .NET 9 | Manipulando a ordem de itens com JsonObject *****");


        var SerieDeLivros = new JsonObject()
        {
            ["IdSerie"] = 012930349,
            ["NomeSerie"] = "Livros de codificação",
            ["AutorSerie"] = "UNCLE BOB",
            ["AnoSerie"] = 2002,
            ["EditoraSerie"] = "Alta books",
            ["GeneroSerie"] = "Tecnologia",
            ["Livro"] = new JsonArray( new JsonObject
            {
                ["IdSerie"] = 012930349,
                ["TituloLivro"] = "COdigoLimpo",
                ["AutorLivro"] = "UNCLE BOB",
                ["AnoLivro"] = 2021,
                ["EditoraLivro"] = "Alta books",
                ["GeneroLivro"] = "Tecnologia"
            })
        };

        PrintJsonObjectContent(SerieDeLivros);


        Console.WriteLine();
        Console.WriteLine("Demonstrando o uso dos metodos IndexOf e Insert com JsonObject...");
        var posLivroChave = SerieDeLivros.IndexOf("Livro");
        SerieDeLivros.Insert(posLivroChave, "versaoAtualSerie", "2.1.0");

        PrintJsonObjectContent(SerieDeLivros);


    }

    private static void PrintJsonObjectContent(JsonObject serieDeLivros)
    {
        Console.WriteLine();
        Console.WriteLine("Conteudo sem indentacao:");
        Console.WriteLine(serieDeLivros.ToJsonString());

        Console.WriteLine();
        Console.WriteLine("Conteudo com indentacao:");
        Console.WriteLine(serieDeLivros.ToJsonString(
            new JsonSerializerOptions() { WriteIndented = true }));
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

public class SerieLivro
{
    public Guid IdSerie { get; set; }
    public string? NomeSerie { get; set; }
    public string? AutorSerie { get; set; }
    public int AnoSerie { get; set; }
    public string? EditoraSerie { get; set; }
    public string? GeneroSerie { get; set; }
    public List<Livro> Livros { get; set; }
}
