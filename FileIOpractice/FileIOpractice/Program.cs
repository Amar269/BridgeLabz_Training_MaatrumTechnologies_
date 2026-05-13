using System;
using System.IO;

class program
{
    static void Main()
    {
        string path = "newfile.txt";
       File.WriteAllText(path, "I am learning File I/O in C# step by step");
       File.AppendAllText(path, "\nThis is the first appended text ");
       string content = File.ReadAllText(path);
        string[] lines = File.ReadAllLines(path);
        Console.WriteLine("Reading line by line :\n");

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }







        //Console.WriteLine("The content of the file is :");

        //Console.WriteLine(content);



        //Console.WriteLine("File created and text written successfull");



    }
}