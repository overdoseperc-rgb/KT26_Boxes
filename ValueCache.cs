public class ValueCache<T> where T : struct
{
    private T? item;

    public void Set(T value)
    {
        item = value;
    }

    public bool TryGet(out T? value)
    {
        value = item;
        return item.HasValue;
    }
}
