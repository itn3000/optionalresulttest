using System;
using System.Threading.Tasks;
namespace optionalresulttest
{
    class Program
    {
        static void Main(string[] args)
        {
            var (v, e) = Result.From(() => 1).Unwrap();
            Result.From(() => 1).Map((i, j) => $"{i}, {j}", 2);
            var v2 = Result.From<int>(() => throw new Exception("exception")).Unwrap();
            Console.WriteLine($"{v2}");
        }
    }
}
