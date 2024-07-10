namespace CSharp
{
    public delegate void SampleDelegate();

    internal class Program
    {
        private static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;

            del();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One Invoked");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two Invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three Invoked");
        }
    }
}