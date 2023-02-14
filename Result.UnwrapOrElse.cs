using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static T UnwrapOrElse<T, TErr>(this IResult<T, TErr> r, Func<TErr, T> f)
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr>(this IResult<T, TErr> r, Func<TErr, Task<T>> f)
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0>(
        this IResult<T, TErr> r, Func<TErr, TArg0, T> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0>(
        this IResult<T, TErr> r, Func<TErr, TArg0, Task<T>> f,
        TArg0 arg0
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, T> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, Task<T>> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3, arg4);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3, arg4).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3, arg4, arg5);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false);
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this IResult<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        if(r.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            r.TryGetError(out var er);
            return await f(er, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false);
        }
    }
}