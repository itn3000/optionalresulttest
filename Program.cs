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
            // map, switch ok
            switch(Result.From<int>(() => 0).Map(x => x.ToString()).MapErr(e => e.Message))
            {
                case Ok<string, string> x:
                    Console.WriteLine($"ok2: {x.Get()}");
                    break;
                case Err<string, string> x:
                    Console.WriteLine($"ng2: {x.Get()}");
                    break;
            }
            // map, switch ng
            switch(Result.From<int>(() => throw new Exception("hogehoge")).Map(x => x.ToString()).MapErr(e => e.Message))
            {
                case Ok<string, string> x:
                    Console.WriteLine($"ok3: {x.Get()}");
                    break;
                case Err<string, string> x:
                    Console.WriteLine($"ng3: {x.Get()}");
                    break;
            }
            // switch method ok
            Console.WriteLine("switch method: {0}", Result.From<int>(() => 0).Switch(x => x.ToString("x02"), e => e.ToString(), null));
            // switch method ng
            Console.WriteLine("switch method: {0}", Result.From<int>(() => throw new Exception("switch exception")).Switch(x => x.ToString("x02"), e => e.ToString(), null));
        }
        static void Main(string[] args)
        {
            ResultTest();
            OptionalTest();
        }
    }
}
