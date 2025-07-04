// ----------------------------------------------
//Journal
// Made by Dulio R. Delgado
// Menu: write / display / save / load / quit
// ----------------------------------------------
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // —— tiny FIX #1: if Console.ReadLine() comes back null, use "0"
            string input = Console.ReadLine() ?? "0";
            choice = int.Parse(input);

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                // —— tiny FIX #2: if user just hits Enter, store empty string (never null)
                string response = Console.ReadLine() ?? "";

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._text = response;

                myJournal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine() ?? "";   // null-safe
                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine() ?? "";   // null-safe
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}