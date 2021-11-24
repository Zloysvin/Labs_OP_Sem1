using System;
using System.IO;

namespace LabOP1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("text.txt");
            int c = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            for (int i = 5; i < c; i++)
            {
                string a = line.Replace(";4;", ";" + i + ";");
                sw.WriteLine(a);
                sw.WriteLine();
            }
            /*int L = Convert.ToInt32(Console.ReadLine());
            int V = L * L * L;
            int S = L * L * 6;
            Console.WriteLine("Volume: " + V);
            Console.WriteLine("Square: " + S);*/
        }
    }
}
