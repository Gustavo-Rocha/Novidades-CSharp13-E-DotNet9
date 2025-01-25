using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //Novidades do .NET 9: melhorias em criptografia com CryptographicOperations.HashData()
        var content = Encoding.ASCII.GetBytes("IDLivro: 01949f27-335b-795a-9d41-5598121d5ca9, tituloLivro:Arquitetura Limpa ,autorLivro:Uncle Bob,anoLivro:2019,editoraLivro:Alta books,generoLivro:Tecnologia");

        Console.WriteLine("CriptoGrafia das Versões anteriores ao .NET9");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("*** Versoes one-shot usando tipos que representam algoritmos ***");
        Console.WriteLine("SHA256.HashData() = " + JsonSerializer.Serialize(SHA256.HashData(content)));
        Console.WriteLine("SHA384.HashData() = " + JsonSerializer.Serialize(SHA384.HashData(content)));
        Console.WriteLine("SHA512.HashData() = " + JsonSerializer.Serialize(SHA512.HashData(content)));
        Console.WriteLine("MD5.HashData() = " + JsonSerializer.Serialize(MD5.HashData(content)));


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" exemplos anteriores refatorados, já utilizando o método HashData de CryptographicOperations");
        Console.WriteLine("*** Testes com CryptographicOperations.HashData() ***");
        Console.WriteLine("HashAlgorithmName.SHA256 = " + JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA256, content)));
        Console.WriteLine("HashAlgorithmName.SHA384 = " + JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA384, content)));
        Console.WriteLine("HashAlgorithmName.SHA512 = " + JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA512, content)));
        Console.WriteLine("HashAlgorithmName.MD5 = " + JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.MD5, content)));
    }
}