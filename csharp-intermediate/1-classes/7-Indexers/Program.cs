namespace CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cookie = new HTTPCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }
    }
}