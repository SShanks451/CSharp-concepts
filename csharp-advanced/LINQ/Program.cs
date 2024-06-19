namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price > 10
                orderby b.Title
                select b.Title;

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 100)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                // Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            var book2 = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book2.Title);

            var book3 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Console.WriteLine(book3 == null);

            Console.WriteLine("---------------------------------------------------------------------------------");

            var book4 = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book4.Title + " " + book4.Price);

            var book5 = books.Last(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book5.Title + " " + book5.Price);

            Console.WriteLine("---------------------------------------------------------------------------------");

            var book6 = books.Skip(2).Take(3);
            foreach (var book in book6)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine("---------------------------------------------------------------------------------");

            var book7 = books.Max(b => b.Price);
            var book8 = books.Min(b => b.Price);
            Console.WriteLine(book7);
            Console.WriteLine(book8);

            Console.WriteLine("---------------------------------------------------------------------------------");

            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);
        }
    }
}