using System;

class program
{
    static void Main()
    {
        Console.WriteLine("enter the number ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("enter the values :");
            arr[i] = int.Parse(Console.ReadLine());


        }
        for (int i = 0; i < n ; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while(j >=0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;


        }
        Console.WriteLine("Sorted array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}