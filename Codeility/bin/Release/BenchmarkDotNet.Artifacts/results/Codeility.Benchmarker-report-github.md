``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4341.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4341.0), X86 LegacyJIT


```
|                             Method |               Mean |            Error |           StdDev | Ratio |
|----------------------------------- |-------------------:|-----------------:|-----------------:|------:|
|                SolutionRunnerNaive | 6,806,391,933.3 ns | 39,883,001.48 ns | 37,306,584.33 ns | 1.000 |
|          SolutionRunnerBetterRange |       328,222.7 ns |      2,212.40 ns |      1,847.46 ns | 0.000 |
|         SolutionRunnerBetterSearch |           661.2 ns |         11.36 ns |         10.07 ns | 0.000 |
| SolutionRunnerBetterSearchAndRange |           686.9 ns |         13.61 ns |         14.57 ns | 0.000 |
