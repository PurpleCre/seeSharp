using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to Tempest Eye.");
            Console.WriteLine();
        }
    

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favourite number? ");
            string number = Console.ReadLine();
            int favNum = int.Parse(number);
            return favNum;
        }
        
        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }
        
        static void DisplayResult (string name, int squared)
        {   
            Console.WriteLine();
            Console.WriteLine($"Dear {name}, the square of your number is {squared}");
            Console.WriteLine();
        }


        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

    }
}