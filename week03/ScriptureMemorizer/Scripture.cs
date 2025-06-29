using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;

        foreach (string part in verseText.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            _words.Add(new Word(part));
    }

    public void HideRandomWords()
    {
        int toHide = 3;
        int tries = 0;

        while (toHide > 0 && tries < 100 && !IsCompletelyHidden())
        {
            int index = _rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                toHide--;
            }
            tries++;
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
            result += w.GetDisplayText() + " ";
        return result.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
            if (!w.IsHidden())
                return false;
        return true;
    }
}