using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System.Text;

namespace ConsoleApp1
{
    //[MemoryDiagnoser]
    [SimpleJob(RunStrategy.Monitoring, launchCount: 10, warmupCount: 0, targetCount: 100)]
    [RankColumn]
    public class LongStringCreation
    {
        readonly string Text1 = "123";
        readonly string Text2 = "123";
        readonly string Text3 = "123";
        readonly string Text4 = "123";
        readonly string Text5 = "123";
        readonly string Text6 = "123";
        readonly string Text7 = "123";
        readonly string Text8 = "123";
        readonly string Text9 = "123";
        readonly string Text10 = "123";
        readonly string Text11 = "123";
        readonly string Text12 = "123";
        readonly string Text13 = "123";
        readonly string Text14 = "123";
        readonly string Text15 = "123";
        readonly string Text16 = "123";
        readonly string Text17 = "123";
        readonly string Text18 = "123";
        readonly string Text19 = "123";
        readonly string Text20 = "123";

        [Benchmark]
        public string UsePlus()
        {
            return Text1 +
                    Text2 +
                    Text3 +
                    Text4 +
                    Text5 +
                    Text6 +
                    Text7 +
                    Text8 +
                    Text9 +
                    Text10 +
                    Text11 +
                    Text12 +
                    Text13 +
                    Text14 +
                    Text15 +
                    Text16 +
                    Text17 +
                    Text18 +
                    Text19 +
                    Text20;
        }

        [Benchmark]
        public string UseStringConcat()
        {
            return string.Concat(Text1,
                    Text2,
                    Text3,
                    Text4,
                    Text5,
                    Text6,
                    Text7,
                    Text8,
                    Text9,
                    Text10,
                    Text11,
                    Text12,
                    Text13,
                    Text14,
                    Text15,
                    Text16,
                    Text17,
                    Text18,
                    Text19,
                    Text20);
        }

        [Benchmark]
        public string UseStringJoin()
        {
            return string.Join(Text1,
                    Text2,
                    Text3,
                    Text4,
                    Text5,
                    Text6,
                    Text7,
                    Text8,
                    Text9,
                    Text10,
                    Text11,
                    Text12,
                    Text13,
                    Text14,
                    Text15,
                    Text16,
                    Text17,
                    Text18,
                    Text19,
                    Text20);
        }

        [Benchmark]
        public string UseStringFormat()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}",
                     Text1,
                     Text2,
                     Text3,
                     Text4,
                     Text5,
                     Text6,
                     Text7,
                     Text8,
                     Text9,
                     Text10,
                     Text11,
                     Text12,
                     Text13,
                     Text14,
                     Text15,
                     Text16,
                     Text17,
                     Text18,
                     Text19,
                     Text20);
        }

        [Benchmark]
        public string UseStringInterpolation()
        {
            return $"{Text1}{Text2}{Text3}{Text4}{Text5}{Text6}{Text7}{Text8}{Text9}{Text10}{Text11}{Text12}{Text13}{Text14}{Text15}{Text16}{Text17}{Text18}{Text19}{Text20}";
        }

        [Benchmark]
        public string UseStringBuilder()
        {
            return new StringBuilder()
                .Append(Text1)
                .Append(Text2)
                .Append(Text3)
                .Append(Text4)
                .Append(Text5)
                .Append(Text6)
                .Append(Text7)
                .Append(Text8)
                .Append(Text9)
                .Append(Text10)
                .Append(Text11)
                .Append(Text12)
                .Append(Text13)
                .Append(Text14)
                .Append(Text15)
                .Append(Text16)
                .Append(Text17)
                .Append(Text18)
                .Append(Text19)
                .Append(Text20)
                .ToString();
        }
    }
}
