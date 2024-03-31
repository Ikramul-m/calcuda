using System;

class UsefullTools
{
    public static void SayHi(string name)
    {
        Console.WriteLine("Hello " + name);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        UsefullTools.SayHi("Mike Tyson");
    }
}

