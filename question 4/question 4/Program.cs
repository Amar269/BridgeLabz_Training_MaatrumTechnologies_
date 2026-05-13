using System;
using System.Collections.Generic;

class Contact
{
    public string Name;
    public string Number;
    public string City;

    
}

class program
{
    static void Main()
    {
        Dictionary<char, List<Contact>> addressbook = new Dictionary<char, List<Contact>>();

        Console.WriteLine("enter the number of cocntat to add :");

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Enter ur name :");
            String name = Console.ReadLine();

            Console.WriteLine("Enter ur Number :");
            String number = Console.ReadLine();

            Console.WriteLine("Enter ur City:");
            String city = Console.ReadLine();

            Contact contact = new Contact();

            contact.Name = name;
            contact.Number = number;
            contact.City = city;

            char Key = char.ToUpper(contact.Name[0]);

            if (addressbook.ContainsKey(Key))
            {
                addressbook[Key].Add(contact);
            }
            else
            {
                List<Contact> newlist = new List<Contact>();
                newlist.Add(contact);
                addressbook.Add(Key, newlist);
            }


        }
        Console.WriteLine("Enter the character to display:");
        char ch = char.ToUpper(char.Parse(Console.ReadLine()));
        if (!addressbook.ContainsKey(ch))
        {
            Console.WriteLine("No contacts found for this character.");
            return;
        }

        List<Contact> list = addressbook[ch];
        list.Sort((a, b) => a.Name.CompareTo(b.Name));

        Dictionary<string, List<Contact>> cityGroup = new Dictionary<string, List<Contact>>();

        foreach (Contact c in list)
        {
            if (cityGroup.ContainsKey(c.City))
            {
                cityGroup[c.City].Add(c);
            }
            else
            {
                cityGroup[c.City] = new List<Contact>();
                cityGroup[c.City].Add(c);
            }
        }
        Console.WriteLine(ch + ":");

        foreach (var city in new SortedDictionary<string, List<Contact>>(cityGroup))
        {
            Console.WriteLine("  " + city.Key + ":");

            foreach (Contact c in city.Value)
            {
                Console.WriteLine("    " + c.Name + ", " + c.Number + ", " + c.City);
            }
        }







    }
}