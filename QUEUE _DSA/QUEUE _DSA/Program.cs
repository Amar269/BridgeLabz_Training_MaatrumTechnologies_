using System;
class Queue
{
    int[] arr = new int[100];
    int front = 0;
    int rear = -1;


    public void enqueue(int value)
    {
        rear++;
        arr[rear] = value;

    }

    public void dequeue()
    {
        if(front > rear)
        {
            Console.WriteLine("queue is empty");
        }
        Console.WriteLine("Removed :" + arr[front]);
        front++;

    }


    public void peek()
    {
        if(front > rear)
        {
            Console.WriteLine("queue is empty");
            return;

        }
        Console.WriteLine("Front element is :" + arr[front]);

    }
}

class program
{
    static void Main()
    {
        Queue q = new Queue();

        Console.WriteLine("enter the number elements : ");
        int n = int.Parse(Console.ReadLine());

        for(int i=0; i<n; i++)
        {
            Console.WriteLine("enter values : ");
            int val = int.Parse(Console.ReadLine());
            q.enqueue(val);

        }

        Console.WriteLine("\npeek ");
        q.peek();

        Console.WriteLine("\ndequeue  ");
        q.dequeue();

        Console.WriteLine("\nfter the dequeue peek list ");
        Console.WriteLine("\nfter the dequeue peek list ");
        q.peek();


    }
}



/*
 using System;

class CircularQueue
{
    int[] arr = new int[5];
    int front = -1;
    int rear = -1;

    // Enqueue
    public void Enqueue(int value)
    {
        // Check full
        if ((rear + 1) % arr.Length == front)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        // First element
        if (front == -1)
        {
            front = 0;
            rear = 0;
        }
        else
        {
            rear = (rear + 1) % arr.Length;
        }

        arr[rear] = value;
    }

    // Dequeue
    public void Dequeue()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.WriteLine("Removed: " + arr[front]);

        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else
        {
            front = (front + 1) % arr.Length;
        }
    }

    // Peek
    public void Peek()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.WriteLine("Front element: " + arr[front]);
    }

    // Display
    public void Display()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        int i = front;

        while (true)
        {
            Console.Write(arr[i] + " ");

            if (i == rear)
                break;

            i = (i + 1) % arr.Length;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CircularQueue q = new CircularQueue();

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);
        q.Enqueue(50);

        q.Display();

        q.Dequeue();
        q.Dequeue();

        q.Display();

        q.Enqueue(60);
        q.Enqueue(70);

        q.Display();

        q.Peek();
    }
}
 
 
 
 
 
 
 */