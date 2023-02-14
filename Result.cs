using System;
using System.Threading.Tasks;
using System.Threading;
namespace optionalresulttest;
public static partial class Result
{
    public static IResult<T, TErr> Ok<T, TErr>(T v) => new Ok<T, TErr>(v);
    public static IResult<T, TErr> Err<T, TErr>(TErr e) => new Err<T, TErr>(e);
    public static (T v, TErr e) Unwrap<T, TErr>(this IResult<T, TErr> r)
    {
        if (r.IsOk())
        {
            r.TryGet(out var ret);
            return (ret, default);
        }
        else
        {
            r.TryGetError(out var e);
            return (default, e);
        }
    }
    public static T UnwrapOr<T, TErr>(this IResult<T, TErr> r, T alternative)
    {
        if (r.IsOk())
        {
            r.TryGet(out var ret);
            return ret;
        }
        else
        {
            return alternative;
        }
    }
}
