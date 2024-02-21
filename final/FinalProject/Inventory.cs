using System;
using System.Reflection.Metadata;

public class Inventory
{
    private List<Book> _books;

    public Inventory()
    {
        _books = new List<Book>();
    }

    public void Display()
    {
        int num = 0;
        foreach (Book book in _books)
        {
            num++;
            Console.WriteLine($"{num}. {book.GetShortDisplay()}\n{book.GetBorrower().GetFullName()}");
        }
    }

    public void ShortDisplay()
    {
        int num = 0;
        foreach (Book book in _books)
        {
            num++;
            Console.Write($"{num}. ");
            book.Display();
        }
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public List<Book> SearchByGenre(string searchTerm)
    {
        List<Book> books = new List<Book>();
        int num = 0;
        foreach (Book book in _books)
        {
            if (book.GetGenre().ToLower() == searchTerm.ToLower())
            {
                num++;
                Console.Write($"{num}. ");
                Console.WriteLine(book.GetShortDisplay());
                books.Add(book);
            }
        }

        return books;
    }

    public List<Book> GetBooks()
    {
        return _books;
    }

    public Book GetBook()
    {
        Console.WriteLine("Select book: ");
        ShortDisplay();
        Console.Write("> ");
        string rsp = Console.ReadLine();
        int idx = int.Parse(rsp) - 1;

        return _books[idx];
    }
    public void AddToLibrary(Person librarian)
    {
        foreach (Book book in _books)
        {
            book.LendTo(librarian);
        }
    }
    public string GetStringRepresentation()
    {
        return "";
    }

}