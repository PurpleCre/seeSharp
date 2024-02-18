using System;
using System.Reflection.Metadata;

public class Borrower : Person
{
    private bool _member = false;
    private List<Book> _books;

    public Borrower(string fname, string lname, int age) : base(fname, lname, age)
    {
        _books = new List<Book>();
    }

    public override void Display()
    {
        base.Display();
    }

    public void Subscribe()
    {
        _member = true;
    }

    public bool IsMember()
    {
        return _member;
    }

    public void Borrow(Book book)
    {
        _books.Add(book);
    }

    public void ReturnBook(Book book)
    {
        foreach (Book book1 in _books)
        {
            if (book1 == book)
                _books.Remove(book1);
        }
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}