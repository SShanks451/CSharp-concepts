// See https://aka.ms/new-console-template for more information

/*
int hour = 10;

if(hour > 0 && hour < 12)
{
    Console.WriteLine("Its morning");
}else if(hour >= 12 && hour<18)
{
    Console.WriteLine("Its afternoon");
}else
{
    Console.WriteLine("Its evening");
}
*/

/*
bool isGoldCustomer = true;
float price = (isGoldCustomer) ? 19.95f : 29.95f;
Console.WriteLine(price);
*/


namespace If_else_and_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn");
                    break;

                case Season.Summer:
                    Console.WriteLine("Its summer");
                    break;

                default:
                    Console.WriteLine("I don't know");
                    break;
            }
        }
    }
}