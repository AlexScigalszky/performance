using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CompareIndexAndSubstring>();
        }

    }
}
