using System;
using System.Reflection.Metadata;

public class PromptGenerator
{
    private string _topic;
    private List<string> _prompts;

    public PromptGenerator(string type)
    {
        _topic = type;
        _prompts = new List<string>();
    }

    public void AddPrompts()
    {
        if (_topic == "generic")
        {
            _prompts.Add("A world where time travel is possible, but only to the past, and only for a limited duration.");
            _prompts.Add("A world where the moon is inhabited by a mysterious civilization that communicates with Earth through cryptic messages.");
            _prompts.Add("A world where time travel is possible, but only to the past, and only for a limited duration.");
            _prompts.Add("A world where magic is based on music, and different genres have different effects and rules.");
            _prompts.Add("A world where humans have colonized Mars, but a rebel faction wants to break free from Earth’s control.");
            _prompts.Add("A world where vampires and werewolves coexist with humans, but have their own secret societies and agendas.");
            _prompts.Add("A world where a cataclysmic event has wiped out most of humanity, and the survivors must scavenge and adapt to a new environment.");
            _prompts.Add("A world where dragons are real, and some people can bond with them and ride them.");
            _prompts.Add("A world where a parallel dimension exists, and people can cross over through portals or rituals.");
            _prompts.Add("A world where aliens have invaded Earth, and humans must either resist or collaborate with them.");
            _prompts.Add("A world where superheroes and supervillains are common, and the public has mixed opinions about them.");
        }
        else if (_topic == "character")
        {
            _prompts.Add("Write a character who has a distinctive physical feature. How does it affect their self-image, relationships, and goals?");
            _prompts.Add("Write a character loosely based on your best friend. What are their strengths, weaknesses, hobbies, and dreams?");
            _prompts.Add("Write a character who has an unlikely superpower. How did they discover it, and how do they use it?");
            _prompts.Add("Write a character who is secretly a fraud. What are they hiding, and why? How do they cope with the fear of being exposed?");
            _prompts.Add("Write a character who is a professional wrestler by night and a kindergarten teacher by day. How do they balance their two identities, and what challenges do they face?");
            _prompts.Add("Write a character who is a notorious thief but also a wealthy philanthropist. What are their motives, and how do they justify their actions?");
            _prompts.Add("Write a character who is a devoutly religious priest but struggles with their faith and doubts the existence of God. How do they deal with their inner conflict, and what triggers it?");
            _prompts.Add("Write a character who is a brilliant scientist but cannot hold a conversation without constantly interrupting people. How do they interact with others, and what are the consequences of their behavior?");
            _prompts.Add("Write a character who is a successful and respected doctor but is secretly struggling with a chronic illness. How do they hide their condition, and what are the risks of doing so?");
            _prompts.Add("Write a character who is a talented ballet dancer but also a tough, tattooed biker. How do they reconcile their two passions, and what are the stereotypes they face?");
        }
        else if (_topic == "building")
        {
            _prompts.Add("Design a building that is powered by a mysterious energy source. How does it look, and what are the benefits and drawbacks of using this energy?");
            _prompts.Add("Design a building that is a hybrid of two different architectural styles. How do they blend together, and what is the purpose of the building?");
            _prompts.Add("Design a building that is haunted by a ghost or a curse. How does it affect the people who live or work there, and what is the origin of the haunting?");
            _prompts.Add("Design a building that is a secret headquarters for a rebel group or a criminal organization. How is it hidden, and what are the features and facilities of the building?");
            _prompts.Add("Design a building that is a monument or a landmark for a historical event or a cultural value. How does it reflect the significance and meaning of the event or value?");
            _prompts.Add("Design a building that is a museum or a library for a specific topic or genre. What are the exhibits or collections, and how are they displayed and organized?");
            _prompts.Add("Design a building that is a temple or a shrine for a religion or a cult. How does it express the beliefs and practices of the faith, and what are the rituals and ceremonies that take place there?");
            _prompts.Add("Design a building that is a school or a university for a special field or skill. How is it structured, and what are the courses and activities that are offered there?");
            _prompts.Add("Design a building that is a factory or a laboratory for a futuristic or a fantasy technology or invention. How does it work, and what are the products or experiments that are made there?");
            _prompts.Add("Design a building that is a palace or a castle for a royal or a noble family. How does it show their status and power, and what are the secrets and intrigues that are hidden there?");
        }
    }

    public string GeneratePrompt()
    {
        if (_prompts.Count < 1)
        {
            Console.WriteLine("Fresh out of prompts, reusing old ones.");
            AddPrompts();
        }

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count - 1)];

        _prompts.Remove(prompt);

        return prompt;
    }
}