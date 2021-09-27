using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class CompareIndexAndSubstring
    {

        readonly string Text = "123123123123123";

        [Benchmark]
        public bool UseIndex()
        {
            return Text[0].ToString() == "1";
        }

        [Benchmark]
        public bool UseIndexWithChart()
        {
            return Text[0] == '1';
        }

        [Benchmark]
        public bool UseSubstring()
        {
            return Text.Substring(0, 1) == "1";
        }
    }
}
