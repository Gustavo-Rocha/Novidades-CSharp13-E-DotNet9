
using System.Text.Json;
using System.Text.Json.Schema;
namespace Novidades_JsonSchemaExporter;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Novidades do .NET 9: gerando schemas JSON com JsonSchemaExporter");

        Console.WriteLine("***** Testes com .NET 9 | Utilizando JsonSchemaExporter *****");

        Console.WriteLine($"Schema do tipo {nameof(SerieLivro)} no formato JSON:");
        Console.WriteLine(JsonSchemaExporter.GetJsonSchemaAsNode(JsonSerializerOptions.Default, typeof(SerieLivro)));
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