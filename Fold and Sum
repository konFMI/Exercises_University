using System;
using System.Linq;
namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = elements.Length / 4;
            int[] firstKElements = new int[k],
                  lastKElements = new int[k],
                  middle2KElements = new int[2 * k];
            int i = k-1;
            while(i>=0)
            {
                firstKElements[i] = elements[k-i-1];
                i--;
            }
            
            
             i = k;
             while(i<3*k)
             {
                 middle2KElements[i - k] = elements[i];
                 i++;
             }


            i = 4 * k - 1;
            while (i > 3*k-1)
            {
                lastKElements[4*k-1 -i] = elements[i];
                i--;
            }
            
            
            
            i = 0;
            while(i<k)
            {
                middle2KElements[i] += firstKElements[i];
                i++;
            }
            i = k;
            while (i < 2 * k)
            {
                middle2KElements[i] += lastKElements[i - k];
                i++;
            }
            
            foreach (int elm in middle2KElements)
                Console.WriteLine(elm);


        }
    }
}
