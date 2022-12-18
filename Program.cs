using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum, n1, n2;

            Console.Write("\n\n");
            Console.Write("\tFind perfect numbers within a given number of range:\n");
            Console.Write("\t-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.Write("\n\n");

            // receive the first input from the user
            Console.Write("\tInput the starting range or number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            // receive the last input from the user
            Console.Write("\tInput the ending range of number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            // the output will appear here
            Console.Write("\tThe Perfect numbers between {0} and {1} are : \n", n1, n2);
            // rang of number the user entered
            for (n = n1; n <= n2; n++)
            {
                i = 1;
                sum = 0;
                // the rule of perfect number
                for (; i < n; i++)
                {
                    if (n % i == 0)
                        sum = sum + i;
                }

                if (sum == n)
                    Console.Write("\t{0} ", n);// print the output
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
