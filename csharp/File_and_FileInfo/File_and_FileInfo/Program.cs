﻿// See https://aka.ms/new-console-template for more information

var path = @"c:\somefile.jpg";

File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
File.Delete(path);
if (File.Exists(path))
{
    //
}
var content = File.ReadAllText(path);

var fileInfo = new FileInfo(path);
fileInfo.CopyTo("...");
fileInfo.Delete();
if(fileInfo.Exists)
{
    //
}