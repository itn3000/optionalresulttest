using System;
using System.Threading.Tasks;
using System.Threading;
namespace optionalresulttest;
public static partial class Result
{
    public static Result<T, TErr> Ok<T, TErr>(T v) => new Ok<T, TErr>(v);
    public static Result<T, TErr> Err<T, TErr>(TErr e) => new Err<T, TErr>(e);
    public static (T? v, TErr? e) Unwrap<T, TErr>(this Result<T, TErr> r)
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
    public static T UnwrapOr<T, TErr>(this Result<T, TErr> r, T alternative)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            default:
                return alternative;
        }
    }
    public static TRet Switch<T, TErr, TRet>(this Result<T, TErr> r,
        Func<T, TRet> fOk, Func<TErr, TRet> fErr, Func<TRet>? fOther)
    {
        return r switch {
            Ok<T, TErr> x => fOk(x.Get()),
            Err<T, TErr> x => fErr(x.Get()),
            _ => fOther != null ? fOther() : throw new NotImplementedException()
        };
    }
}
