namespace Enums
{
    public enum ShipppingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            var method = ShipppingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShipppingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShipppingMethod)Enum.Parse(typeof(ShipppingMethod), methodName);
        }
    }
}