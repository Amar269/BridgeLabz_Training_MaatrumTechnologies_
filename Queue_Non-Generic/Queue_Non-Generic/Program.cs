using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

class program
{
    static void Main()
    {
        Queue queue = new Queue();

        queue.Enqueue("Amar");
        queue.Enqueue(120);
        queue.Enqueue('k');
        queue.Enqueue(177.5);

        Console.WriteLine("The elements in the queue :");
        foreach( var item in queue)
        {
            Console.WriteLine(item);
        }


        Console.Write("The first element in the queue " + queue.Peek());

        Console.WriteLine();




        queue.Dequeue();

        Console.WriteLine("The  updated elements in the queue :");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }




    }
}