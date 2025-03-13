using System.Xml.Linq;

public static class AccumulateExtensions
{
    //given a collection and an operation to perform on each element of the collection, returns a new collection containing the result of applying that operation to each element of the input collection.
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection)
        {
            yield return func(item);
        }
    }
}