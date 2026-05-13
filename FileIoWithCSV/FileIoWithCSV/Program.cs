using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class program
{
    static void Main()
    {
        string path = "students.csv";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Name , Age , City \n");

        }

        Console.WriteLine("enter number of stdudents : ");
        int n = int.Parse(Console.ReadLine());

        
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Enter ur name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter ur Age :");
            string age = Console.ReadLine();

            Console.WriteLine("Enter ur City:");
            string city = Console.ReadLine();

            string line = name + " ," + age + " , " + city;

            File.AppendAllText(path, line + "\n");

        }
        Console.WriteLine("\n CSV file created successfully");

        Console.WriteLine("\nData saved without deleting old data!");

    }
}