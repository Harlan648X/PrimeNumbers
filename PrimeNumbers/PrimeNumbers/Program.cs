using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers();
        }

        static void PrimeNumbers()
        {
            Console.WriteLine("How many Prime Numbers would you like to see?");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            int count = 0;
            //Prime numbers are only divisible by 1 and itself, 2 is the first prime

            for (int i = 2; count < stop; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    if (count + 1 == stop)
                    {
                        Console.Write(i);
                        count++;
                    }
                    else
                    {
                        Console.Write(i + ",");
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
