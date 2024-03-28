using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = {
            {2 , 4 , 6 , 8},
            {1 , 3 , 5 , 7}
        };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "   ");
            }
            Console.WriteLine();
        }
    }
}

