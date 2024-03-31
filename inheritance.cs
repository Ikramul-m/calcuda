using System;

class Chef
{
    public void MakeChicken()
    {
        Console.WriteLine("Chef makes chicken.");
    }

    public void makeSalad()
    {
        Console.WriteLine("Chef makes salad.");
    }

    public virtual void makeSpecialDish()
    {
        Console.WriteLine("CHef makes bbq ribs.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Chef chef = new Chef();
    }
}

