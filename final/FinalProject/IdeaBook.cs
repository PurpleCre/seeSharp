using System;
using System.Reflection.Metadata;

public class IdeaBook
{
    private List<Idea> _ideas;

    public IdeaBook()
    {
        _ideas = new List<Idea>();
    }

    public void AddIdea(Idea newIdea)
    {
        _ideas.Add(newIdea);
    }

    public List<Idea> GetIdeas()
    {
        return _ideas;
    }
    public void DisplayAll()
    {
        int num = 0;
        foreach (Idea idea in _ideas)
        {
            num++;
            Console.WriteLine($"{num}. {idea.Display()}\n");
        }
    }

    public void Display(string type)
    {
        // Displays only ideas of a certain type
        foreach (Idea idea in _ideas)
        {
            if (idea.ShowType() == type)
            {
                idea.ShowIdea();
            }
        }
    }

    public void SaveIdeas()
    {
        Console.Write("Enter file name:\n>");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Idea idea in _ideas)
            {
                outputFile.WriteLine(idea.GetStringRepresentation());
                idea.SaveExtraStuff();
            }
        }
        Console.WriteLine($"{fileName} saved");
    }

    public void LoadIdeas()
    {
        Console.Write("Enter file name:\n>");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string type = parts[0];

            if (type == "generic")
            {
                string sub = parts[1];
                string weight = parts[2];
                string title = parts[3];
                string intro = parts[4];
                string idea = parts[5];
                string date = parts[6];

                Idea idea1 = new Idea(type, sub, weight, title, intro, idea, date);
                _ideas.Add(idea1);
            }
            else if (type == "character")
            {
                string sub = parts[1];
                string weight = parts[2];
                string title = parts[3];
                string intro = parts[4];
                string idea = parts[5];
                string date = parts[6];
                string name = parts[7];

                CharacterIdea character = new CharacterIdea(type, sub, weight, title, intro, idea, date, name);
                character.AddExtraStuff();
                _ideas.Add(character);
            }
            else if (type == "building")
            {
                string sub = parts[1];
                string weight = parts[2];
                string title = parts[3];
                string intro = parts[4];
                string idea = parts[5];
                string date = parts[6];
                string use = parts[7];
                string location = parts[8];

                BuildingIdea building = new BuildingIdea(type, sub, weight, title, intro, idea, date, use, location);
                building.AddExtraStuff();
                _ideas.Add(building);
            }
        }

    }
}