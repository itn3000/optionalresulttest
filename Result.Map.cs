using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static IResult<TRet, TErr> Map<T, TErr, TRet>(this IResult<T, TErr> r, Func<T, TRet> f)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get()));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet>(this IResult<T, TErr> r, Func<T, Task<TRet>> f)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get()).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0>(
        this IResult<T, TErr> r, Func<T, TArg0, TRet> f,
        TArg0 arg0
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0>(
        this IResult<T, TErr> r, Func<T, TArg0, Task<TRet>> f,
        TArg0 arg0
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TRet> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3, arg4));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3, arg4).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return new Ok<TRet, TErr>(await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false));
            case Err<T, TErr> x:
                return new Err<TRet, TErr>(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
}