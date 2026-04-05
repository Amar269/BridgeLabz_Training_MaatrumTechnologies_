// Strings 
// strings are used to store the text
// A string variable contains a collection of characters surrounded by double quotes (".__.");

using System;
class program
{
    static void Main(string[] args)
    {
        string name = "Amarnth kolla";
        int age = 22;
        string greetings = "Hai how are you ?";
        Console.WriteLine(greetings);

        Console.WriteLine();
        // to know string length we can use Length property
        Console.WriteLine("The lenght of Name is  : " + name.Length);
        Console.WriteLine();

        // we can use some methods like Toupper() and ToLower() to convert upper case and lower case.

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine();

        // String Concatenation
        // The + operator can be used between strings to combine them. This is called concatenation.

        string combine = name +" "+greetings;
        Console.WriteLine(combine);

        Console.WriteLine();

        // we cna use in built method called "string.Concat()"

        string combinedfunction = string.Concat(name , greetings);
        Console.WriteLine(combinedfunction);

        Console.WriteLine();

        // String Interpolation
        // String interpolation is used to insert variable values directly inside a string.
        //Start the string with a dollar sign ($)
        // use {} (curly braces) to place variables inside the string
        // String interpolation was introduced in C# version 6.

        string details = $"my deatils are : My Name = {name}, My Age = {age}";
        Console.WriteLine(details);

        Console.WriteLine();

        // Access Strings
        // we can access the characters in a string by referring to its index number inside square brackets [].
        Console.WriteLine("This will give output of that accessed string in the letter : " + name[2]);

        Console.WriteLine();

        // we can also find the string postion of using "IndexOf()". I and O big cap's letters

        Console.WriteLine("From this we can find string position :" + name.IndexOf("a"));

        Console.WriteLine();


        // Strings - Special Characters

        // \" → used to print double quotes inside a string
        string a = " Good Morning \"Amar\" ";
        Console.WriteLine(a);

        Console.WriteLine();

        // \' → used to print single quote

        string b = "Hai Welcome to  Kolla\'s House ";
        Console.WriteLine(b);

        Console.WriteLine();
        //   \\ → used to print backslash(\)

        string c = "This is backslash: \\";
        Console.WriteLine(c); 















    }
}