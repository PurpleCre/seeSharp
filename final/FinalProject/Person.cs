using System;
using System.Reflection.Metadata;

public class Person
{
    private string _fName;
    private string _lName;
    protected int _age;

    public Person()
    {

    }

    public Person(string fname, string lname, int age)
    {
        _fName = fname;
        _lName = lname;
        _age = age; ;
    }

    public virtual void Details()
    {

    }

    public string GetFullName()
    {
        string fullname = $"{_lName} {_fName}";
        return fullname;
    }

    public virtual void SetPassword(string password)
    {

    }

    public virtual string GetPassword()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}