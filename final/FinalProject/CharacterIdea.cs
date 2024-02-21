using System;
using System.Reflection.Metadata;

public class CharacterIdea : Idea
{
    private string _fullName;
    private List<string> _otherNames;
    private List<string> _features;

    public CharacterIdea() : base()
    {
        _type = "character";
        _otherNames = new List<string>();
        _features = new List<string>();

        gen = new PromptGenerator(_type);
        gen.AddPrompts();
    }

    public CharacterIdea(string type, string subType, string weight, string title, string intro, string idea, string date, string fullname) : base(type, subType, weight, title, intro, idea, date)
    {
        _fullName = fullname;
        _otherNames = new List<string>();
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

        Console.Write("Fullname: ");
        _fullName = Console.ReadLine();

        Console.Write("Intro: ");
        _briefIntro = Console.ReadLine();

        Console.Write("Idea Weight: ");
        _weight = Console.ReadLine();

        Console.Write("\nIdea (Go wild!): ");
        _ideaText = Console.ReadLine();

        bool exit = false;
        do
        {
            Console.Write("Add some identifying features (eye color and the like) type done to stop:\n> ");
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
        string text = $"{_title} ({_type}:{_subType})\n{_fullName}\n{_ideaText}";
        Console.WriteLine(text);

        int num = 0;
        int num1 = 0;

        Console.WriteLine("Other names:");
        foreach (string name in _otherNames)
        {
            num1++;
            Console.WriteLine($"{num1}. {name}");
        }

        Console.WriteLine("\nFeatures: ");
        foreach (string feature in _features)
        {
            num++;
            Console.WriteLine($"{num}. {feature}");
        }
    }
    public override void AddExtraStuff()
    {
        string fileName = _fullName + "_O";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            foreach (string name in parts)
            {
                _otherNames.Add(name);
            }
        }

        fileName = _fullName + "_f";

        lines = System.IO.File.ReadAllLines(fileName);
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
        string fileName = _fullName + "_f";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string feature in _features)
            {
                outputFile.WriteLine($"{feature}|");
            }
        }
        Console.WriteLine($"Features saved");

        fileName = _fullName + "_O";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string name in _otherNames)
            {
                outputFile.WriteLine($"{name}|");
            }
        }
        Console.WriteLine($"Other names saved");
    }

    public override string GetStringRepresentation()
    {
        string rep = $"{_type}|{_subType}|{_weight}|{_title}|{_briefIntro}|{_ideaText}|{_date}|{_fullName}";
        return rep;
    }
}