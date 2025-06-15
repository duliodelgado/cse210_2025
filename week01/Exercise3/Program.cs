// ----------------------------------------------
// Program made by Dulio Delgado
// Week 1 - C# Exercise 3
// This program is a "Guess My Number" game
// The computer picks a random number between 1 and 100
// The user tries to guess it until they get it right
// ----------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // === Step 1: Create a random number generator ===
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

        // === Step 2: Create a variable for the user's guess ===
        int guess = -1;

        // === Step 3: Start the game with a loop ===
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guess = int.Parse(input); // Convert the input to a number

            // Compare the guess with the magic number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}