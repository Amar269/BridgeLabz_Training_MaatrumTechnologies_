using System;
using System.Collections;

class program
{
    static void Main()
    {
        SortedList sortedlist = new SortedList();

        sortedlist.Add(1, "One");
        sortedlist.Add(5, "Five");
        sortedlist.Add(4, "Four");
        sortedlist.Add(2, "Two");
        sortedlist.Add(3, "Three");

        Console.WriteLine("SortedList : ");


        foreach (DictionaryEntry item in sortedlist)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        Console.WriteLine();

        Console.WriteLine("SortedList : ");
        foreach (DictionaryEntry item in sortedlist)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("sortedlsit after removing one element from the list :");

        sortedlist.Remove(3); //Remove(object key) , //clear();


        foreach (DictionaryEntry item in sortedlist)
        {
            Console.WriteLine($" key : {item.Key} , value : {item.Value}");


        }

        // Contains(object key) , ContainsKey(object key) , ContainsValue(object value)




    }
}