namespace Novidade_OrderedDictionary;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Testes com .NET 9 | OrderedDictionary<TKey,TValue> *****");



        OrderedDictionary<string, Livro> d = new()
        {
            ["Clean_Code"] = new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Codigo Limpo", AutorLivro = "Uncle Bob", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" },
            ["Arquitetura_Limpa"] = new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Arquitetura Limpa", AutorLivro = "Uncle Bob", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" },
            ["DDD"] = new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Domain Driven Design ", AutorLivro = "Uncle Bob", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" }

        };
        d.Add("Desing_Patterns", new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Design Patterns", AutorLivro = "GOF", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" });
        d.Insert(1, "POO", new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Programaçao Orientada a Objeto", AutorLivro = "Casa Do COdigo", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" });
        d.RemoveAt(0);
        d.Insert(0, "RoadMap_Estudos", new() { IdLivro = Guid.CreateVersion7(), TituloLivro = "Roadmap De Estudos", AutorLivro = "Nick Shapsas", AnoLivro = 2000, EditoraLivro = "Alta books", GeneroLivro = "Tecnologia" });

        Console.WriteLine("Livros de Tecnologia");
        foreach (KeyValuePair<string, Livro> entry in d)
            Console.WriteLine(entry);

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