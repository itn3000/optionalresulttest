using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static IResult<TRet, TErr> Map<T, TErr, TRet>(this IResult<T, TErr> r, Func<T, TRet> f)
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet>(this IResult<T, TErr> r, Func<T, Task<TRet>> f)
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet>(this IResult<T, TErr> r, Func<TErr, TErrRet> f)
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet>(this IResult<T, TErr> r, Func<TErr, Task<TErrRet>> f)
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0>(
        this IResult<T, TErr> r, Func<T, TArg0, TRet> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0>(
        this IResult<T, TErr> r, Func<T, TArg0, Task<TRet>> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TErrRet> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0>(
        this IResult<T, TErr> r, Func<TErr, TArg0, Task<TErrRet>> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TRet> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TErrRet> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3, arg4));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3, arg4).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3, arg4));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3, arg4).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3, arg4, arg5));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3, arg4, arg5));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false));
        }
    }
    public static IResult<TRet, TErr> Map<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static async Task<IResult<TRet, TErr>> MapAsync<T, TErr, TRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<T, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<TRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<TRet, TErr>(await f(ret, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false));
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<TRet, TErr>(e);
        }
    }
    public static IResult<T, TErrRet> MapErr<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TErrRet> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>(ret);
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
        }
    }
    public static async Task<IResult<T, TErrRet>> MapErrAsync<T, TErr, TErrRet, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<TErrRet>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return new Ok<T, TErrRet>();
        }
        else
        {
            r.TryGetError(out var e);
            return new Err<T, TErrRet>(await f(e, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false));
        }
    }
}