using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string gpa = Console.ReadLine();
        int percentage = int.Parse(gpa);
        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }

        else if (percentage >= 70)
        {
            grade = "C";
        }

        else if (percentage >= 60)
        {
            grade = "D";
        }

        else if (percentage < 60)
        {
            grade = "E";
        }

        Console.WriteLine();
        Console.WriteLine($"your grade is {grade}");
        Console.WriteLine();


        if (percentage >= 70)
        {
            Console.WriteLine("Congratulatins, you passed!!!!!!!!");
        }
        else
        {
            Console.WriteLine("You didn't meet the expectations, please do try again.");
        }

        Console.WriteLine();

    }
}