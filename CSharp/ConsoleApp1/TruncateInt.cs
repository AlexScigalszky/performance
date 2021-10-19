using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class TruncateInt
    {
        [Params(1, 12, 123, 123456789)]
        public int Number { get; set; }

        [Params(1, 1, 2, 12)]
        public int ResultLength { get; set; }

        [Benchmark]
        public string UseToStringAndSubstring()
        {
            try
            {
                string numberString = Number.ToString();
                if (numberString.Length > ResultLength)
                {
                    numberString = numberString.Substring(numberString.Length - ResultLength, ResultLength);
                }

                return numberString;
            }
            catch
            {
                throw;
            }
        }

        [Benchmark]
        public string UsePowAndMod()
        {
            return (Number % Math.Pow(10, ResultLength)).ToString();
        }
    }
}
