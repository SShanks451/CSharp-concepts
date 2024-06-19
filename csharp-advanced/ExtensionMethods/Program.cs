namespace ExtensionMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string post = "this i supposed to be a very long string fesgdbniusdbgniusbhiudsgsdf fsddddddd g...............";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 1,5,3 };
            Console.WriteLine(numbers.Max()); 
        }
    }
    
}