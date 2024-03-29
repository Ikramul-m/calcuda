using System;

class Book
{
    public string title;
    public string author;
    public int pages;

    public Book(string aTitle, string aAuthor, int aPages)
    {
        title = aTitle;
        author = aAuthor;
        pages = aPages;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("John Wick", "Ikram", 400);
        book1.title = "yalmaz";
        Console.WriteLine(book1.title);
    }
}


