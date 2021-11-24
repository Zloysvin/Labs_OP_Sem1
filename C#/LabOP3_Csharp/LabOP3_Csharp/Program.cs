using System;

namespace LabOP3_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double current = 1;
            double previous = 0;
            while (Math.Abs(current - previous) > 0.000001)
            {
                previous = current;
                current = (2 - Math.Pow(previous, 3)) / 5;
                Console.WriteLine("current: " + current);
                Console.WriteLine("previous: " + previous);
                Console.WriteLine();
            }
            Console.WriteLine(current);
        }
    }
}
