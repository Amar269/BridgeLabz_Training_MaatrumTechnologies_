using System;
using System.Collections.Generic;

class student<T> 
{
    public T data; // generic class

    public void show()
    {
        Console.WriteLine("The data is : " + data); 

    }
}

class program
{
    public static void methodss <U> (U value) // generic method 
    {
        Console.WriteLine(value);

    }

    static void calculate (int a , int b , out int p , out int s)
    {
        Console.WriteLine(p = a * b);

        Console.WriteLine(s = a + b);
    }
    static void Main()
    {
        student<int> std = new student<int>();
        std.data = 157;
        std.show();

        student<string> std1 = new student<string>();
        std1.data = "Amarnath";
        std1.show();

        methodss(10);
        methodss("iam a genric method");

        int p, s;

        calculate(10, 20, out  p, out  s);

        calculate(10,10, out  p, out _);




    }
}