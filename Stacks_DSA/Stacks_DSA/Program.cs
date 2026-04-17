using System;
class Stack
{
    int[] arr = new int[100]; // Stack can hold 100 elements


    int top = -1; // This tracks top position

    public void push (int value)
    {
        top++;
        arr[top] = value;
    }

    public void pop()
    {
        if ( top == -1)
        {
            Console.Write("The stack is empty");
            return;
        }
        Console.WriteLine("\nRemoved element:" + arr[top]);
        top--;
        Console.WriteLine();
    }

    public void peek()
    {
        if(top == -1)
        {
            Console.WriteLine("the stack is empty");
            return;

        }

        Console.WriteLine("\nThe top element is :" + arr[top]);


    }


}

class  program
{
    static void Main()
    {
        Stack s = new Stack();


        Console.Write("enter the number of elements wnat to push :");

        int n = int.Parse(Console.ReadLine());

        for(int i=0; i < n; i++)
        {
            Console.WriteLine("Enter the values :");
            int val = int.Parse(Console.ReadLine());

            s.push(val);
        }

        s.peek();

        s.pop();

        s.peek();

    }
}