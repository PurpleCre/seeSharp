public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    
    public void Display()
    {
        Console.Write("How would you describe you current mood?\n> ");
        _mood = Console.ReadLine(); 
        
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();

        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
    }
}