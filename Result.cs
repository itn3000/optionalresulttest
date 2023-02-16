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
        if (r.TryGet(out var ret))
        {
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
        if (r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            return alternative;
        }
    }
    public static TRet Switch<T, TErr, TRet>(this IResult<T, TErr> r, Func<T, TRet> fOk, Func<TErr, TRet> fErr, Func<IResult<T, TErr>, TRet> fOther)
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get());
            case Err<T, TErr> x:
                return fErr(x.Get());
            default:
                if (fOther != null)
                {
                    return fOther(r);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
}
