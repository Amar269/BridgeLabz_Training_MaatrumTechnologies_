using System;
using System.Text.RegularExpressions;

class program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter the Username : ");
        string UID = Console.ReadLine();

        string pattern = @"^[a-zA-Z0-9 ._$@]{5,15}$";

        if (Regex.IsMatch(UID, pattern))
        {
            Console.Write("valid username");
        }
        else
        {
            Console.WriteLine("Invalid username ");
        }



        /*
        // password 
        Console.WriteLine("Enter the password : ");
        string pass = Console.ReadLine();

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";

        if(Regex.IsMatch(pass , pattern))
        {
            Console.Write("strong password");
        }
        else 
        {
            Console.WriteLine("weak password");
        }



        
         email verify code
        Console.Write("Enter ur Mail Id  : ");
        string email = Console.ReadLine();

        string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        if(Regex.IsMatch(email , pattern))
        {
            Console.WriteLine("vlaid email");

        }
        else
        {
            Console.WriteLine("Not a vlaid email");
        }
        */


    }
}