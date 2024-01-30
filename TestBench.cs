using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
  [Benchmark]
  public int Test1()
  {
    return 0;
  }

  [Benchmark]
  public int Test2()
  {
      return 0;
  }

  [Benchmark]
  public int Test3()
  {
      return 0;
  }
}
