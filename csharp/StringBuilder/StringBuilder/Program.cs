// See https://aka.ms/new-console-template for more information

using System.Text;

var builder = new StringBuilder();

builder.Append('-', 10);
builder.AppendLine();
builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);

builder.Replace('-', '+');

builder.Remove(0, 10);

builder.Insert(0, new String('-', 10));

Console.WriteLine(builder);

Console.WriteLine("First char: " + builder[0]);