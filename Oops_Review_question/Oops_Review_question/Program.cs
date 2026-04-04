using System;
// created class with name Studnet and added the constrcuot and properties
public class Student
{
    public string Name { get; set; } //this is property
    public long RegId { get; set; }
    public int Maths { get; set; }
    public int English { get; set; }
    public int Science { get; set; }

    // this is the constructor of the class
    public Student(string name , long regid, int math, int eng, int sci)
    {
        Name = name;
        RegId = regid;
        Maths = math;
        English = eng;
        Science = sci;
    }
}

// created the interface with one method for calculating the grade.
interface IGradecalculator
{
    public String Getgrade(double percentage);// method gives which grade student got so used "string"

}
public abstract class Result
{
    protected Student student;
    public Result(Student s)
    {
        student = s;
    }

    public abstract double CalculateResult();
}

public class SchoolResult: Result, IGradecalculator
{
    public SchoolResult(Student s) : base(s)
    {

    }
    public override double CalculateResult()
    {
        double total = student.Maths + student.English + student.Science;
        return total / 3;
    }
    public string Getgrade(double percentage)
    {
        if (percentage >= 90)
            return "A";
        else if (percentage >= 80)
            return "B";
        else if (percentage >= 70)
            return "C";
        else if (percentage >= 60)
            return "D";
        else
            return "F";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // object created and passed the values in the constructor.
        Student s1 = new Student("Amarnath",2211028010157,76,84,90); 
        SchoolResult result = new SchoolResult(s1);
        double percentage = result.CalculateResult();
        String grade = result.Getgrade(percentage);
        Console.WriteLine("Name : " + s1.Name);
        Console.WriteLine("RegId : " + s1.RegId);
        Console.WriteLine($"percentage : {percentage:F2}");
        Console.WriteLine("Grade : " + grade);

    }
}