using System;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("The result is: " + (x / y));
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

