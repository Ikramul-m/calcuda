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

class ItalianChef : Chef
{
    public void makePasta()
    {
        Console.WriteLine("Make Pasta.");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.MakeChicken();
        ItalianChef italian = new ItalianChef();
        italian.MakeChicken();
        italian.makePasta();
    }
}

