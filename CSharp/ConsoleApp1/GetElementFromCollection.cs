using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class GetElementFromCollection
    {
        private ICollection<string> _list;
        private ICollection<string> _array;

        public GetElementFromCollection()
        {
            _list = new List<string>()
            {
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
            };

            _array = new string[]
            {
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
                "elem","elem","elem","elem","elem","elem","elem",
            };
        }

        [Benchmark]
        public string UseElementAtFromList()
        {
            return _list.ElementAt(3);
        }

        [Benchmark]
        public string UseElementAtFromArray()
        {
            return _list.ElementAt(3);
        }

        [Benchmark]
        public string UseBracketFromList()
        {
            return _list.ToArray()[3];
        }

        [Benchmark]
        public string UseBracketFromArray()
        {
            return _array.ToArray()[3];
        }

    }
}
