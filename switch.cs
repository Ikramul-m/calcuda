using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the day number: ");
        int daynum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetDay(daynum));
    }

    static string GetDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;
            case 7:
                dayName = "Sunday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }
        return dayName;
    }
}



