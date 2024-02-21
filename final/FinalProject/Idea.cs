using System;
using System.Reflection.Metadata;

public class Idea
{
    protected string _promptText;
    protected string _title;
    protected string _type;
    protected string _subType;
    protected string _briefIntro;
    protected string _ideaText;
    protected string _date;
    protected string _weight;
    protected PromptGenerator gen;


    public Idea()
    {
        _type = "generic";
        gen = new PromptGenerator(_type);
        gen.AddPrompts();
    }

    public Idea(string type, string subType, string weight, string title, string intro, string idea, string date)
    {
        _type = type;
        _subType = subType;
        _weight = weight;
        _title = title;
        _briefIntro = intro;
        _ideaText = idea;
        _date = date;

        gen = new PromptGenerator(_type);
        gen.AddPrompts();
    }

    public virtual void SetData()
    {
        Console.WriteLine($"Prompt: {_promptText}");

        Console.Write("Title: ");
        _title = Console.ReadLine();

        Console.Write("SubType: ");
        _subType = Console.ReadLine();

        Console.Write("Intro: ");
        _briefIntro = Console.ReadLine();

        Console.Write("Idea Weight: ");
        _weight = Console.ReadLine();

        Console.Write("\nIdea (Go wild!): ");
        _ideaText = Console.ReadLine();

        Console.WriteLine("Idea captured, you're rocking");
        _date = DateTime.Now.ToString();
    }

    public void SetPrompt()
    {
        _promptText = gen.GeneratePrompt();
    }

    public string ShowType()
    {
        return _type;
    }

    public string Display()
    {
        string text = $"{_title} ({_type}:{_subType})\n{_briefIntro}";
        return text;
    }

    public virtual void ShowIdea()
    {
        string text = $"{_title} ({_type}:{_subType})\n{_ideaText}\n";
        Console.WriteLine(text);
    }

    public virtual void AddExtraStuff()
    {

    }
    public virtual void SaveExtraStuff()
    {

    }
    public virtual string GetStringRepresentation()
    {
        string rep = $"{_type}|{_weight}|{_subType}{_weight}|{_title}|{_briefIntro}|{_ideaText}|{_date}";
        return rep;
    }

}