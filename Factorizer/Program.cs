using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
This program must be in a new console application named Factorizer.
This program must ask the user for the number the program will factor.
The program must print out the original number.
The program must print out each factor of the number (not including the number itself).
The program must print out the total number of factors for the number.
The program must print out whether the number is perfect.
The program must print out whether the number is prime.
 */

namespace Factorizer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like to factor? ");
            int num = int.Parse(Console.ReadLine());

            string strIsPrime = "";
            string strIsPerfect = "";
            List<int> factors = new List<int> { 1 };
            Console.Write("The factors of " + num + " are: 1 ");
            for (int p = 2; p <= num / 2; p++) {
                if (num  % p == 0) { 
                    Console.Write(p + " ");
                    factors.Add(p);
                    strIsPrime = "not ";
                }  
            }
            Console.WriteLine(num + ". ");

            Console.WriteLine("{0} has {1} factors, ", num, factors.Count + 1);
            if (factors.Sum() == num) strIsPerfect = "";
            Console.WriteLine(num + $" is {strIsPerfect}a perfect number.");
            Console.WriteLine(num + $" is {strIsPrime}a prime number.");
            Console.ReadLine();
        }
    }
}
