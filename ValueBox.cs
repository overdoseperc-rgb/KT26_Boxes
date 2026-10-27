public class ValueBox<T> where T : struct
{
    private T? value;

    public bool IsEmpty
    {
        get { return !value.HasValue; }
    }

    public void Set(T item)
    {
        value = item;
    }

    public T? Get()
    {
        return value;
    }
}
