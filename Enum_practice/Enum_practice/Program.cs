using System;

//created the enum
//Enum is a type used to represent a fixed set of named constants, improving readability and safety.
// Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.


/*
 enum Level
 {
    low,
    medium,
    high 
 }

 */

// tyring to print enum values.

/*
enum Months
{
    // deafualt the vlaues satrt with 0 we can ovveride the value by assign to it and next it will update.
    january = 1, //here before assiging the vlaue is 0 now it is 1.and output also will be change.
    February,
    March,
    April,      
    May,        
    June,       
    July
} */

class program
{
    // now creating the enum for the "switch case" statement.inside the class.
    enum Level
    {
        low,
        medium,
        high
    }
    static void Main(string[] args)
    {
        /*
        this for enum priting. 
        Level myvar = Level.low;
        Console.WriteLine(myvar);
        */

        /* this code for enum vlaue priting.
        int num = (int) Months.April;
        Console.WriteLine(num);
        */

        Level myvar = Level.medium;
        // using swtich case for printitng
        switch (myvar)
        {
            case Level.low:
                Console.WriteLine("The level of problem is low");
                break;
            case Level.medium:
                Console.WriteLine("The level of problem is Medium");
                break;
            case Level.high:
                Console.WriteLine("The level of problem is high");
                break;


        }



    }
}