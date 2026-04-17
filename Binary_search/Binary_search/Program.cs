using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number of elements :");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the values : ");
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.WriteLine("Enter the target value : ");
        int target = int.Parse(Console.ReadLine());

        int low = 0, high = n - 1, index = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
             
        }
        if(index != -1)
            Console.WriteLine("\nElement found at index: " + index);
        else
            Console.WriteLine("\nElement not found");






    }
}