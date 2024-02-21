using System;
using System.Reflection.Metadata;

public class Librarian : Person
{
    private string _shift;
    private Inventory _inventory;
    private List<Borrower> _members;

    public Librarian(string fname, string lname, int age) : base(fname, lname, age)
    {
        _members = new List<Borrower>();
    }

    public Librarian(string fname, string lname, int age, Inventory inventory, string shift) : base(fname, lname, age)
    {
        _inventory = inventory;
        _shift = shift;
        _members = new List<Borrower>();
    }

    public override void Details()
    {
        string display = $"Fullname: {GetFullName()}\nAge: {_age}\nShift: {_shift}";
        Console.WriteLine(display);
    }

    public void AddMember(Borrower person)
    {
        _members.Add(person);
    }
    public void RemoveMember(Borrower person)
    {
        Console.WriteLine($"{person.GetFullName()} banished into the badlands");
        _members.Remove(person);
    }

    public List<Borrower> GetMembers()
    {
        return _members;
    }

    public Borrower GetMember()
    {
        int num = 0;
        foreach (Borrower member in _members)
        {
            num++;
            Console.WriteLine($"{num}. {member.GetFullName()}");
        }
        Console.Write("Pick them out\n> ");
        string rsp = Console.ReadLine();
        int idx = int.Parse(rsp) - 1;

        Borrower condemned = _members[idx];

        return condemned;

    }


    public void IssueBook(Borrower borrower, Book book)
    {
        if (book.IsAvailable().ToLower() == "available")
        {
            borrower.Borrow(book);
            book.LendTo(borrower);

            Console.WriteLine($"{book.GetShortDisplay()} succesfully lent to {book.GetBorrower().GetFullName()}");

        }
        else if (book.IsAvailable().ToLower() == "borrowed")
        {
            Console.WriteLine($"{book.GetShortDisplay()} borowed by {book.GetBorrower().GetFullName()}");
        }

    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

}