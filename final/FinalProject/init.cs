using System;
using System.Reflection.Metadata;

public class Init
{
    private string _choice;
    public void Run()
    {
        bool quit = false;

        do
        {
            ChooseProgram();

            if (_choice == "1")
            {
                Console.WriteLine("You've chosen the Idea book program.");

                IdeaManager manager = new IdeaManager();
    
                manager.Run();
            }
            else if (_choice == "2")
            {
                Console.WriteLine("You've chosen the Library program.");

                LibraryManager manager = new LibraryManager();

                manager.Run();

            }
            else if (_choice == "3")
            {
                quit = true;
            }
        } while (!quit);

        Console.WriteLine("Thank you for using the Helper App by Elisium LTD a subsidiary ofEverything Consolidated.\nHave a popping day");
    }

    public void ChooseProgram()
    {
        Console.Write("Choose One of the following:\n1. Idea Book\n2. Library\n3. Close Program\n>  ");
        _choice = Console.ReadLine();
    }
}