//Stephen Burgess Algebraic Guessing game
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--Can you solve this algebraic expression--");
            Console.WriteLine("--------------2(x - 3) + x = 12------------"); //Title Screen
            Console.WriteLine("-------------------------------------------");

            

            int correct = 2; //Value of the correct answer
            Console.Write("\nEnter your guess at the value of x:  ");
            int guess = int.Parse(Console.ReadLine()); //reads the line and stores it as int guess
            if (correct == guess) //if correct is equal to guess it will write the line That guess was correct.
            {
                Console.WriteLine("\nThat guess was correct");
            }
            else
                Console.WriteLine("\nSorry that guess was incorrect"); //If correct does not equal guess it will write Sorry that guess was incorrect.

            Console.ReadLine();

            /*/I found x by multiplying 2 b by the values in the brackets then I added on x to the values I got from multiplying which gave me 3x - 6 from here i subtracted 6 from 12 which gave me
            3x = 6 and 6 divided by 3 is 2 so x = 2.
    /*/
        }
    }
}
