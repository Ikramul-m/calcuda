using System;

class Program
{
    public static void Main(string[] args)
    {
        int bbase = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());
        Console.Write(Pow(bbase, power));
    }

    static int Pow(int baseNum, int powNum)
    {
        int result = 1;

        for (int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }

        return result;
    }
}

