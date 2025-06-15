// ---------------------------------------------------------
// Program made by Dulio
// Week 01 - C# Exercise 1
// This program asks for your name and prints it in James Bond style.
// ---------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // Ask the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print the full name in the required format
        Console.WriteLine(); // Add a blank line
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}