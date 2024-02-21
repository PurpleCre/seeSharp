using System;
using System.Reflection.Metadata;

public class Staff
{
    private List<Librarian> _librarians;

    public Staff()
    {
        _librarians = new List<Librarian>();
    }

    public void AddLibrarian(Librarian librarian)
    {
        _librarians.Add(librarian);
    }
    public void RemoveLibrarian(Librarian librarian)
    {
        _librarians.Remove(librarian);
    }

    public List<Librarian> GetLibrarians()
    {
        return _librarians;
    }
}