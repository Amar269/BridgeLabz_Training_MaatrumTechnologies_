using System;
using System.Collections;


class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        Console.WriteLine("Enter the NO of students :");
        int n = int.Parse(Console.ReadLine());

        for (int i =0; i < n; i++)
        {
            Console.WriteLine("Enter Your ID : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Marks : ");
            double marks = double.Parse(Console.ReadLine());


            list.Add(id);
            list.Add(name);
            list.Add(marks);
        }
        Console.WriteLine("The student Data : ");
        foreach (var item in list)
        {
            Console.Write(item);

        }

    }
    
    
    
}




