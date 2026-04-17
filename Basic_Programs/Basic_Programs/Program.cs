using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter the sum excpeted value  : ");
        int n = int.Parse(Console.ReadLine());

       

    }
}

/* 
 //  1. Flip a coin code

       Console.WriteLine("Enter how many times coin should Flip :");
       int n = int.Parse(Console.ReadLine());

       int Heads = 0;
       int Tails = 0;

       Random rand = new Random();

       for (int i =0; i < n; i++)
       {
           int result = rand.Next(0, 2);

           if(result == 0)
           {
               Heads++;

           }
           else if (result == 1)
           {
               Tails++;
           }

       }

       double headprecent = (Heads * 100) / n;
       double tailprecent = (Tails * 100) / n;

       Console.WriteLine("No of Head count : " + Heads);
       Console.WriteLine("No of Tail count : " + Tails);
       Console.WriteLine("No of Heads percentage : " + headprecent);
       Console.WriteLine("No of Tails percentage : " + tailprecent);



// 2. Leap year code 

        Console.Write("Enter the Year: ");
        int year = int.Parse(Console.ReadLine());

        if ( (year % 4  == 0 && year % 100 != 0)  || (year % 400 == 0))
        {
            Console.WriteLine("This is Leap year");
        }
        else
        {
            Console.WriteLine("This is not a leap year");
        }
        

// 3. power or 2 
        Console.WriteLine("Enter the number of N :");
        int n = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i =0; i<=n; i++)
        {
            Console.WriteLine("2^ " + i + "=" + result);
            result = result * 2;
        }

// 4. Harmonic number code 

        Console.Write("Enter the Number :");
        int n = int.Parse(Console.ReadLine());
        
        float sum = 0;

        for (int i = 1; i<=n; i++)
        {
            sum = sum + (1.0f/i);

        }
        Console.WriteLine("this is the Harmonic value: " + sum);



// 5. Prime factor code 
        Console.Write("Enter the number : ");
        int n = int.Parse(Console.ReadLine());

        int i = 2;

        while (n > 1)
        {
            if(n % i == 0)
            {
                Console.Write(i + " ");
                n = n / i;
            }
            else
            {
                i++;
            }
        }
        


// 6. largest number value in 3 numbers 

 Console.WriteLine("Enter the number of a : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of b : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of c : ");
        int c = int.Parse(Console.ReadLine());

        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        Console.WriteLine("Largest number is: " + max);

// 7. Fibonacci Series Code

        Console.WriteLine("enter numebr of terms:");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        Console.WriteLine("Fibonacci series :");
        if (n >= 1)
            Console.WriteLine(a);
        if (n >= 2)
            Console.WriteLine("" + b);

        for(int i =3; i<=n; i++)
        {
            int c = a + b;
            Console.WriteLine(c);

            a = b;
            b = c;
        }



// 8. prefect number code 
        Console.WriteLine("Enter the Number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for(int i = 1; i<=n/2; i++)
        {
            if(n % i == 0)
            {
                sum = sum + i;

            }

        }

        if (sum == n)
        {
            Console.WriteLine("This is prefect number ");
        }
        else
        {
            Console.WriteLine("This is not a prefect number");

        }



// 9. prime number code

        Console.WriteLine("Enter the number :");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        
        for (int i = 1 ; i<=n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }

        }

        if (count == 2)
        {
            Console.WriteLine("This is a prime number ");

        }
        else
        {
            Console.WriteLine("This is not a prime numnber");
            
        }


// 10. Reverse anumber code.

        Console.Write("Enter the mnumber :");
        int n = int.Parse(Console.ReadLine());

        int reverse = 0;

        while (n > 0)
        {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n = n / 10;
        }
        Console.WriteLine("Reversed Numebr : " + reverse);


// 11. copoun code 

       Console.Write("Enter number of distinct coupons: ");
        int n = int.Parse(Console.ReadLine());

        int[] visited = new int[n + 1]; // to track collected coupons

        int count = 0;
        int distinct = 0;

        Random rand = new Random();

        while (distinct < n)
        {
            int num = rand.Next(1, n + 1); // random coupon
            count++;

            if (visited[num] == 0)
            {
                visited[num] = 1;
                distinct++;
            }
        }

        Console.WriteLine("Total random numbers needed: " + count);


// 12. stopwatch code 

        Console.WriteLine("press the enter to start the stopwatch");
        Console.ReadLine();

        DateTime starttime = DateTime.Now;

        Console.WriteLine("stopwatch started ... press enter to stop the stopwatch");
        Console.ReadLine();

        DateTime endtime = DateTime.Now;

        TimeSpan elapsed = endtime - starttime;

        Console.WriteLine("Elapsed Time: " + elapsed


// 13. Grading system code 

        Console.Write("Enter your Marks ( 0 - 100) : ");
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 90 && marks <= 100)
            Console.WriteLine("Grade: O");
        else if (marks >= 80)
            Console.WriteLine("Grade: A+");
        else if (marks >= 70)
            Console.WriteLine("Grade: A");
        else if (marks >= 60)
            Console.WriteLine("Grade: B");
        else
            Console.WriteLine("Grade: F");



// 14. movie ticket price 

        Console.Write("enter ur age :");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter the show time (1 = mrng , 2 = afternoon ) : ");
        int Time = int.Parse(Console.ReadLine());

        int price = 0;

        if (age < 12)
            price = 100;
        else if (age > 12 && age < 64)
            price = 150;
        else
            price = 110;

        if (Time == 2)
            price = price - 50;

        Console.WriteLine("Total ticekt price is : " + price);




// 15. Rock paper scissors code.

        Console.WriteLine("Choose:");
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissors");

        int user = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int comp = rand.Next(1, 4);

        Console.WriteLine("Computer chose: " + comp);

        if (user == comp)
        {
            Console.WriteLine("Draw");
        }
        else if ((user == 1 && comp == 3) || (user == 2 && comp == 1) ||(user == 3 && comp == 2))
        {
            Console.WriteLine("You Win");
        }
        else
        {
            Console.WriteLine("Computer Wins");
        }


// 16 , 17 .

// reverse a string code 
        Console.Write("enter the string :");
        string name =  Console.ReadLine();

        string reverse = "";

        for (int i = name.Length - 1; i>= 0; i--)
        {
            reverse = reverse + name[i];

        }

        Console.WriteLine("the reversed string is : " + reverse);
        Console.WriteLine();

        // palindrome string code 

        if (reverse == name)
        {
            Console.WriteLine("This is palindrome string");
        }
        else
        {
            Console.WriteLine("This is not a palindrome string");
        }


// 18. Anagram code 

        Console.Write("Enter the string 1 :");
        string str1 = Console.ReadLine().ToLower();

        Console.Write("Enter the string 2 :");
        string str2 = Console.ReadLine().ToLower();

        if ( str1.Length != str2.Length)
        {
            Console.WriteLine("This is not a anagram string");
            return;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);

        if (sorted1 == sorted2)
        {
            Console.WriteLine("Anagram string");

        }
        else
        {
            Console.WriteLine("This is Not a Anagram string");

        }



19 . longest substring without repating characters code 

        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int maxLength = 0;

        for (int i = 0; i < str.Length; i++)
        {
            string current = "";

            for (int j = i; j < str.Length; j++)
            {
                // check if character already exists
                if (current.Contains(str[j]))
                {
                    break;
                }

                current = current + str[j];

                if (current.Length > maxLength)
                {
                    maxLength = current.Length;
                }
            }
        }

        Console.WriteLine("Longest substring length: " + maxLength);
   

// 20. string compression code .

Console.WriteLine("enter the string : ");
        string str = Console.ReadLine();

        string result = "";

        int count = 1;

        for(int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                count++;

            }
            else
            {
                result = result + str[i] + count;
                count = 1;
            }
        }

        result = result + str[str.Length - 1] + count;

        Console.WriteLine("Compressed String: " + result);


       */
