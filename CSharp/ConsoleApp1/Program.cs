using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* para ver el resultado ejecutar 
             * Ubicado en la carpeta de la solución
             * dotnet run -p ConsoleApp1.csproj -c Release
             * */

            //var summary = BenchmarkRunner.Run<CompareIndexAndSubstring>();
            //var summary = BenchmarkRunner.Run<CompareStringCreation>();
            //var summary = BenchmarkRunner.Run<CompareStringConcatenation>();
            //var summary = BenchmarkRunner.Run<LongStringCreation>();
            var summary = BenchmarkRunner.Run<GetElementFromCollection>();

        }

    }
}
