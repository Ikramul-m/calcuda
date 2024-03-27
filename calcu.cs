using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Getmax(num1, num2, num3));
    }

    static int Getmax(int a, int b, int c)
    {
        int result;
        if (a > b && a > c)
        {
            result = a;
        }
        else if (b > a && b > c)
        {
            result = b;
        }
        else
        {
            result = c;
        }

        return result;
    }


}


