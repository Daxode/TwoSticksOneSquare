``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4341.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4341.0), X86 LegacyJIT


```
|              Method |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| SolutionRunnerNaive | 473.0 ns | 8.70 ns | 7.27 ns |     - |     - |     - |         - |