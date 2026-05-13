using System;
using System.Collections;

class program
{
    static void Main()
    {
        Stack stack1 = new Stack();

        stack1.Push("Amar");
        stack1.Push(10);
        stack1.Push("Flase");
        stack1.Push(155.45);
        stack1.Push('A');


        Console.WriteLine("The elements in the stack :");
        foreach(var item in stack1)
        {
            Console.WriteLine(item);

        }


        Console.WriteLine("The first element in the stack is :" + stack1.Peek());

        if (stack1.Contains("Amar"))
        {
            Console.WriteLine("The element is present in  the stack");
        }
        else
        {
            Console.WriteLine("the element is not in the stack ");
        }

        //pop();
        //clear();
        //copy();
        //clone();

        Console.ReadKey();
    }
}
