using System;
using System.IO;
class program
{
    static void Main()
    {
        string writetext = "hai this is a new concept";
        File.WriteAllText("filename.txt",writetext);

        String readtext = File.ReadAllText("filename.txt");
        Console.WriteLine(readtext);

    }
}
