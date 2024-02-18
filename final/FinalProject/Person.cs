using System;
using System.Reflection.Metadata;

public class Person
{
    private string _fName;
    private string _lName;
    private int _age;

    public Person(string fname, string lname, int age)
    {
        _fName = fname;
        _lName = lname;
        _age = age; ;
    }

    public virtual void Display()
    {

    }

    public string GetFullName()
    {
        string fullname = $"{_fName} {_lName}";
        return fullname;
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}