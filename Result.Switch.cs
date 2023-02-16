using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static TRet Switch<T, TErr, TRet, TArg0>(
        this IResult<T, TErr> r, Func<T, TArg0, TRet> fOk,
        Func<TErr, TArg0, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TRet> fOther,
        TArg0 arg0
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TRet> fOk,
        Func<TErr, TArg0, TArg1, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TRet> fOther,
        TArg0 arg0, TArg1 arg1
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TArg4, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3, arg4);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3, arg4);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3, arg4);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3, arg4, arg5);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
    public static TRet Switch<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRet> fOk,
        Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRet> fErr,
        Func<IResult<T, TErr>, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRet> fOther,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        switch (r)
        {
            case Ok<T, TErr> x:
                return fOk(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            case Err<T, TErr> x:
                return fErr(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            default:
                if (fOther != null)
                {
                    return fOther(r, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                }
                else
                {
                    throw new NotImplementedException();
                }
        }
    }
}