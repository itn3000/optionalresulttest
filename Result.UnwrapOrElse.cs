using System;
using System.Threading.Tasks;
namespace optionalresulttest;

public static partial class Result
{
    public static T UnwrapOrElse<T, TErr>(this Result<T, TErr> r, Func<TErr, T> f)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get());
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr>(this Result<T, TErr> r, Func<TErr, Task<T>> f)
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return await f(x.Get()).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0>(
        this Result<T, TErr> r, Func<TErr, TArg0, T> f,
        TArg0 arg0
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0>(
        this Result<T, TErr> r, Func<TErr, TArg0, Task<T>> f,
        TArg0 arg0
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, T> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, Task<T>> f,
        TArg0 arg0, TArg1 arg1
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3, arg4);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3, arg4).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
    public static T UnwrapOrElse<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, T> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
                return f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            default:
                throw new NotImplementedException();
        }
    }
    public static async Task<T> UnwrapOrElseAsync<T, TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this Result<T, TErr> r, Func<TErr, TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Task<T>> f,
        TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8
        )
    {
        switch(r)
        {
            case Ok<T, TErr> x:
                return x.Get();
            case Err<T, TErr> x:
               return await f(x.Get(), arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8).ConfigureAwait(false);
            default:
                throw new NotImplementedException();
        }
    }
}