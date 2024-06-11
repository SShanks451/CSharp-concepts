// See https://aka.ms/new-console-template for more information

Directory.CreateDirectory(@"d:\temp\fodler1");

var files = Directory.GetFiles(@"d:\deltax\csharp", "*.*", SearchOption.AllDirectories);
foreach (var file in files)
    Console.WriteLine(file);

var directories = Directory.GetDirectories(@"d:\deltax\csharp", "*.*", SearchOption.AllDirectories);
foreach (var directory in directories)
{
    Console.WriteLine(directory);
}

Directory.Exists("...");



var directoryInfo = new DirectoryInfo("...");
directoryInfo.GetFiles();
directoryInfo.GetDirectories();