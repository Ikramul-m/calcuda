using System;

class Book
{
    public string title;
    public string author;
    public int pages;
}

class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "Harry Potter";
        book1.author = "Ikram";
        book1.pages = 69;

        Console.WriteLine("Book Name -->   " + book1.title);
        Console.WriteLine("Author -->   " + book1.author);
        Console.WriteLine("Pages -->   " + book1.pages);

    }
}

