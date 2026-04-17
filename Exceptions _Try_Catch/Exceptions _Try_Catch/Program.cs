using System;
class program
{
    static void Main()
    {
        try
        {
            int[] number = { 1, 2, 3 };
            Console.WriteLine(number[10]);
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.Message);  we can wrtie our own message.
            Console.WriteLine("The code has error");


        }
    }
}