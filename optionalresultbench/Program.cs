using BenchmarkDotNet.Attributes;
using optionalresulttest;
using BenchmarkDotNet.Running;

// See https://aka.ms/new-console-template for more information
BenchmarkRunner.Run<ResultTestBench>();

[MemoryDiagnoser]
public class ResultTestBench
{
    [Benchmark]
    public void SwitchType()
    {
        var _ = Result.From(() => 0) switch {
            Ok<int, Exception> x => x.Get(),
            Err<int, Exception> x => 0,
            _ => -1
        };
    }
    [Benchmark]
    public void TryGet()
    {
        var result = Result.From(() => 0);
        int ret;
        if(!result.TryGet(out ret))
        {
            ret = 0;
        }
    }
}