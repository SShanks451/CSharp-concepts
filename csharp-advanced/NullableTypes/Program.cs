namespace NullableTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Nullable<DateTime> date = null;
            /*
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault() " + date.GetValueOrDefault());
            Console.WriteLine("HasValue " + date.HasValue);
            Console.WriteLine("Value " + date.Value);
            */

            /*
            DateTime? date = new DateTime(2014, 1, 1);
            DateTime? date2 = date.GetValueOrDefault();
            Console.WriteLine(date2);
            */

            /*
            DateTime? date = new DateTime(2014, 1, 1);
            DateTime? date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;
            Console.WriteLine(date3);
            */

            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            DateTime? date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date2);
            Console.WriteLine(date3);
        }
    }
}