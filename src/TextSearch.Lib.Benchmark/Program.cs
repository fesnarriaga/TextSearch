using BenchmarkDotNet.Running;
using TextSearch.Lib.Benchmark;

var summary = BenchmarkRunner.Run<SearchBenchmark>();

Console.WriteLine(summary.ToString());