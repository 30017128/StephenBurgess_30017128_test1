//Stephen Burgess Base x Exponent Calculator.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--This program give the result of base^exponent--");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("\nEnter the base: ");
            double base1 = double.Parse(Console.ReadLine());// collects the base value
            Console.Write("Enter your exponent: ");
            int exponent = int.Parse(Console.ReadLine()); //collects the exponent value
            double result = Math.Pow(base1, exponent);//calculates the result which is the base1 to the power of exponent using Math.pow

            Console.WriteLine($"{base1}^{exponent} = {result}"); //displays base1^exponent then displays the result.
            Console.ReadLine();
            
        }

           
           
            
        }
    }

