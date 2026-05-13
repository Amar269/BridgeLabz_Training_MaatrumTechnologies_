using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;78

class Employee
{
    public int id { get; set; }
    public string name { get; set; }

    public string Email{ get; set; }
}

class program
{
    static void Main()
    {
        List<Employee> emp = new List<Employee>
        {
            new Employee{id = 1 , name = "Amar" , Email = "amarnath.gmail.com"} ,
            new Employee{id = 2 , name = "Aditya" , Email = "aditya13@gmail.com"},
            new Employee{id = 3 , name = "SRM" , Email = "SRM3@gmail.com"},
        };

        string path = "user.json";

        string json = JsonSerializer.Serialize(emp);

        File.WriteAllText(path, json);

        Console.WriteLine("json file created successfully.");


        string rejson = File.ReadAllText(path);

        List<Employee> remp = JsonSerializer.Deserialize<List<Employee>>(rejson);

        Console.WriteLine("Enter the user ID :");
        int searchid = int.Parse(Console.ReadLine());

        bool found = false;
        foreach (var e in remp)
        {
            if(e.id == searchid)
            {
                Console.WriteLine("user found");
                Console.WriteLine($" id = {e.id} , name = {e.name} , Email = {e.Email}");

                Console.WriteLine("want to update  the user data  (yes / no) :");

                string  choice = (Console.ReadLine());
                string pattern = @"^ [a-zA-Z]$";

                if (Regex.IsMatch(choice, pattern))
                {
                    Console.Write("Enter New Name : ");
                    e.name = Console.ReadLine();

                    Console.Write("Enter New Email : ");
                    e.Email = Console.ReadLine();

                    string updatedjson = JsonSerializer.Serialize(remp);

                    File.WriteAllText(path, updatedjson);
                    Console.WriteLine("\nUser updated successfully");



                }



                found = true;
                break;
                


            }
     

        }
        if (found  == false)
        {
            Console.WriteLine("user not  found");

            Console.WriteLine("Add the user details :");

            Console.WriteLine("enter the user id :");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name : ");
            string newname = Console.ReadLine();

            Console.Write("Enter Email : ");
            string newemail = Console.ReadLine();


            remp.Add(new Employee
            {
                id = id,
                name = newname,
                Email = newemail,
            }
            );

            string update = JsonSerializer.Serialize(remp);

            File.WriteAllText(path, update);

            
            



        }




    }
}
