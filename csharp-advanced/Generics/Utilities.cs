namespace CSharp
{
    // where T : IComparable  ----> Interface
    // where T : Product      ----> Class
    // where T : struct       -----> Value type
    // where T : class        -----> reference type
    // where T : new()        ------> default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a  > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}