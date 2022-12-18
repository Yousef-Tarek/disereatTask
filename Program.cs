using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, m = 0;
            Console.Write("\n\n");
            Console.Write("\tFind the prime numbers from n1 to n2 :\n");
            Console.Write("\t(:---------------------------------------------------:)");
            Console.Write("\n\n");

            // receive the first input from the user
            Console.Write("\tInput starting number of range: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t================================\n");
            // receive the last input from the user
            Console.Write("\tInput ending number of range : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t=================================\n");
            // the output will appear here
            Console.Write("\tThe prime numbers between {0} and {1} are : \n", n1, n2);

            // rang of number the user entered
            for (int j = n1; j <= n2; j++)
            {
                // beging of loop 1

                // the rule of prime number
                for (i = 2; i <= j / 2; i++)
                {
                    // beging of loop 2
                    m = 0;
                    if (j % i == 0)
                    {
                        m++;
                        break;
                    }
                    // end of loop 2
                }
                if (m == 0 && j != 1)
                {
                    Console.Write("\t{0}", j); // print the output
                }
                // end of loop 1
            }

            Console.ReadLine();
        }
    }
}
