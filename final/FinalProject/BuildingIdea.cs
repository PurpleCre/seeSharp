using System;
using System.Reflection.Metadata;

public class BuildingIdea : Idea
{
    private string _use;
    private string _location;
    private List<string> _features;

    public BuildingIdea()
    {
        _type = "building";
        _features = new List<string>();

        gen = new PromptGenerator(_type);
        gen.AddPrompts();
    }

    public BuildingIdea(string type, string subType, string weight, string title, string intro, string idea, string date, string use, string location) : base(type, subType, weight, title, intro, idea, date)
    {
        _use = use;
        _location = location;
        _features = new List<string>();

        gen = new PromptGenerator(_type);
        gen.AddPrompts();
    }

    public override void SetData()
    {
        Console.WriteLine($"Prompt: {_promptText}");

        Console.Write("Title: ");
        _title = Console.ReadLine();

        Console.Write("SubType (press ENTER if none): ");
        _subType = Console.ReadLine();

        Console.Write("Intro: ");
        _briefIntro = Console.ReadLine();

        Console.Write("Idea Weight: ");
        _weight = Console.ReadLine();

        Console.Write("What is the buildings main use: ");
        _use = Console.ReadLine();

        Console.Write("Where is it located: ");
        _location = Console.ReadLine();

        Console.Write("\nIdea (Go wild!): ");
        _ideaText = Console.ReadLine();

        bool exit = false;
        do
        {
            Console.Write("Add some distinguishing features (towers, spires and the like) type done to stop:\n> ");
            string feature = Console.ReadLine();

            if (feature.ToLower() != "done")
            {
                _features.Add(feature);
            }
            else
            {
                exit = true;
            }
        } while (!exit);

        Console.WriteLine("Idea captured, you're rocking");
        _date = DateTime.Now.ToString();
    }

    public override void ShowIdea()
    {
        string text = $"{_title} ({_type}:{_subType})\n{_location}\n{_use}\n{_ideaText}";
        Console.WriteLine(text);

        int num = 0;

        Console.WriteLine("\nFeatures: ");
        foreach (string feature in _features)
        {
            num++;
            Console.WriteLine($"{num}. {feature}");
        }
    }

    public override void AddExtraStuff()
    {
        string fileName = _title + "_f";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            foreach (string feature in parts)
            {
                _features.Add(feature);
            }
        }
    }

    public override void SaveExtraStuff()
    {
        string fileName = _title + "_f";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string feature in _features)
            {
                outputFile.WriteLine($"{feature}|");
            }
        }
        Console.WriteLine($"Features saved");
    }
    public override string GetStringRepresentation()
    {
        string rep = $"{_type}|{_subType}|{_weight}|{_title}|{_briefIntro}|{_ideaText}|{_date}|{_use}|{_location}";
        return rep;
    }
}