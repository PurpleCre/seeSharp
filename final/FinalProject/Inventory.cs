using System;
using System.Reflection.Metadata;

public class Inventory
{
    private List<Book> _books;
    private bool _borrowed;

    public Inventory()
    {
        _books = new List<Book>();
    }

    public void Display()
    {

    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> Search(string searchTerm)
    {
        List<Book> books = new List<Book>();

        foreach (Book book in _books)
        {
            if (book.GetGenre() == searchTerm)
            {
                books.Add(book);
            }
        }

        return books;
    }

    public string GetStringRepresentation()
    {
        return "";
    }



}