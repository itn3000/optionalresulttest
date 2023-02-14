namespace optionalresulttest;

public interface IResult<T, TErr>
{
    bool IsOk();
    bool TryGet(out T value);
    bool TryGetError(out TErr value);
}
// class or struct?
public class Ok<T, TErr> : IResult<T, TErr>
{
    public Ok()
    {
        _Value = default;
    }
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
    public bool TryGet(out T value)
    {
        value = _Value;
        return true;
    }
    public bool TryGetError(out TErr value)
    {
        value = default;
        return false;
    }
    public T Get() => _Value;
}
public class Err<T, TErr> : IResult<T, TErr>
{
    public Err()
    {
        _Error = default;
    }
    internal Err(TErr e)
    {
        _Error = e;
    }
    TErr _Error;
    public bool IsOk() => false;
    public bool TryGet(out T value)
    {
        value = default;
        return false;
    }
    public bool TryGetError(out TErr value)
    {
        value = _Error;
        return true;
    }
    public TErr Reset(TErr e)
    {
        var oldValue = _Error;
        _Error = e;
        return oldValue;
    }
    public TErr Get() => _Error;
}
