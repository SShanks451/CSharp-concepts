using System;

namespace CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            */

            var number = new Nullable<int>(5);
            Console.WriteLine("Has value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var num = new Nullable<int>();
            Console.WriteLine("Has value ?" + num.HasValue);
            Console.WriteLine("Value: " + num.GetValueOrDefault());

        }

        
    }
}