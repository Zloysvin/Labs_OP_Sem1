using System;

namespace LabOP9_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentance:");
            string str = Console.ReadLine();
            Console.WriteLine();
            str = ReversePairedWords(str);
            Console.WriteLine(str);
        }

        static string ReversePairedWords(string str)
        {
            string[] words = str.Split(' ');
            str = "";
            Console.WriteLine("Words that will be reversed:");
            for (int i = 0; i < words.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    str += ReverseString(words[i]) + " ";
                    Console.WriteLine(words[i] + " -> " + ReverseString(words[i]));
                }
                else
                    str += words[i] + " ";
            }
            Console.WriteLine();
            return str.Remove(str.Length - 1);
        }

        static string ReverseString(string str)
        {
            string newStr = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
