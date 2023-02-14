using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static IResult<T, Exception> From<T>(Func<T> generator)
    {
        try
        {
            var ret = generator();
            return new Ok<T, Exception>(ret);
        }
        catch (Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T>(Func<Task<T>> generator)
    {
        try
        {
            var ret = await generator().ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch (Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1>(
        Func<TArg1, T> f,
        TArg1 arg1
        )
    {
        try
        {
            var ret = f(arg1);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1>(
        Func<TArg1, Task<T>> f,
        TArg1 arg1
        )
    {
        try
        {
            var ret = await f(arg1).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2>(
        Func<TArg1, TArg2, T> f,
        TArg1 arg1, TArg2 arg2
        )
    {
        try
        {
            var ret = f(arg1, arg2);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2>(
        Func<TArg1, TArg2, Task<T>> f,
        TArg1 arg1, TArg2 arg2
        )
    {
        try
        {
            var ret = await f(arg1, arg2).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3>(
        Func<TArg1, TArg2, TArg3, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3>(
        Func<TArg1, TArg2, TArg3, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4>(
        Func<TArg1, TArg2, TArg3, TArg4, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4>(
        Func<TArg1, TArg2, TArg3, TArg4, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4, TArg5>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4, arg5);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4, TArg5>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4, arg5, arg6);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static IResult<T, Exception> From<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, T> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9
        )
    {
        try
        {
            var ret = f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
    public static async Task<IResult<T, Exception>> FromAsync<T, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
        Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, Task<T>> f,
        TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9
        )
    {
        try
        {
            var ret = await f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9).ConfigureAwait(false);
            return new Ok<T, Exception>(ret);
        }
        catch(Exception e)
        {
            return new Err<T, Exception>(e);
        }
    }
}