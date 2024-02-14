using System;
using System.Collections.Generic;

// Define the base class Goal
public class Goal
{
    // Declare a protected field to store the name of the goal
    protected string name;

    // Define a constructor that takes a name as a parameter
    public Goal(string name)
    {
        this.name = name;
    }

    // Define a virtual method Display that prints the name of the goal
    public virtual void Display()
    {
        Console.WriteLine("Goal: " + name);
    }
}

// Define a derived class SimpleGoal that inherits from Goal
public class SimpleGol : Goal
{
    // Declare a private field to store the deadline of the goal
    private DateTime deadline;

    // Define a constructor that takes a name and a deadline as parameters
    public SimpleGoal(string name, DateTime deadline) : base(name)
    {
        this.deadline = deadline;
    }

    // Override the Display method to print the name and the deadline of the goal
    public override void Display()
    {
        Console.WriteLine("Simple Goal: " + name + ", Deadline: " + deadline.ToShortDateString());
    }
}

// Define a derived class EternalGoal that inherits from Goal
public class EternalGoal : Goal
{
    // Define a constructor that takes a name as a parameter
    public EternalGoal(string name) : base(name)
    {
    }

    // Override the Display method to print the name and a message of the goal
    public override void Display()
    {
        Console.WriteLine("Eternal Goal: " + name + ", This goal has no end.");
    }
}

// Define a derived class CheckListGoal that inherits from Goal
public class CheckListGoal : Goal
{
    // Declare a private field to store a list of subgoals
    private List<string> subgoals;

    // Define a constructor that takes a name and a list of subgoals as parameters
    public CheckListGoal(string name, List<string> subgoals) : base(name)
    {
        this.subgoals = subgoals;
    }

    // Override the Display method to print the name and the subgoals of the goal
    public override void Display()
    {
        Console.WriteLine("CheckList Goal: " + name + ", Subgoals:");
        foreach (string subgoal in subgoals)
        {
            Console.WriteLine("- " + subgoal);
        }
    }
}

// Declare a list called _goals containing instances of the base class Goal
List<Goal> _goals = new List<Goal>();

// Add some instances of the derived classes to the list
_goals.Add(new SimpleGoal("Learn C#", new DateTime(2023, 12, 31)));
_goals.Add(new EternalGoal("Be happy"));
_goals.Add(new CheckListGoal("Travel the world", new List<string> { "Visit Japan", "See the Eiffel Tower", "Go to Disneyland" }));

// Show a loop iterating over the _goals list calling Display on each Goal
foreach (Goal goal in _goals)
{
    goal.Display();
    Console.WriteLine();
}