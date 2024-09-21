using BenchmarkDotNet.Running;

namespace Benchmark;

internal class Program
{
    static void Main(string[] args)
    {
        //var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
        //var summary = BenchmarkRunner.Run<MapperBenchmark>();

        // OR

        var switcher = new BenchmarkSwitcher(new[] {
            typeof(MemoryBenchmarkerDemo),
            typeof(MyBenchmarkExample)
        });

        switcher.Run(args);
    }
}