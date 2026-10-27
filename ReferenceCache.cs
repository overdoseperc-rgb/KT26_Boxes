public class ReferenceCache<T> where T : class
{
    private T? item;

    public void Set(T value)
    {
        item = value;
    }

    public bool TryGet(out T? value)
    {
        value = item;
        return item != null;
    }
}
