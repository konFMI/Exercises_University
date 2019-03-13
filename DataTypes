using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInput(Console.ReadLine());
        }

        private static void ReadInput(string v)
        {
            switch(v)
            {
                case "int":
                    OutputInt(int.Parse(Console.ReadLine()));
                    break;
                case "real":
                    OutputReal(double.Parse(Console.ReadLine()));
                    break;
                case "string":
                    OutputString(Console.ReadLine());
                    break;
                default:
                    break;
            }
            return;
        }

        private static void OutputString(string v)
        {
            Console.WriteLine("$"+v+"$");
            return;
        }

        private static void OutputReal(double v)
        {
            Console.WriteLine("{0:0.00}", 1.5 * v);
            return;
        }

        private static void OutputInt(int v)
        {
            Console.WriteLine(v << 1);
            return;
        }
    }
}
