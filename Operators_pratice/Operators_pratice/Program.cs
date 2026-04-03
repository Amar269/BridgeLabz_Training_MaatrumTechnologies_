// operators = Operators are used to perform operations on variables and values.

// Arithmetic Operators = Arithmetic operators are used to perform common mathematical operations


/*
 int x =10 , y =5;

 + , - , *,/,%,++,--

 1. =   (+)	 Addition Adds together two values	x + y =  15
 2. =   (-)	 Subtraction Subtracts one value from another	x - y = 5
 3. =   (*)	 Multiplication Multiplies two values	x * y = 50
 4. =   (/)	 Division	Divides one value by another	x / y = 2
 5. =   (%)	 Modulus	Returns the division remainder	x % y = 0
 6. =   (++) Increment	Increases the value of a variable by 1	x++ = 11
 7. =   (--) Decrement	Decreases the value of a variable by 1	x-- = 9
 
 
 */


//Assignment Operators

// Assignment operators are used to assign values to variables.


/*
 =	x = 5	x = 5

+=	x += 3	x = x + 3 

-=	x -= 3	x = x - 3 

*=	x *= 3	x = x * 3

/=	x /= 3	x = x / 3

%=	x %= 3	x = x % 3

&=	x &= 3	x = x & 3

|=	x |= 3	x = x | 3

^=	x ^= 3	x = x ^ 3

>>=	x >>= 3	x = x >> 3

<<=	x <<= 3	x = x << 3 
 
 */




// Comparison Operators

// Comparison operators are used to compare two values (or variables).
//The return value of a comparison is either True or False.



/*
 ==	Equal to	x == y

!=	Not equal	x != y

>	Greater than	x > y	

<	Less than	x < y	

>=	Greater than or equal to	x >= y	

<=	Less than or equal to	x <= y
 
 
 */



// Logical Operators
//Logical operators are used to determine the logic between variables or values

/*
 
 &&    Logical and Returns True if both statements are true	x < 5 &&  x < 10

||     Logical or Returns True if one of the statements is true	x < 5 || x < 4	


!     Logical not Reverse the result, returns False if the result is true	!(x < 5 && x < 10)
 
 
 */

// code 

using System;

class Program
{
    static void Main()
    {
        int x = 10, y = 5;

        // 🔹 Arithmetic Operators
        Console.WriteLine("=== Arithmetic ===");
        Console.WriteLine(x + y);
        Console.WriteLine(x - y);
        Console.WriteLine(x * y);
        Console.WriteLine(x / y);
        Console.WriteLine(x % y);

        x++;
        Console.WriteLine("Increment: " + x);

        x--;
        Console.WriteLine("Decrement: " + x);


        // 🔹 Assignment Operators
        Console.WriteLine("\n=== Assignment ===");
        int a = 10;

        a += 5;
        Console.WriteLine("+= " + a);

        a -= 3;
        Console.WriteLine("-= " + a);

        a *= 2;
        Console.WriteLine("*= " + a);

        a /= 4;
        Console.WriteLine("/= " + a);


        // 🔹 Comparison Operators
        Console.WriteLine("\n=== Comparison ===");
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);


        // 🔹 Logical Operators
        Console.WriteLine("\n=== Logical ===");
        Console.WriteLine(x > 5 && x < 15);
        Console.WriteLine(x > 5 || x < 5);
        Console.WriteLine(!(x > 5));
    }
}


//  Math()

// C# Math class has many methods that allows you to perform mathematical tasks on numbers.

/*
1. Math.Max(x,y) = method can be used to find the highest value of x and y.

2. Math.Min(x,y) = method can be used to find the lowest value of of x and y.

3. Math.Sqrt(x) =  method returns the square root of x.

4. Math.Abs(x) = method returns the absolute (positive) value of x 

5. Math.Round() = rounds a number to the nearest whole number 



using System;

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 5;
        double num = 25.6;
        int negative = -20;

        // 1. Math.Max()
        Console.WriteLine("Max value: " + Math.Max(x, y));

        // 2. Math.Min()
        Console.WriteLine("Min value: " + Math.Min(x, y));

        // 3. Math.Sqrt()
        Console.WriteLine("Square Root: " + Math.Sqrt(x));

        // 4. Math.Abs()
        Console.WriteLine("Absolute value: " + Math.Abs(negative));

        // 5. Math.Round()
        Console.WriteLine("Rounded value: " + Math.Round(num));
    }
}
  
 */