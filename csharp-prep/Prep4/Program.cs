using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response = 0;
        int sum = 0;
        int largest = 0;

        do
        {
            Console.Write("Add a number/ Enter 0 to stop: ");
            response = int.Parse(Console.ReadLine());

            numbers.Add(response);
        } while (response != 0);

        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine($"{sum}, {number}");

            if (largest < number)
            {
                largest = number;
            }
        }

        Console.WriteLine($"Sum: {sum}");

        numbers.RemoveAt(numbers.Count - 1);
        float fSum = (float)sum;
        float fCount = (float) numbers.Count;
        float average = fSum / fCount;
        Console.WriteLine($"Average: {average}");

        Console.WriteLine($"Largest Number: {largest}");
    }
}