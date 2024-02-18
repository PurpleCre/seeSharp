using System;
using System.Reflection.Metadata;

public class Librarian : Person
{
    private string _shift;
    private Inventory _inventory;
    private List<Borrower> _members;

    public Librarian(string fname, string lname, int age, Inventory inventory) : base(fname, lname, age)
    {
        _inventory = inventory;
        _members = new List<Borrower>();
    }

    public override void Display()
    {
        base.Display();
    }

    public void AddMember(Borrower person)
    {
        _members.Add(person);
    }
    public void RemoveMember(Borrower person)
    {
        _members.Remove(person);
    }

    public void IssueBook()
    {

    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

}