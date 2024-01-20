using System;
using System.ComponentModel;

// Added a mood query, added logic to handle a type error in choosing a function in the main menu.
// Added logic to ensure each prompt is only used once per session and handled the possible index out of range exception.
class Program
{
    static void Main(string[] args)
    {
        string rizz = "<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n";
        Console.WriteLine($"\n{rizz}\nHi, I'm Jemeima, your journal buddie. Let's get started.\n");

        Journal j1 = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        prompts.AddPrompts();

        bool write = new bool();
        write = true;

        do
        {
            Entry entry = new Entry();

            if (prompts._prompts.Count < 1)
            {
                Console.WriteLine("\nRefreshing prompts....");
                Console.WriteLine("...");
                Console.WriteLine("...");
                Console.WriteLine("...\n");

                prompts.AddPrompts();
            }

            Console.WriteLine("\nPlease choose one of the following:");
            Console.Write("1. Add New Entry\n2. Display Journal\n3. Save\n4. Load\n5. Stop\n> ");
            string usrResponse = Console.ReadLine();
            if (usrResponse == "1" || usrResponse == "2" || usrResponse == "3" || usrResponse == "4" || usrResponse == "5")
            {

                int response = int.Parse(usrResponse);

                if (response == 1)
                {
                    entry._promptText = prompts.GetRandomPrompt();
                    entry.Display();
                    j1.AddEntry(entry);

                    // Removes the selected prompt from the list of prompts
                    prompts._prompts.Remove(entry._promptText);
                }
                else if (response == 2)
                {
                    j1.DisplayAll();
                }
                else if (response == 3)
                {
                    Console.Write("\nfilename: ");
                    string file = Console.ReadLine();
                    j1.SaveToFile(file);
                    Console.WriteLine($"{file} saved successfully\n");
                }
                else if (response == 4)
                {
                    Console.Write("\nfilename: ");
                    string file = Console.ReadLine();
                    j1.LoadFromFile(file);
                    Console.WriteLine($"{file} successfully loaded\n");
                }
                else if (response == 5)
                {
                    write = false;
                    Console.WriteLine("\nThank you fortaking the time to tell me about your day, cheers.");
                    Console.WriteLine(rizz);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            }
            else
            {
                Console.WriteLine("\nInvalid choice, please enter a number.\n");
            }

        } while (write);
    }
}