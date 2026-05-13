using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public long  Number { get; set; }
    public string City { get; set; }

    public int CompareTo(Employee other)
    {
        return this.City.CompareTo(other.City);
    }
}

class SortByName : IComparer<Employee>
{
    public int Compare(Employee x , Employee y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

class program
{
    static void Main()
    {
        Employee emp = new Employee() { Name = "Aakash",  Number = 9988776600, City = "Bengaluru" };
        Employee emp1 = new Employee() { Name = "Amarnath", Number = 9876501100, City = "Mumbai" };
        Employee emp2 = new Employee() { Name = "Ananya", Number = 9988776600, City = "Bengaluru" };
        Employee emp3 = new Employee() { Name = "Balayya", Number = 9988774600, City = "Hyderabad"};
        Employee emp4 = new Employee() { Name = "Bhanu", Number = 9988776606, City = "Mumbai" };
        Employee emp5 = new Employee() { Name = "Badhri", Number = 998873600, City = "Hyderabad" };
        Employee emp6 = new Employee() { Name = "charan", Number = 998866600, City = "Delhi" };

        List<Employee> employee = new List<Employee>() { emp1, emp2, emp3, emp4, emp4, emp5, emp6 };



    }
}