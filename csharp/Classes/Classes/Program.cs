using Classes.Math;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}