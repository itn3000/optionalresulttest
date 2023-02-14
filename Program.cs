using System;
using System.Threading.Tasks;
namespace optionalresulttest
{
    public interface IResult<T, TErr>
    {
        bool IsOk();
        bool TryGet(out T value);
        bool TryGetError(out TErr value);
    }
    // class or struct?
    public struct Ok<T, TErr>: IResult<T, TErr>
    {
        internal Ok(T value)
        {
            _Value = value;
        }
        readonly T _Value;
        public bool IsOk() => true;
        public bool TryGet(out T value)
        {
            value = _Value;
            return true;
        }
        public bool TryGetError(out TErr value)
        {
            value = default;
            return false;
        }
        internal T Get() => _Value;
    }
    public struct Err<T, TErr>: IResult<T, TErr>
    {
        internal Err(TErr e)
        {
            _Error = e;
        }
        readonly TErr _Error;
        public bool IsOk() => false;
        public bool TryGet(out T value)
        {
            value = default;
            return false;
        }
        public bool TryGetError(out TErr value)
        {
            value = _Error;
            return true;
        }
        internal TErr Get() => _Error;
    }
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
