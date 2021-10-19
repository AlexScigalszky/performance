using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class CompareStringCreation
    {
        readonly char[] letters = { 'A', 'B', 'C' };

        [Benchmark]
        public string UseString()
        {
            var variable = "a new variable";
            return variable;
        }

        [Benchmark]
        public string UseSystemString()
        {
            System.String variable = "a new variable";
            return variable;
        }

        [Benchmark]
        public string UseVar()
        {
            var variable = "a new variable";
            return variable;
        }

        [Benchmark]
        public string UseConst()
        {
            const string variable = "a new variable";
            return variable;
        }


        [Benchmark]
        public string UseStringConstructor()
        {
            string variable = new string(letters);
            return variable;
        }
    }
}
