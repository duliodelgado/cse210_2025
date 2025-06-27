// Made by Dulio Delgado
// Program.cs  – main loop
// Very small menu: press Enter to hide more words, or type “quit”.

using System;

class Program
{
    static void Main(string[] args)
    {
        // pick one scripture (easy)
        Reference ref1 = new Reference("Proverbs", 3, 5);
        string verse1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(ref1, verse1);

        Console.Clear();
        Console.WriteLine("=== Scripture Memorizer ===");
        Console.WriteLine("Press Enter to hide words or type 'quit' to finish.");
        Console.WriteLine();

        // main loop
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\n> ");
            string user = Console.ReadLine() ?? "";

            if (user.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords();
            Console.Clear();
        }

        Console.WriteLine("\nThanks for practicing your scripture!");
    }
}