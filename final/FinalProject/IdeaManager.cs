using System;
using System.Reflection.Metadata;

public class IdeaManager
{
    private List<IdeaBook> _ideaBooks;

    public IdeaManager()
    {
        _ideaBooks = new List<IdeaBook>();
    }
    public void Run()
    {
        Console.Clear();
        bool play = true;

        Console.WriteLine("Welcome to the unfettered world builder. Designed to get your creative juices flowing\n");

        string bookC = "";
        Console.Write("Would you like to:\n1. Start afresh\n2. Exit\n> ");
        bookC = Console.ReadLine();

        do
        {
            Console.Clear();

            if (bookC == "1")
            {
                bool exit = false;
                IdeaBook book = new IdeaBook();

                do
                {
                    Console.Write("Choose one of the following:\n1. Add Idea\n2. View Idea\n3. Show Ideas Of A Single Type\n4. Save Ideas\n5. Load Ideas\n6. Exit\n> ");
                    string functC = Console.ReadLine();

                    if (functC == "1")
                    {
                        Console.Clear();

                        Idea idea = CreateIdea();
                        SetData(idea);
                        book.AddIdea(idea);

                        Console.WriteLine("Idea added");

                    }
                    else if (functC == "2")
                    {
                        Console.Clear();

                        if (book.GetIdeas().Count > 0)
                        {

                            Console.WriteLine("Here's all your ideas:");
                            book.DisplayAll();

                            Console.Write("\nSelect the idea you want to view\nEnter number:> ");
                            string num = Console.ReadLine();
                            int idx = int.Parse(num) - 1;

                            book.GetIdeas()[idx].ShowIdea();
                            Console.WriteLine();
                            ShowSpinner(5);

                        }
                        else
                        {
                            Console.WriteLine("You are fresh outer ideas.");
                        }
                    }
                    else if (functC == "3")
                    {
                        Console.Clear();

                        Console.Write("Select type GENERIC, CHARACTER or BUILDING\n> ");
                        string type = Console.ReadLine();

                        if (type.ToUpper() == "GENERIC" || type.ToUpper() == "CHARACTER" || type.ToUpper() == "BUILDING")
                        {
                            book.Display(type);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection!");
                        }
                    }
                    else if (functC == "4")
                    {
                        Console.Clear();

                        book.SaveIdeas();

                        ShowSpinner(3);

                        Console.WriteLine("Ideas Saved");

                    }
                    else if (functC == "5")
                    {
                        Console.Clear();

                        book.LoadIdeas();

                        ShowSpinner(3);

                        Console.WriteLine("Ideas loaded");
                    }
                    else if (functC == "6")
                    {
                        Console.Clear();

                        Console.WriteLine("Idea book closed.");
                        exit = true;
                        play = false;
                    }

                } while (!exit);

            }
            else if (bookC == "2")
            {
                play = false;
            }
        } while (play);

    }

    public Idea CreateIdea()
    {
        Console.Write("Select template:\n1. generic\n2. character\n3. Building\n> ");
        string type = Console.ReadLine();

        Idea idea;

        if (type == "1")
        {
            idea = new Idea();
        }
        else if (type == "2")
        {
            idea = new CharacterIdea();
        }
        else if (type == "3")
        {
            idea = new BuildingIdea();
        }
        else
        {
            Console.WriteLine("Unable to identify choice, generic template chosen.");
            idea = new Idea();
        }

        return idea;
    }

    public void SetData(Idea idea)
    {
        idea.SetPrompt();
        idea.SetData();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (startTime < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }

            startTime = DateTime.Now;
        }

        Console.WriteLine();
    }
}