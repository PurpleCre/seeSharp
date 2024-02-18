using System;
using System.Reflection.Metadata;

public class CharacterIdea : Idea
{
    private string _fullname;
    private List<string> _otherNames;
    private List<string> _features;

    public CharacterIdea()
    {
        _type = "character";
    }

    public override void Display()
    {
        base.Display();
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

}