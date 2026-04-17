using System;
using System.Runtime.CompilerServices;

class Node
{
    public int id;
    public string name;
    public double salary;
    public Node next;

    public Node(int n , string Name , double Salary)
    {
        id = n;
        name = Name;
        salary = Salary;
        next = null;

    }

}

class LinkedList
{
    public Node head;

    public void Insert(int n , string Name , double Salary)
    {
        Node newnode = new Node(n, Name, Salary);

        if(head == null)
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
    }

    public void Display()
    {
        Node temp = head;
        while(temp != null)
        {
            Console.Write(temp.id +" "+ temp.name+ " " + temp.salary+ " -> " );
            temp = temp.next;
        }
        Console.WriteLine("Null");

    }

    public void search(int n)
    {
        Node temp = head;
        while(temp != null)
        {
            if(temp.id == n)
            {
                Console.WriteLine("Employee found" +" "+ temp.name);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("value not found");


    }

    public void Delete()
    {
        if(head == null)
        {
            Console.WriteLine("list is empty");
        }
        head = head.next;

    }

    public void Deletepositon(int pos)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }

        if (pos == 1)
        {
            head = head.next;
            return;
        }

        Node temp = head;


        for (int i =0; i<pos-1; i++)
        {
            if(head == null)
            {
                Console.WriteLine("position is out of range");
                return;
            }
            temp = temp.next;
        }

        if (temp.next == null)
        {
            Console.WriteLine("Position out of range");
            return;
        }
        temp.next = temp.next.next;
    }


}   





class program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Insert(1, "Amar", 50000);
        list.Insert(2, "Aditya", 70000);
        list.Insert(3, "Abhi", 40000);

        Console.WriteLine("list print : ");
        list.Display();

        Console.WriteLine("Enter the id to search : ");
        int s = int.Parse(Console.ReadLine());

        list.search(s);

        
        Console.WriteLine("Enter position to delete:");
        int pos = int.Parse(Console.ReadLine());

        list.Deletepositon(pos);

        Console.WriteLine("List after deletion:");
        list.Display();



    }
}