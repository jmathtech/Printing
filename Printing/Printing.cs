using System;

/*
 Name: Jamil Matheny & Bryce Moore
 Date: 10/07/2020
 Class: CIS214
 */

namespace Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            // Use one Console.WriteLine statement
            Console.WriteLine("1 2 3 4 \n");


            // Use four Console.Write statements
            Console.Write("1 ");
            Console.Write("2 ");
            Console.Write("3 ");
            Console.Write("4 \n\n");

           
            // Use one Console.WriteLine statement with four format items.
            
            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}  \n");

            /* Initialize two variables with a value and get the sum of two numbers.  
            Perform the calculation in the output statement. */

            // Variables
            int myNum = 4;
            int yourNum = 2;
      
            int sum = myNum + yourNum; // Calculate to sum up the two variables.
            Console.WriteLine($"4 + 2 = {sum}"); // Outputs the sum of the calculation.

        }
    }
}
