using System;

namespace PascalTriangle
{
    class Program
    {
        static int[,] triangleNumbers;
        static void Main(string[] args)
        {
            int sizeOfTriangle = int.Parse(Console.ReadLine());
            triangleNumbers = new int[sizeOfTriangle, sizeOfTriangle + 2];
            for(int n = 0;n<sizeOfTriangle;n++)
            {
                for (int k = 0; k <= n; k++)
                    triangleNumbers[n, k] = Binomial(n, k);
            }
            PrintTriangle(triangleNumbers,sizeOfTriangle);
          
            
        }

        private static void PrintTriangle(int [,] triangleNums,int line)
        {
            for (int row = 0; row < line; row++)
            {
                for (int cow = 0; cow < row; cow++)
                    Console.Write("{0} ", triangleNums[row, cow]);
                Console.WriteLine(triangleNumbers[row,row]);
            }
            return;
        }

        private static int Binomial(int n, int k)
        {
            if (triangleNumbers[n, k] != 0) return triangleNumbers[n, k];
            if (n == k) return 1;
            if (k == 0) return 1;
            
            return Binomial(n - 1, k) + Binomial(n - 1, k - 1);
        }
        
    }
}
