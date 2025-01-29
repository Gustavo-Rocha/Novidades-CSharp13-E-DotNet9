using System.Text.Json;

namespace GUIDs_v7;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Novidades do .NET 9: serialização utilizando JsonSerializerOptions.Web (no padrão do ASP.NET Core)
        Console.WriteLine("***** Testes com .NET 9 | Novo Guid V7 *****");

        //var livrosNormalGuidV4 = new Livro[]
        //{
        //    new(){ IdLivro = Guid.NewGuid(), TituloLivro = "Codigo Limpo", AutorLivro ="Uncle Bob", AnoLivro = 2000,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" },
        //    new(){ IdLivro = Guid.NewGuid(), TituloLivro = "Arquitetura Limpa", AutorLivro ="Uncle Bob", AnoLivro = 2019,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" }
        //};

        //var livrosGuidV7 = new Livro[]
        //{
        //    new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Codigo Limpo", AutorLivro ="Uncle Bob", AnoLivro = 2000,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" },
        //    new(){ IdLivro = Guid.CreateVersion7(), TituloLivro = "Arquitetura Limpa", AutorLivro ="Uncle Bob", AnoLivro = 2019,EditoraLivro= "Alta books", GeneroLivro = "Tecnologia" }
        //};

        List<Guid> guidsV4 = new();
        for (int i = 1; i <= 5; i++)
        {
            var guid = Guid.NewGuid();
            guidsV4.Add(guid);
            Console.WriteLine($"{guid} - versao {guid.Version}");
            //Thread.Sleep(1000);
        }

        List<Guid> guidsV7 = new();
        for (int i = 1; i <= 5; i++)
        {
            var guid = Guid.CreateVersion7();
            guidsV7.Add(guid);
            Console.WriteLine($"{guid} - versao {guid.Version}");
            //Thread.Sleep(1000);
        }

        Console.WriteLine("*** Resultados da serializacao com a Versão do GUID V4 ***");

        Console.WriteLine();
        Console.WriteLine(JsonSerializer.Serialize(guidsV4.Order()));
        
        Console.WriteLine();

        Console.WriteLine("*** Resultados da serializacao COM a Versão Nova do GUID Guid.CreateVersion7() ***");
      
        Console.WriteLine();
        Console.WriteLine(JsonSerializer.Serialize(guidsV7.Order()));
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
