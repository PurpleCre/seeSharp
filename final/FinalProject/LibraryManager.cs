using System;
using System.ComponentModel;
using System.Reflection.Metadata;

public class LibraryManager
{
    private string _user;
    private bool run = true;

    public LibraryManager()
    {

    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Leviathan library, a repository for known and arcane knowledge.\nLet's get started.\n ");

        Inventory inventory = new Inventory();
        AddInventory(inventory);

        Librarian librarian = new Librarian("John", "Hancock", 32, inventory, "day");
        Borrower borrower1 = new Borrower("Kid", "Kudd", 30);
        librarian.AddMember(borrower1);

        _user = PortalSelection(librarian);
        ShowSpinner(3);
        Console.Clear();

        do
        {
            bool loggedIn = false;

            do
            {
                foreach (Borrower borrower in librarian.GetMembers())
                {
                    if (_user.ToLower() == borrower.GetFullName().ToLower() || _user.ToLower() == librarian.GetFullName().ToLower())
                    {
                        loggedIn = true;
                    }
                    else if (_user.ToLower() != borrower.GetFullName().ToLower() && _user.ToLower() != librarian.GetFullName().ToLower())
                    {
                        loggedIn = false;
                        _user = PortalSelection(librarian);
                    }
                }
            } while (!loggedIn);

            if (_user.ToLower() == librarian.GetFullName().ToLower())
            {
                bool exit = false;
                do
                {
                    exit = false;

                    Console.Write("How can we help you Great one?\n1. View Inventory\n2. Add Member\n3. Cancel Membership\n4. View Genre\n5. Exit\n> ");
                    string rsp = Console.ReadLine();

                    if (rsp == "1")
                    {
                        Console.WriteLine("\nYor wish is my command venerated one\nHere is the inventory:\n");
                        inventory.Display();
                        Console.WriteLine("\nPress enter to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (rsp == "2")
                    {
                        Console.Clear();
                        Console.Write("Most definitely unfettered lord\n");
                        Borrower person = new Borrower();
                        person = Onboarding();
                        Console.WriteLine();

                        librarian.AddMember(person);
                    }
                    else if (rsp == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("\nWho dares offend the eternal fire cracker!?");

                        librarian.RemoveMember(librarian.GetMember());
                    }
                    else if (rsp == "4")
                    {
                        Console.Clear();
                        Console.Write("Post-haste mighty Oak\nGenre: ");
                        string genre = Console.ReadLine();

                        Console.WriteLine("\nYour books great personage:\n");
                        inventory.SearchByGenre(genre);
                        Console.WriteLine();
                    }
                    else if (rsp == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("May all your endevaours be touched by the burning light.\nLatom");
                        exit = true;
                    }
                } while (!exit);
            }
            else if (_user.ToLower() != librarian.GetFullName().ToLower())
            {
                Borrower user = new Borrower();

                foreach (Borrower member in librarian.GetMembers())
                {
                    if (_user.ToLower() == member.GetFullName().ToLower())
                    {
                        user = member;
                    }
                }

                Console.WriteLine("Welcome.\n");
                bool exit = false;
                do
                {
                    Console.WriteLine("Choose one of the following:\n1. View books\n2. Borrow book\n3. Return book.\n4. Exit\n> ");
                    string rsp = Console.ReadLine();

                    if (rsp == "1")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Here are our books:");
                        inventory.ShortDisplay();
                        Console.WriteLine();
                    }
                    else if (rsp == "2")
                    {
                        Console.Clear();
                        Book book = inventory.GetBook();
                        librarian.IssueBook(user, book);

                    }
                    else if (rsp == "3")
                    {
                        Console.Clear();
                        user.ReturnBook();
                        Console.WriteLine();
                    }
                    else if (rsp == "4")
                    {
                        Console.Clear();
                        Console.WriteLine($"Have a good day {user.GetFullName()}.");
                        exit = true;
                    }

                } while (!exit);
            }
            Console.Write("Are you done: (yes/no)\n> ");
            string rsp1 = Console.ReadLine();

            if (rsp1.ToLower() == "yes")
            {
                run = false;
            }
            else if (rsp1.ToLower() == "no")
            {
                run = true;
                _user = PortalSelection(librarian);
            }
        } while (run);
    }

    public void AddInventory(Inventory inventory)
    {
        Book book = new Book("Into the unknown", "Franklin The Loon", "Fantasy", "Death comes to all, why fear the inevitable");
        Book book1 = new Book("Am I wrong", "Vladmir Lujingo", "Thriller", "Rise unto thine hounchs and strive for more");
        Book book2 = new Book("Seven Deadly Sins", "Meliodas", "fantasy", "Join oue intrepid heroes in their adventures.");
        Book book3 = new Book("Tails", "Jemeima", "Thriller", "What becomes of a broken promise?");

        inventory.AddBook(book);
        inventory.AddBook(book1);
        inventory.AddBook(book2);
        inventory.AddBook(book3);
    }
    public string PortalSelection(Librarian librarian)
    {
        string user = "";

        Console.Write("Select Portal:\n1. Reader\n2. Staff\n> ");
        string rsp = Console.ReadLine();

        if (rsp == "1")
        {
            Console.Write("Are you new to the library? (yes/no)\n> ");
            string usrRsp = Console.ReadLine();

            if (usrRsp.ToLower() == "yes")
            {
                Borrower person = new Borrower();
                person = Onboarding();
                librarian.AddMember(person);

                user = person.GetFullName();
            }
            else if (usrRsp.ToLower() == "no")
            {
                Console.Write("Fullname: ");
                string name = Console.ReadLine();

                foreach (Borrower borrower in librarian.GetMembers())
                {
                    if (name.ToLower() == borrower.GetFullName())
                    {
                        bool stop = false;
                        do
                        {
                            Console.Write("Password: ");
                            string password = Console.ReadLine();

                            if (password == borrower.GetPassword())
                            {
                                Console.WriteLine("Welcome back!!!");
                                user = borrower.GetFullName();
                                stop = true;
                            }
                            else if (password != borrower.GetPassword())
                            {
                                Console.WriteLine("Passwords don't match, try again\n");
                                stop = false;
                            }
                        } while (!stop);
                    }
                    else if (name.ToLower() != borrower.GetFullName())
                    {
                        Console.WriteLine("User not found");
                    }
                }
            }
        }
        else if (rsp == "2")
        {
            Console.Write("Nothing is true... ");
            string phrase = Console.ReadLine();

            if (phrase.ToLower() == "everything is permitted")
            {
                Console.WriteLine("\nWelcome back Master Librarian Supreme.\nMay the force guide you to the valley beyond.\n");
                user = librarian.GetFullName();
            }
            else if (phrase.ToLower() != "everything is permitted")
            {
                Console.WriteLine("You have strayed from your path, return now or become nothing more than one of the many tales we house here\nBegone!!!\n");
            }
        }

        return user;
    }
    public Borrower Onboarding()
    {
        Console.WriteLine("Please respond to the following:");

        bool stop = false;

        Console.Write("First Name:\n> ");
        string fName = Console.ReadLine();

        Console.Write("Last Name:\n> ");
        string lName = Console.ReadLine();

        Console.Write("Age:\n> ");
        string ag = Console.ReadLine();
        int age = int.Parse(ag);

        Borrower person = new Borrower(fName, lName, age);

        do
        {
            Console.Write("\nAlmost done\n\nPlease enter Password: ");
            person.SetPassword(Console.ReadLine());

            Console.Write("Re-enter password: ");
            string password = Console.ReadLine();

            ShowSpinner(3);

            if (password.ToLower() == person.GetPassword())
            {
                Console.WriteLine("Password confirmed\nAccount created");
                stop = true;
            }
            else if (password.ToLower() != person.GetPassword())
            {
                Console.WriteLine("Passwords do not match");
            }
        } while (!stop);

        ShowSpinner(3);
        return person;
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