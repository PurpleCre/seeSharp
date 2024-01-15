using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Query for percentage
        Console.Write("Enter grade percentage: ");
        string gpa = Console.ReadLine();
        int percentage = int.Parse(gpa);
        string grade = "";
        string sign = "";

        // Determining grade letter
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
            grade = "F";
        }


        // Determining the sign
        if (percentage % 10 >= 7 ) 
        {
            sign = "+";
        }
        else if (percentage % 10  < 3) 
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        // Handling sign exceptions
        if (grade == "A" && sign == "+" )
        {
            sign = "";
        }

        if (grade == "F")
        {
            sign = "";
        }

        // Grade output
        Console.WriteLine();
        Console.WriteLine($"your grade is {grade}{sign}");
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