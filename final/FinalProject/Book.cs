using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

public class Book
{
    private string _title;
    private string _author;
    private string _genre;
    private string _synopsis;
    private string _status = "Available";
    private Person _borrowedBy = new Person();

    public Book()
    {

    }
    public Book(string title, string author, string genre, string synopsis)
    {
        _title = title;
        _author = author;
        _genre = genre;
        _synopsis = synopsis;
    }

    public void Display()
    {
        string display = $"{_title} by {_author}\nGenre: {_genre}\n{_synopsis}\n";
        Console.WriteLine(display);
    }

    public string IsAvailable()
    {
        string type = _borrowedBy.GetType().ToString();

        if (type == "Librarian")
        {
            _status = "Available";
        }
        else if (type == "Borrower")
        {
            _status = "Borrowed";
        }

        return _status;
    }

    public void LendTo(Person person)
    {
        _borrowedBy = person;
    }

    public Person GetBorrower()
    {
        return _borrowedBy;
    }

    public string GetGenre()
    {
        return _genre;
    }

    public string GetShortDisplay()
    {
        string display = $"{_title} by {_author}";
        return display;
    }

    public string GetStringRepresentation()
    {
        return "";
    }

}
