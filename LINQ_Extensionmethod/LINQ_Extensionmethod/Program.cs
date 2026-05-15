using System;

public static class StringExtensions
{
  
    public static int Getwordcount(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        return text.Split(' ').Length;
    }
}

class program
{
    static void Main()
    {
        string sentence = "welcome to Extension method in c#";
        int count = sentence.Getwordcount();
        Console.WriteLine(count);
    }
}