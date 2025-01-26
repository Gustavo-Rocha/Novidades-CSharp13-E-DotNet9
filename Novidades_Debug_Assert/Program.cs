using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Novidades_Debug_Assert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Testes com .NET 9 | Melhorias em Debug.Assert *****");

            Console.WriteLine();
            Console.WriteLine("Informe um numero inteiro positivo:");
            var input = Console.ReadLine();

            Debug.Assert(int.TryParse(input, out var number) && number > 0);

            Console.WriteLine();
            Console.WriteLine("Debug.Assert() nao produziu falha...");
        }
    }
}
