using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = {
            {1, 2},
            {3, 4}
        };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
