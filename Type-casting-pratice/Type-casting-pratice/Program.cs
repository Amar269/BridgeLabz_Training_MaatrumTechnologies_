/* "Type - casting " = implict casting and explict casting

1. implicit casting = automatically  - converting a smaller type to a larger type size

char -> int -> long -> float -> double

2. explicit casing = manaually  - coverting a larger type to a smaller type size

double -> float -> long -> int -> char

*/

                                      // 1. implicit casting 
int price = 16;
double taxprice = price;
                 // Automatic casting: int to double
Console.WriteLine(price);
Console.WriteLine(taxprice);
// both output will be same as 16.
Console.WriteLine();

                                      // 2. Explicit casting 

double cost = 66.6;
int changecost = (int)cost;
                   // Manual casting: double to int
Console.WriteLine(cost);
Console.WriteLine(changecost); // output will be 66 why beacuse it converts form double to int.


Console.WriteLine();


                                     //Type Conversion Methods

/* It is also possible to convert data types explicitly by using built-in methods.
 1.Convert.ToBoolean
 2.Convert.ToDouble
 3.Convert.ToString 
 4.Convert.ToInt32 (int) 
 5.Convert.ToInt64 (long)

 */

int ticketprice = 150;
double taxticketprice = 10.5;
bool ticketbooked = true;

// now using the conversion methods we will convert them directly.

Console.WriteLine(Convert.ToString(ticketprice)); //convert int into string.

Console.WriteLine(Convert.ToInt32(taxticketprice)); // converted double to int.










