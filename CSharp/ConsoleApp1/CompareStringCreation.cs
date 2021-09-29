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
        public void UseString()
        {
            string variable = "a new variable";
        }

        [Benchmark]
        public void UseSystemString()
        {
            System.String variable = "a new variable";
        }

        [Benchmark]
        public void UseVar()
        {
            var variable = "a new variable";
        }

        [Benchmark]
        public void UseConst()
        {
            const string variable = "a new variable";
        }


        [Benchmark]
        public void UseStringConstructor()
        {
            string alphabet = new string(letters);
        }
    }
}
