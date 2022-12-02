using System.Collections;

namespace Common
{
    public static class CollectionHelper
    {
        public static ICollection<T> AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
            return collection;
        }
        public static ICollection<T> Reset<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            collection.Clear();
            collection.AddRange(items);
            return collection;
        }
        public static Stack<T> AddRange<T>(this Stack<T> stack, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
            return stack;
        }
        public static Stack<T> Reset<T>(this Stack<T> stack, IEnumerable<T> items)
        {
            stack.Clear();
            stack.AddRange(items);
            return stack;
        }
    }
}
