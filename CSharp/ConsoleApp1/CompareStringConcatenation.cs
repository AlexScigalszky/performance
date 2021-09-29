using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Text;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class CompareStringConcatenation
    {

        readonly string TextOne = "123123123123123";
        readonly string TextTwo = "123123123123123";

        [Benchmark]
        public string UsePlus()
        {
            return TextOne + TextTwo;
        }

        [Benchmark]
        public string UseStringConcat()
        {
            return string.Concat(TextOne, TextTwo);
        }

        [Benchmark]
        public string UseStringJoin()
        {
            return string.Join(TextOne, TextTwo);
        }

        [Benchmark]
        public string UseStringFormat()
        {
            return string.Format("{0}{1}", TextOne, TextTwo);
        }

        [Benchmark]
        public string UseStringInterpolation()
        {
            return $"{TextTwo}{TextTwo}";
        }

        [Benchmark]
        public string UseStringBuilder()
        {
            return new StringBuilder()
                .Append(TextOne)
                .Append(TextTwo)
                .ToString();
        }

    }
}
