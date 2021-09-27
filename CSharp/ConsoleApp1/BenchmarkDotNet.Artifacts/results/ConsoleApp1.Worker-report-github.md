``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1237 (21H1/May2021Update)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.401
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT
  Job-OWEOCX : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT

IterationCount=100  LaunchCount=10  RunStrategy=Monitoring  
WarmupCount=0  

```
|            Method |       Mean |     Error |     StdDev |     Median | Rank |
|------------------ |-----------:|----------:|-----------:|-----------:|-----:|
|          UseIndex | 2,041.6 ns | 218.30 ns | 2,091.7 ns | 1,500.0 ns |    2 |
| UseIndexWithChart |   371.1 ns |  59.88 ns |   573.8 ns |   300.0 ns |    1 |
|      UseSubstring | 1,950.8 ns | 137.95 ns | 1,321.8 ns | 1,500.0 ns |    2 |
