using System;

namespace LabOP8_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Matrix Height");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Matrix Width");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            A = FillMatrix(n, m, A);
            OutMatrix(n, m, A);
            int[] vector = CreateVector(n, m, A);
            Console.WriteLine("Not Sorted Array:");
            OutArray(vector);
            vector = ArraySort(vector);
            Console.WriteLine("Sorted Array:");
            OutArray(vector);
        }
        static int[,] FillMatrix(int n, int m, int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            return matrix;
        }
        static void OutMatrix(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int[] CreateVector(int n, int m, int[,] matrix)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j];
                }
                vector[i] = sum / m;
            }
            return vector;
        }
        static int[] ArraySort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        array = SwapArrayElements(array, i, j);
                    }
                }
            }
            return array;
        }
        static int[] SwapArrayElements(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
        static void OutArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
