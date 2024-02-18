using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

public class Book
{
    private string _title;
    private string _author;
    private string _genre;
    private string _synopsis;
    private string _status;
    private Person _borrowedBy;

    public Book(string title, string author, string genre, string synopsis)
    {
        _title = title;
        _author = author;
        _genre = genre;
        _synopsis = synopsis;
    }

    public void Display()
    {

    }

    public string IsAvailable()
    {
        return _status;
    }

    public void BorrowedBy(Person person)
    {
        _borrowedBy = person;
    }

    public Person GetBorrower()
    {
        return _borrowedBy;
    }

    public string GetStringRepresentation()
    {
        return "";
    }

    public string GetGenre()
    {
        return _genre;
    }
}
