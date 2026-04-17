using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Node
{
    public int data;
    public Node next;
    public Node prev;

    public Node(int value)
    {
        data = value;
        next = null;
        prev = null;

    }

}

class DoublyLikedList
{
    public Node head;

    public void Insertatend(int value)
    {
        Node newnode = new Node(value);

        if (head == null)
        {
            head = newnode;
            return;

        }

        Node temp = head;

        while(temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newnode;
        newnode.prev = temp;

    }
    public void insertbegin(int value)
    {
        Node newnode = new Node(value);
        if(head == null)
        {
            head = newnode;
            return;
        }
        newnode.next = head;
        head.prev = newnode;
        head = newnode;

    }
    public void printforward()
    {
        Node temp = head;
        while(temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;

        }

        Console.WriteLine("null");
    }

    public void DeleteFirst()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        
        if (head.next == null)
        {
            head = null;
            return;
        }

        head = head.next;
        head.prev = null;
    }
    public void printbackward()
    {
        Node temp = head;

        while(temp.next != null)
        {
            
            temp = temp.next;
        }

        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.prev;
            
        }

        Console.WriteLine("null");
    }

}

class program 
{
    static void Main()
    {
        DoublyLikedList list = new DoublyLikedList();

        Console.Write("enter the number of the nodes : ");
        int n = int.Parse(Console.ReadLine());

        for (int i=0; i<n; i++)
        {
            Console.Write("enter the value :");
            int val = int.Parse(Console.ReadLine());

            list.Insertatend(val);
        }

        Console.WriteLine("\n forward list :  ");
        list.printforward();

        Console.WriteLine("\n backward list :  ");
        list.printbackward();


        Console.Write("enter the value to insert at the beginning :");
        int vali = int.Parse(Console.ReadLine());

        list.insertbegin(vali);

        Console.WriteLine("\nUpdated list:");
        list.printforward();







    }
}