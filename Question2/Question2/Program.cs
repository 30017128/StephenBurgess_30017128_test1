//Stephen Burgess price addition 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--This program will give the sum of 5 total prices--");
            Console.WriteLine("----------------------------------------------------");

            double price = 0;//makes the double price
            

            for (int counter = 1; counter <= 5; counter++)//makes a loop that repeats 5 times
            {
                Console.Write($"Enter the price of item {counter}: ");//repeats this line 5 times and adds the number for each line.
                
                price += double.Parse(Console.ReadLine());//insert the price after each line and it will add it up.








            }
            Console.WriteLine($"The total of these items are ${price}");//displays the price






            Console.ReadLine();
            }
        }
    }

