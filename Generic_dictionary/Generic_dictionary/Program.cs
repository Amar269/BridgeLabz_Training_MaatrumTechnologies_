using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        Dictionary<string, int> Student = new Dictionary<string, int>();

        Student.Add("Amarnath", 157);
        Student.Add("Aditya", 18);


        Console.WriteLine("This is keyvalue pair acces in foreach loop : ");
        foreach (KeyValuePair<string,int> it in Student)
        {
            
            Console.WriteLine(it.Key + " : " + it.Value);

        }
        foreach(var item in Student)
        {
            Console.WriteLine(item.Key + " : " + item.Value);

        }

        // access by value
        Console.WriteLine(Student["Amarnath"]);
        Console.WriteLine(Student.ContainsKey("Amarnath"));

    }
}