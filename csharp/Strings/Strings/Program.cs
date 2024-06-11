// See https://aka.ms/new-console-template for more information

var firstName = "Mosh";
var lastName = "Hamedani";

var fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
Console.WriteLine(myFullName);

var names = new string[3] { "John", "Jack", "Mary" };
var formattedNames = string.Join(",", names);
Console.WriteLine(formattedNames);

var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

Console.WriteLine(text);