
using System;
using System.Numerics;

namespace FibonacciRecursive
{
    class Program
    {
        static BigInteger[] fibonacciNumbers;
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            fibonacciNumbers = new BigInteger[position+1];
            Console.WriteLine(FibonacciNumber(position));
        }
        static BigInteger FibonacciNumber(int pos)
        {
            //This is the part where memoization is used
            if (fibonacciNumbers[pos] != 0) return fibonacciNumbers[pos];
            if (pos <= 2) return 1;
            fibonacciNumbers[pos] = FibonacciNumber(pos - 1) + FibonacciNumber(pos - 2);
            return fibonacciNumbers[pos];
            
            // This next partis  without memoization
            /*
            if (pos <= 2) return 1;
            return FibonacciNumber(pos - 1) + FibonacciNumber(pos - 2);
            */
        }

    }
}
