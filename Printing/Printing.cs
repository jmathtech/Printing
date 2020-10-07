using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            // Variables
            int myNum = 4;
            int yourNum = 2;          

            // Use one Console.WriteLine statement
            Console.WriteLine(myNum);
            Console.WriteLine("");

            // Use four Console.Write statements
            Console.Write("1 ");
            Console.Write("2 ");
            Console.Write("3 ");
            Console.Write("4 ");

            // Use one Console.WriteLine statement with four format items.
            int sum = myNum + yourNum;
            Console.WriteLine("");
            Console.WriteLine(sum);

        }
    }
}
