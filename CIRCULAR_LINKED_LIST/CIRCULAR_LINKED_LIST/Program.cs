using System;

class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
        next = null;

    }
}

class circularlist
{
    public Node head;

    public void insertbegin(int value)
    {
        Node newnode = new Node(value);

        head = newnode;
        newnode.next = head;

    }

    public void insertend( int value )

    {
        Node newnode = new Node(value);
        
        if(head == null)
        {
            head = newnode;
            newnode.next = head;
            return;
        }
        
        Node temp = head;

        while(temp.next != head)
        {
            temp = temp.next;
        }

        temp.next = newnode;
        newnode.next = head;


    }
    public void display()
    {
        if (head == null)
            return;

        Node temp = head;

        do
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        while (temp != head);
        
        Console.WriteLine("back to head");

        
    }
} 


class program
{
    static void Main()
    {
        circularlist list = new circularlist();

        Console.Write("enter the number of nodes to insert:");
        int n = int.Parse(Console.ReadLine());

        for (int i =0; i<n; i++)
        {
            Console.Write("enter the value : ");
            int val = int.Parse(Console.ReadLine());

            list.insertend(val);

        }
        
        Console.WriteLine("\nCircular Linked List:");
        list.display();

    }
}