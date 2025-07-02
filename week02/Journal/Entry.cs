// Entry.cs
using System;   // ← para Console

public class Entry
{
    public string _date   { get; set; } = "";
    public string _prompt { get; set; } = "";
    public string _text   { get; set; } = "";

    // Muestra la entrada
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine();
    }
}