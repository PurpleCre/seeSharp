using System;
using System.Reflection.Metadata;

public class BuildingIdea : Idea
{
    private string _use;
    private string _location;
    private List<string> features;

    public BuildingIdea()
    {
        _type = "building";
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