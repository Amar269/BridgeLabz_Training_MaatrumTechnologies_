// Strings 
// strings are used to store the text
// A string variable contains a collection of characters surrounded by double quotes (".__.");

using System;
class program
{
    static void Main(string[] args)
    {
        string name = "Amarnth kolla";
        string greetings = "Hai how are you ?";
        Console.WriteLine(greetings);

        // to know string length we can use Length property
        Console.WriteLine("The lenght of Name is  : " + name.Length);

        // we can use some methods like Toupper() and ToLower() to convert upper case and lower case.

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());

        // String Concatenation
        // The + operator can be used between strings to combine them. This is called concatenation.

        string combine = name +" "+greetings;
        Console.WriteLine(combine);

        // we cna use in built method called "string.Concat()"

        string combinedfunction = string.Concat(name , greetings);
        Console.WriteLine(combinedfunction);




    }
}