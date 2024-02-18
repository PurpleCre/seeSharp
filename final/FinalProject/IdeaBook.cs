using System;
using System.Reflection.Metadata;

public class IdeaBook
{
    private List<Idea> _ideas;

    public IdeaBook()
    {

    }

    public void AddIdea(Idea newIdea)
    {
        _ideas.Add(newIdea);
    }

    public void DisplayAll()
    {

    }

    public void Display(string type)
    {
        // Displays only ideas of a certain type
    }

    public void SaveIdeas(string filename)
    {

    }

    public void LoadIdeas(string filename)
    {

    }
}