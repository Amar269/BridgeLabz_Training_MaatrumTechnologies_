using System;
using System.Linq;
class program
{
    static void Main()
    {
        //2D-arrays
        int[,] num = { { 1, 2, 3 }, { 5, 6, 7 } };

        for (int i = 0; i < num.GetLength(0); i++)
        {
            for (int j = 0; j < num.GetLength(1); j++)
            {
                Console.WriteLine(num[i,j] + " ");
            }
            Console.WriteLine();
        }
        
        /*foreach(int i in num)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine(num[0, 1]);*/





        /* 
        
        1D arrays
        int [] numbers = { 7, 5, 4, 67, 8, 43, 5, 67, 0 };
        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);

        }
        Console.WriteLine();
        Console.WriteLine(numbers.Max());
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Sum());



         Console.WriteLine("enter the numbers : ");
         int mynum = int.Parse(Console.ReadLine());
         int[] arr = new int[mynum];
         for (int i=0; i< mynum; i++)
         {
             arr[i] = int.Parse(Console.ReadLine());

         }
         int x = arr[2];

         Console.WriteLine(x);

         //

         Console.WriteLine("enter ur number : ");
         long i = Convert.ToInt64((Console.ReadLine()));
         Console.WriteLine();

         for (int j =0;j<i;j++)
         {
             Console.WriteLine(j);
         }

         while (i < 5)
         //{
         Console.WriteLine(i);
         i++;
        }*/


    }
}