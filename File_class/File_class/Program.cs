using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main()
    {
        String path = "demo.txt";

        File.WriteAllText(path, "Hello world"); // write to file

        String data = File.ReadAllText(path);
        Console.WriteLine(data); // read from file

        File.AppendAllText(path, "\n this is the append line added into to the file.");

        if (File.Exists(path))
        {
            Console.WriteLine("File exists");
        }
        else
        {
            Console.WriteLine("File Not exists");
        }


    }

}