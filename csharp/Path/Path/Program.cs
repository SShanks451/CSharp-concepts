// See https://aka.ms/new-console-template for more information

var path = @"D:\deltax\csharp\Strings\Strings.sln";

var dotIndex = path.IndexOf(".");
var extension = path.Substring(dotIndex);

Console.WriteLine("Extension: " + Path.GetExtension(path)); 
Console.WriteLine("File Name: " + Path.GetFileName(path)); 
Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path)); 
Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path)); 
