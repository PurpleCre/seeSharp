using System;
using System.Reflection.Metadata;

public class Init
{
    private string _choice;
    public void Display()
    {
        ChooseProgram();

        if(_choice == "1")
        {
            Console.WriteLine("You've chosen the Idea book program.");
        }
        else if(_choice == "2")
        {
            Console.WriteLine("You've chosen the Library program.");
            
        }

    }

    public void ChooseProgram()
    {
        Console.Write("Choose One of the following:\n1. Idea Book\n2. Library\n>");
        _choice = Console.ReadLine();
    }
}