using System;
using System.Collections.Generic;

namespace Review
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string city { get; set; }

        public int CompareTo(Employee other)
        {
            int cityCompare = this.city.CompareTo(other.city);

            if (cityCompare == 0)
                return this.Name.CompareTo(other.Name);

            return cityCompare;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<Employee>> dict = new Dictionary<char, List<Employee>>();
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Number: ");
                string number = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                employees.Add(new Employee
                {
                    Name = name,
                    Number = number,
                    city = city
                });
            }

            
            foreach (var emp in employees)
            {
                char key = char.ToUpper(emp.city[0]);

                if (!dict.ContainsKey(key))
                    dict[key] = new List<Employee>();

                dict[key].Add(emp);
            }

           
            foreach (var item in dict)
            {
                item.Value.Sort();
            }

            
            List<char> keys = new List<char>(dict.Keys);
            keys.Sort();

            
            Console.WriteLine("\nSorted Output:\n");

            foreach (var key in keys)
            {
                foreach (var emp in dict[key])
                {
                    Console.WriteLine($"{emp.Name}, {emp.Number}, {emp.city}");
                }
            }
        }
    }
}