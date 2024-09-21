using BenchmarkDotNet.Attributes;

namespace Benchmark;

[MemoryDiagnoser]
public class MyBenchmarkExample
{
    [Params(100, 1000, 10000)]
    public int DataSize;

    private int[] data;

    [GlobalSetup]
    public void GlobalSetup()
    {
        // Initialize data
        data = new int[DataSize];

        // Populate data with random values
        new Random().NextBytes(new byte[DataSize * sizeof(int)]);
    }

    [Benchmark]
    public void MethodToBenchmark()
    {   
        // Code to benchmark
        int sum = 0;

        for (int i = 0; i < DataSize; i++)
        {
            sum += data[i];
        }
    }

    [Benchmark]
    public void MemoryConsumingMethod()
    {
        // Memory-consuming code
        byte[] newArray = new byte[DataSize * 2];
    }
}