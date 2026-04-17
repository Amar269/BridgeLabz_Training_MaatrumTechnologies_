using System;

class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of the elements :");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.Write("enter the elements :");
        for(int i=0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }


        Console.Write("enter the target element :");
        int target = int.Parse(Console.ReadLine());

        int result = LinearSearch(arr, target);

        if(result != -1)
        {
            Console.WriteLine("Element found at the index: " + result);

        }
        else
        {
            Console.WriteLine("Element not found"); 
        }
    }

    static int LinearSearch(int[] arr , int target)
    {
        for(int i=0;i<arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;

            }
        }
        return -1;
    }
}