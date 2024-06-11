// See https://aka.ms/new-console-template for more information

var random = new Random();

/*
for (var i = 0; i < 10; i++)
{
    Console.WriteLine(random.Next());
}
*/

/*
for (var i = 0; i < 10; i++)
{
    Console.WriteLine(random.Next(1, 10));
}
*/

/*
for (var i = 0; i < 10; i++)
{
    Console.Write((char)random.Next(97, 122));
}
Console.WriteLine();
*/

/*
for (var i = 0; i < 10; i++)
{
    Console.Write((char)('a' + random.Next(0, 26)));
}
Console.WriteLine();
*/

/*
const int passwordLength = 10;
var buffer = new char[passwordLength];
for (var i = 0; i < passwordLength; i++)
{
    buffer[i] = (char)('a' + random.Next(0, 26));
}
var password = new string(buffer);
Console.WriteLine(password);
*/