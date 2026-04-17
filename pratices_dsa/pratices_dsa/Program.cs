using System;

class Node
{
    public int data;
    public Node next;

}

class Linkedlist

{
    public Node head = null;

    public void insertbegin(int value)
    {
        Node newnode = new Node();
        newnode.data = value;
        newnode.next = head;
        head = newnode;

        
    }
    
    public void display()
    {
        Node temp = head;
        while(temp!= null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;

        }
        Console.WriteLine("null");

    }
    

}

class program
{
    public static void Main()
    {
        Linkedlist list = new Linkedlist();

        list.insertbegin(10);
        list.insertbegin(20);

        Console.Write("list :");
        list.display();
    }
}