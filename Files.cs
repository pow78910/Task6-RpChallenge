using System;


class Files()
{
     public static void OutputFile(string path)
    {
       string fileText = File.ReadAllText(@path) ; 
       Console.WriteLine($"\n{fileText}");
    }
}
