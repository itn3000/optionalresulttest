namespace optionalresulttest;

public abstract class Result<T, TErr>
{
    internal Result(){}
    abstract public bool IsOk();

}
// class or struct?
public sealed class Ok<T, TErr> : Result<T, TErr>
{
    internal Ok(T value)
    {
        _Value = value;
    }
    T _Value;
    public T Reset(T newValue)
    {
        var oldValue = _Value;
        _Value = newValue;
        return oldValue;
    }
    public override bool IsOk() => true;
    public T Get() => _Value;
}
public sealed class Err<T, TErr> : Result<T, TErr>
{
    internal Err(TErr e)
    {
        _Error = e;
    }
    TErr _Error;
    public override bool IsOk() => false;
    public TErr Reset(TErr e)
    {
        var oldValue = _Error;
        _Error = e;
        return oldValue;
    }
    public TErr Get() => _Error;
}
