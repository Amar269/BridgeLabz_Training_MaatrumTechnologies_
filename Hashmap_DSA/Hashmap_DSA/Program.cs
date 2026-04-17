using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        map["apple"] = 10;
        map["banana"] = 20;
        map["mango"] = 30;

        Console.WriteLine(map["apple"]);

        foreach (var item in map)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        if (map.ContainsKey("apple"))
        {
            Console.WriteLine("Apple exists");
        }
    }
}