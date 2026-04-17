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
class LinkedList
{
    public Node head;
    public void InsertatEnd(int value)
    {
        Node newnode = new Node(value);
        if (head == null)
        {
            head = newnode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
            
        }

        temp.next = newnode;


    }
    public void InsertAtBeginning(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head = newNode;

    }

    public void InsertAtposotion(int value , int position)
    {
        Node newnode = new Node(value);
        Node temp = head;
        for (int i = 0; i<position-1; i++)
        {
            temp = temp.next;

        }
        newnode.next = temp.next;
        temp.next = newnode;
    }

    public void deletefirst()
    {
        if (head == null)
        {
            Console.WriteLine("Lsit is empty");
        }
        head = head.next;

    }

    public void search(int value)
    {
        Node temp = head;
        while(temp != null)
        {
            if (temp.data == value)
            {
                Console.WriteLine("vlaue found");
                return;
            }

            temp = temp.next;
        }

        Console.WriteLine("value not found");
    }
    
    


    public void Printlist()
    {
        Node temp  = head;

        while(temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }

        Console.WriteLine("null");

    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        Console.Write("enter the number of nodes : ");
        int n = int.Parse(Console.ReadLine());

        for (int i= 0; i < n; i++)
        {
            Console.Write("Enter the values : ");
            int value = int.Parse(Console.ReadLine());

            list.InsertatEnd(value);
            

        }
        // initinal list 
        Console.WriteLine("\nLinked List:");

        list.Printlist();

        Console.Write("\n Enter the value to insert at the beginning : ");
        int val = int.Parse(Console.ReadLine());

        list.InsertAtBeginning(val);

        Console.WriteLine("\n updated Linked List:");

        list.Printlist();

        Console.WriteLine();

        Console.WriteLine("enter the vlaue to insert at the psotion : ");
        int val1 = int.Parse(Console.ReadLine());

        Console.Write("enter the psotion to insert");
        int pos = int.Parse(Console.ReadLine());

        list.InsertAtposotion(val1, pos);

        Console.WriteLine("\nUpdated Linked List:");


        list.Printlist();

        Console.WriteLine("Enter the value to search : ");
        int sv = int.Parse(Console.ReadLine());

        list.search(sv);

        










    }
}