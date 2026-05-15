using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_basic
{
    class program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 4, 5, 5, 7, 9 };

                            
            // this is the query syntax of linq
                var num =   from obj in numbers
                             where  obj >= 5
                             select obj;
               
            // this is the method syntax of linq
            // var num = numbers.where(obj => obj >= 5).ToList();
      
            foreach (var n in num)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}

