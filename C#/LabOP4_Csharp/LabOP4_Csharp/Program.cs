using System;

namespace LabOP4_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double k = 1;
            double d = 1;
            for (int i = 0; i < n; i++)
            {
                d *= k / ++k;
                k++;
            }
            Console.WriteLine(d);
        }
    }
}
