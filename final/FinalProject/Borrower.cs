using System;
using System.Reflection.Metadata;

public class Borrower : Person
{
    private string _password;
    private bool _member = false;
    private List<Book> _books;

    public Borrower() : base()
    {
        _books = new List<Book>();
    }
    public Borrower(string fname, string lname, int age) : base(fname, lname, age)
    {
        _books = new List<Book>();
    }

    public override void Details()
    {
        string display = $"Fullname: {GetFullName()}\n Age: {_age}";

        Console.WriteLine(display);

        int num = 0;
        Console.WriteLine("Books borrowed.");
        foreach (Book book in _books)
        {
            num++;
            Console.WriteLine($"{num}. {book.GetShortDisplay()}");
        }
    }

    public void Subscribe()
    {
        Console.Write("Would you like to pay $5 for the membership card? (yes/no): ");
        string usrRsp = Console.ReadLine();

        if (usrRsp.ToLower() == "yes")
        {
            Console.WriteLine("Congrats, you are now a member, Welcom to the fold\n");
            Console.Write("Please set a password:\n> ");
            _password = Console.ReadLine();

            Console.WriteLine("\nPassword set");

            _member = true;
        }
        else if (usrRsp.ToLower() == "no")
        {
            Console.WriteLine("Be aware that books can only be borrowed for a short time at a time.");

            _member = false;
        }
        else
        {
            Console.WriteLine("Unmember like conduct");
            _member = false;
        }
    }

    public bool IsMember()
    {
        return _member;
    }

    public void Borrow(Book book)
    {
        _books.Add(book);
    }

    public void ReturnBook()
    {
        Console.WriteLine("Select Book:");
        
        int num = 0;
        foreach (Book book in _books)
        {
            num ++;
            Console.WriteLine($"{num}. {book.GetShortDisplay()}");
        }
        string rsp = Console.ReadLine();
        int idx = int.Parse(rsp) - 1;

        Console.WriteLine($"{_books[idx].GetShortDisplay()} removed");

        _books.Remove(_books[idx]);
    }

    public override void SetPassword(string password)
    {
        _password = password;
    }

    public override string GetPassword()
    {
        return _password;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}