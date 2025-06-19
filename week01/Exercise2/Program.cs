

// ------------------------------------------
// Program made by Dulio Delgado
// Week 01 - C# Exercise 2
// This program asks the user for a grade percentage
// and then tells them their letter grade.
// It also includes "+" and "-" for stretch practice.
// ------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // === Step 1: Ask for the grade percentage ===
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        // === Step 2: Declare variables for letter grade and sign ===
        string letter = "";
        string sign = "";

        // === Step 3: Determine the letter grade ===
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // === Step 4: Stretch Challenge - Determine + or - sign ===
        int lastDigit = percentage % 10;

        if (letter != "F")
        {
        if (lastDigit >= 7 && letter != "A")
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        }

        // === Step 5: Print the letter grade with the sign ===
        Console.WriteLine(); // Blank line for spacing
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // === Step 6: Did the user pass? ===
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep going! You’ll do better next time.");
        }
    }
}