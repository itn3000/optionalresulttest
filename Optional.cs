namespace optionalresulttest;

public interface IOptional<T>
{
    bool IsOk();
}

public class Some<T>: IOptional<T>
{
    T _Value;
    public Some(T value)
    {
        _Value = value;
    }

    public bool IsOk() => true;
    public T Get() => _Value;
}

public class None<T> : IOptional<T>
{
    public bool IsOk() => false;
}

public static partial class Optional
{
    public static IOptional<T> Some<T>(T value) => new Some<T>(value);
    public static IOptional<T> None<T>() => new None<T>();
    public static (bool isOk, T? value) Unwrap<T>(this IOptional<T> o)
    {
        switch(o)
        {
            case Some<T> x:
                return (true, x.Get());
            default:
                return (false, default);
        }
    }
    public static T UnwrapOr<T>(this IOptional<T> o, T alternative)
    {
        switch(o)
        {
            case Some<T> x:
                return x.Get();
            default:
                return alternative;
        }
    }
}