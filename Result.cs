using System;
using System.Threading.Tasks;
using System.Threading;
namespace optionalresulttest;
public static partial class Result
{
    public static IResult<T, TErr> Ok<T, TErr>(T v) => new Ok<T, TErr>(v);
    public static IResult<T, TErr> Err<T, TErr>(TErr e) => new Err<T, TErr>(e);
    public static (T? v, TErr? e) Unwrap<T, TErr>(this IResult<T, TErr> r)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return (x.Get(), default);
            case Err<T, TErr> x:
                return (default, x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOr<T, TErr>(this IResult<T, TErr> r, T alternative)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            default:
                return alternative;
        }
    }
}
