public class ReferenceBox<T> where T : class
{
    private T? value;

    public bool IsEmpty
    {
        get { return value == null; }
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
