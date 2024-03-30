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
        Book book = new Book();

        book.title = "Harry Potter";
        book.author = "JK Rowling";
        book.pages = 400;

        Console.WriteLine(book.title);
        Console.WriteLine(book.author);
        Console.WriteLine(book.pages);
    }
}
