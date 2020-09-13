using System;

namespace CTCISol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine(IsPrime(11));
        }

        static bool IsPrime(int n)
        {
            //for (int i = 2; i * i <= n; i++)
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }        
    }
}
