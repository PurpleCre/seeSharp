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

    public Idea()
    {
        _type = "generic";
    }

    public virtual void Display()
    {

    }

    public virtual void SetPrompt()
    {
        PromptGenerator gen = new PromptGenerator(_type);
        gen.AddPrompts();
        _promptText = gen.GeneratePrompt();

    }

    public string ShowType()
    {
        return _type;
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

}