// ----------------------------------------------
// Program made by Dulio Delgado
// Week 1 - C# Exercise 4
// This program asks the user to enter numbers,
// stores them in a list, and then shows:
// - the sum
// - the average
// - the largest number
// ----------------------------------------------

// Required for using Lists
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Say hi to the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create the list to store the numbers
        List<int> numbers = new List<int>();

        // Start a loop to get user input
        int userNumber = -1; // start with something not 0

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            // Only add if not zero
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // === Calculate the sum ===
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // === Calculate the average ===
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // === Find the largest number ===
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}