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
        Book book1 = new Book("Harry Potter", "J.K Rowling", 400);
        Console.Write(book1.title + " " + book1.author + " " + book1.pages);

    }
}

