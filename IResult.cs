namespace optionalresulttest;

public interface IResult<T, TErr>
{
    bool IsOk();
}
// class or struct?
public class Ok<T, TErr> : IResult<T, TErr>
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
    public bool IsOk() => true;
    public T Get() => _Value;
}
public class Err<T, TErr> : IResult<T, TErr>
{
    internal Err(TErr e)
    {
        _Error = e;
    }
    TErr _Error;
    public bool IsOk() => false;
    public TErr Reset(TErr e)
    {
        var oldValue = _Error;
        _Error = e;
        return oldValue;
    }
    public TErr Get() => _Error;
}
