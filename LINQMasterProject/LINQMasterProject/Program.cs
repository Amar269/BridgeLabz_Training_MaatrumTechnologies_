using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    public string Dept { get; set; }
}

class program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Amar", Marks = 95,  Dept = "Cloud" },

            new Student { Id = 2, Name = "Rahul", Marks = 40, Dept = "IT" },

            new Student { Id = 3, Name = "Adi", Marks = 85,   Dept = "cloud" },

            new Student { Id = 4, Name = "Kiran", Marks = 70, Dept = "ECE" }
        };

        // Where operator filters data based on a condition.

        Console.WriteLine();
        Console.WriteLine("using where operator : ");
        Console.WriteLine();

        var passedstudents = students.Where(s => s.Marks >= 55);

        foreach(var student in passedstudents)
        {
            Console.WriteLine($" NAME : {student.Name}, MARKS : {student.Marks}");
        }

        // Select operator Take required data and create a new form

        Console.WriteLine();
        Console.WriteLine("using Select operator : ");
        Console.WriteLine();

        var studentnames = students.Select(s => s.Name);
        Console.WriteLine();

        foreach(var name in studentnames)
        {
            Console.WriteLine(" Names : " + name);
        }
    }

}
