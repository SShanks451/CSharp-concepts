namespace CSharp
{
    public delegate void HelloFunctionDelegate (string Message);

    internal class Program
    {
        private static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hi there");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}