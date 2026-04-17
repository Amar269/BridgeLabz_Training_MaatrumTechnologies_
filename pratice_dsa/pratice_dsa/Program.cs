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
        for(int i=0; i < n - 1; i++)
        {
            for(int j=0;j<n-i-1; j++)
            {
                if (arr[j] > arr[j + 1] )
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;


                }
            }
        }
        Console.WriteLine("Sorted array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}