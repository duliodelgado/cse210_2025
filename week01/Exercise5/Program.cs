// ---------------------------------------------
// Program made by Dulio Delgado
// Week 1 - C# Exercise 5
// This program practices using functions.
// It greets the user, asks their name and number,
// squares the number, and shows the result.
// ---------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // Call the welcome message
        DisplayWelcome();

        // Get the user's name
        string name = PromptUserName();

        // Get the user's favorite number
        int number = PromptUserNumber();

        // Square the number
        int square = SquareNumber(number);

        // Show the result
        DisplayResult(name, square);
    }

    // This function just shows a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // This function asks for the user's name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // This function asks for the user's favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // This function takes a number and returns the square
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // This function shows the final message with the name and square
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}