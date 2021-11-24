using System;

namespace LabOP2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter R1");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter R2");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            int y = Convert.ToInt32(Console.ReadLine());

            int dist = (int) (Math.Pow(x, 2) + Math.Pow(y, 2));

            if (dist >= Math.Pow(r1, 2) && dist <= Math.Pow(r2, 2))
            {
                Console.WriteLine("Point is in the circle");
            }
            else
                Console.WriteLine("Point is out of the circle");
        }
    }
}
