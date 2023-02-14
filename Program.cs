using System;
using System.Threading.Tasks;
namespace optionalresulttest
{
    class Program
    {
        static void Main(string[] args)
        {
            // unwrap ok
            var (v, e) = Result.From(() => 1).Unwrap();
            Console.WriteLine($"v1: {v}, {e}");
            // unwrap err
            var v2 = Result.From<int>(() => throw new Exception("test exception1")).Unwrap();
            Console.WriteLine($"v2: {v2}");
            // map
            var v3 = Result.From(() => 1).Map((i, j) => $"{i}|{j}", 2).Unwrap();
            Console.WriteLine($"v3: {v3}");
            // switch, ok
            switch(Result.From(() => 1)) {
                case Ok<int, Exception> x:
                    Console.WriteLine($"ok: {x.Get()}");
                    break;
                case Err<int, Exception> x:
                    Console.WriteLine($"err: {x.Get()}");
                    break;
                default:
                    throw new NotImplementedException();
            }
            // switch, ng
            switch(Result.From<int>(() => throw new Exception("test exception2"))) {
                case Ok<int, Exception> x:
                    Console.WriteLine($"ok: {x.Get()}");
                    break;
                case Err<int, Exception> x:
                    Console.WriteLine($"err: {x.Get()}");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
