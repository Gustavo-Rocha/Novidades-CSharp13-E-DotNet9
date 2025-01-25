using System.Text.Json;

namespace Melhorias_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Novidades do .NET 9: melhorias no tipo TimeSpan");

            string[] amostrasTempo = ["71.715", "71.716", "71.829", "71.830", "71.832"];
            foreach (var amostra in amostrasTempo)
            {
                Console.WriteLine();
                var amostraSegundos = JsonSerializer.Deserialize<double>(amostra);
                Console.WriteLine($"Tempo em segundos = {amostra}");
                Console.WriteLine($"Tempo em segundos (double) = {amostraSegundos}");
                var amostraTimeSpan = TimeSpan.FromSeconds(value: amostraSegundos);
                Console.WriteLine($"Tempo em segundos (TimeSpan) = {amostraTimeSpan} | TimeSpan.FromSeconds(value)");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nova Sobrecarga DE TIME SPAN recebendo valores Int");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var amostra in amostrasTempo)
            {
                Console.WriteLine();
                var valorAmostra = JsonSerializer.Deserialize<double>(amostra);
                Console.WriteLine($"Tempo em segundos = {amostra}");
                Console.WriteLine($"Tempo em segundos (double) = {valorAmostra}");
                TimeSpan amostraTimeSpan;
                amostraTimeSpan = TimeSpan.FromSeconds(value: valorAmostra);
                Console.WriteLine($"Tempo em segundos (TimeSpan) = {amostraTimeSpan} | TimeSpan.FromSeconds(value)");

                var partesAmostra = amostra.Split('.');
                var amostraSegundos = long.Parse(partesAmostra[0]);
                Console.WriteLine($"Segundos (long) = {amostraSegundos}");
                var amostraMilissegundos = long.Parse(partesAmostra[1]);
                Console.WriteLine($"Milissegundos (long) = {amostraMilissegundos}");
                amostraTimeSpan = TimeSpan.FromSeconds(
                    seconds: amostraSegundos, milliseconds: amostraMilissegundos);
                Console.WriteLine(
                    $"Tempo em segundos (TimeSpan) = {amostraTimeSpan} | TimeSpan.FromSeconds(seconds, milliseconds)");
            }

        }
    }
}
