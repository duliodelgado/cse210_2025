// Scripture Memorizer – main loop
// Made by Dulio Delgado

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, verseText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress <Enter> to hide words or type 'quit' to exit.");
            string input = Console.ReadLine() ?? "";

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                break;

            scripture.HideRandomWords();
        }

        Console.WriteLine("\nFinished! Press any key to exit.");
        Console.ReadKey();
    }
}