namespace optionalresulttest;

public abstract class Optional<T>
{
    internal Optional(){}
    public abstract bool IsOk();
}

public class Some<T>: Optional<T>
{
    T _Value;
    public Some(T value)
    {
        _Value = value;
    }

    public override bool IsOk() => true;
    public T Get() => _Value;
}

public class None<T> : Optional<T>
{
    public override bool IsOk() => false;
    internal static readonly None<T> Instance = new None<T>();
}

public static partial class Optional
{
    public static Optional<T> Some<T>(T value) => new Some<T>(value);
    public static Optional<T> None<T>() => optionalresulttest.None<T>.Instance;
    public static (bool isOk, T? value) Unwrap<T>(this Optional<T> o)
    {
        switch(o)
        {
            case Some<T> x:
                return (true, x.Get());
            default:
                return (false, default);
        }
    }
    public static T UnwrapOr<T>(this Optional<T> o, T alternative)
    {
        switch(o)
        {
            case Some<T> x:
                return x.Get();
            default:
                return alternative;
        }
    }
    public static Optional<TRet> Map<T, TRet>(this Optional<T> o, Func<T, TRet> f)
    {
        return o switch {
            Some<T> x => Optional.Some(f(x.Get())),
            _ => Optional.None<TRet>()
        };
    }
    public static TRet Switch<T, TRet>(this Optional<T> o, Func<T, TRet> fSome, Func<TRet> fNone)
    {
        return o switch {
            Some<T> x => fSome(x.Get()),
            _ => fNone(),
        };
    }
}