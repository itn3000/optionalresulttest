namespace optionalresulttest;

public interface IOptional<T>
{
    bool IsOk();
    bool TryGet(out T ret);
}

public class Some<T>: IOptional<T>
{
    T _Value;
    public Some(T value)
    {
        _Value = value;
    }

    public bool IsOk() => true;

    public bool TryGet(out T ret)
    {
        ret = _Value;
        return true;
    }
    public T Get() => _Value;
}

public class None<T> : IOptional<T>
{
    public bool IsOk() => false;

    public bool TryGet(out T ret)
    {
        ret = default;
        return false;
    }
}

public static partial class Optional
{
    public static IOptional<T> Some<T>(T value) => new Some<T>(value);
    public static IOptional<T> None<T>() => new None<T>();
    public static (bool isOk, T value) Unwrap<T>(this IOptional<T> o)
    {
        var isOk = o.TryGet(out var ret);
        return (isOk, ret);
    }
    public static T UnwrapOr<T>(this IOptional<T> o, T alternative)
    {
        if(o.TryGet(out var ret))
        {
            return ret;
        }
        else
        {
            return alternative;
        }
    }
}