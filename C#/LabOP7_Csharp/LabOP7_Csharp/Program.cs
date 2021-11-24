using System;

namespace LabOP7_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array Lenght");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[k];
            Console.WriteLine();
            EnterArray(ref B);
            OutArray(B);
            if (HaveNegative(B))
            {
                int maxIndex = FindMaxIndex(B);
                int minIndex = FindMinIndex(B);
                B = SwapArrayElements(B, maxIndex, minIndex);
                OutArray(B);
            }
            else
            {
                Console.WriteLine("No Negative Elements Were Found");
            }
        }
        static void EnterArray(ref int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
        }
        static void OutArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        static bool HaveNegative(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    return true;
            }
            return false;
        }
        static int FindMaxIndex(int[] array)
        {
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) 
                {
                    if(maxIndex == -1)
                    {
                        maxIndex = i;
                    }
                    else
                    {
                        if (array[i] > array[maxIndex]) 
                        {
                            maxIndex = i;
                        }
                    }
                }
            }
            Console.WriteLine("maxindex: " + maxIndex + " value: " + array[maxIndex]);
            return maxIndex;
        }
        static int FindMinIndex(int[] array)
        {
            int minIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (minIndex == -1)
                    {
                        minIndex = i;
                    }
                    else
                    {
                        if (array[i] < array[minIndex])
                        {
                            minIndex = i;
                        }
                    }
                }
            }
            Console.WriteLine("minIndex: " + minIndex + " value: " + array[minIndex]);
            return minIndex;
        }
        static int[] SwapArrayElements(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
    }
}
