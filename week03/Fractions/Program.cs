// Made by Dulio Delgado
// Program.cs – tests the Fraction class

using System;

class Program
{
    static void Main(string[] args)
    {
        // --- create fractions with every constructor --------------------

        Fraction f1 = new Fraction();          // 1/1
        Fraction f2 = new Fraction(6);         // 6/1
        Fraction f3 = new Fraction(6, 7);      // 6/7

        // --- show them on the screen ------------------------------------

        DisplayFractionData("f1", f1);
        DisplayFractionData("f2", f2);
        DisplayFractionData("f3", f3);

        // --- test the setters & getters ---------------------------------

        f1.SetTop(3);       // make f1 = 3/4
        f1.SetBottom(4);

        Console.WriteLine("\nAfter changing f1 with setters:");
        Console.WriteLine($"Top via getter:    {f1.GetTop()}");
        Console.WriteLine($"Bottom via getter: {f1.GetBottom()}");
        DisplayFractionData("f1", f1);

        // --- extra fractions to match sample ----------------------------

        Fraction f4 = new Fraction(1, 3);      // 1/3
        Fraction f5 = new Fraction(5);         // 5/1

        Console.WriteLine("\nMore examples (1, 5, 3/4, 1/3):");
        DisplayFractionData("one  ", new Fraction(1));    // 1/1 → we treat “1” as 1/1
        DisplayFractionData("five ", f5);                 // 5/1
        DisplayFractionData("three-fourths", new Fraction(3, 4)); // 3/4
        DisplayFractionData("one-third", f4);             // 1/3
    }

    // Helper to print info for any Fraction object
    static void DisplayFractionData(string name, Fraction frac)
    {
        Console.WriteLine($"{name}  ->  {frac.GetFractionString()}  =  {frac.GetDecimalValue()}");
    }
}