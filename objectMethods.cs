using System;

class Student
{
    public string name;
    public string major;
    public double gpa;

    public Student(string aName, string aMajor, double aGpa)
    {
        name = aName;
        major = aName;
        gpa = aGpa;
    }

    public bool HasHonors()
    {
        if (gpa >= 3.5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Lama", "English", 3.8);

        Console.WriteLine(student1.HasHonors());
        Console.WriteLine(student2.HasHonors());
    }
}



