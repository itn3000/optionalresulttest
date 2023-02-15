using System;
using System.Threading.Tasks;
namespace optionalresulttest
{
    class Program
    {
        static void OptionalTest()
        {
            var o1 = Optional.Some(1).Unwrap();
            Console.WriteLine(o1.ToString());
            var o2 = Optional.None<int>().Unwrap();
            Console.WriteLine(o2.ToString());
            // switch some
            var o3 = Optional.Some(2);
            var str1 = o3 switch {
                Some<int> s1 => $"some: {s1.Get()}",
                None<int> n1 => $"none",
                _ => throw new NotImplementedException()
            };
            Console.WriteLine(str1);
            // switch none
            var o4 = Optional.None<int>();
            var str2 = o4 switch {
                Some<int> s1 => $"some: {s1.Get()}",
                None<int> n1 => $"none",
                _ => throw new NotImplementedException()
            };
            Console.WriteLine(str2);
        }
        static void ResultTest()
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
            // unwrap or else
            var v4 = Result.From<int>(() => throw new Exception("unwraporelse")).UnwrapOrElse(e => 0);
            Console.WriteLine($"v4: {v4}");
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
        static void Main(string[] args)
        {
            ResultTest();
            OptionalTest();
        }
    }
}
