using System;

namespace CTCISol
{
    class Program1
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine(Factorial(4));
        }

        static int Factorial(int n)
        {
            // Breaking Condition
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    }
}


