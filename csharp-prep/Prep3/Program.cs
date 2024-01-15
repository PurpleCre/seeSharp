using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool play = true;

        do
        {
            int magicNum = randomGenerator.Next(1, 100);

            string usrGuess = "";
            int guess = 0;
            int guesses = 0;

            do
            {
                Console.Write("Guess the number: ");
                usrGuess = Console.ReadLine();
                guess = int.Parse(usrGuess);
                guesses += 1;

                if (guess < magicNum)
                {
                    Console.WriteLine("Guess higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Guess lower");
                }
                else if (guess == magicNum)
                {
                    Console.WriteLine($"You guesed it in {guesses} attempts!");
                    Console.WriteLine();
                    Console.Write("Would you like to play again? Y/N ");
                    string response = Console.ReadLine();

                    if (response.ToUpper() == "N")
                    {
                        play = false;
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing.");
                    }
                }
            } while (!(guess == magicNum));


        } while (play);

    }
}