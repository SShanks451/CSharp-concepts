// See https://aka.ms/new-console-template for more information

/*
for (var i=1; i<=10; i++)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
for (var i = 10; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
var name = "John Smith";
foreach (var character in name)
{
    Console.WriteLine(character);
}

var numbres = new int[] { 1, 2, 3 };
foreach (var number in numbres)
{
    Console.WriteLine(number);
}
*/

/*
var j = 0;
while (j <= 10)
{
    if(j % 2 == 0)
        Console.WriteLine(j);
    
    j++;
}
*/

while (true)
{
    Console.Write("Type your name: ");
    var input = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("@Echo: " + input);
        continue;
    }

    break;
}
