// Keeps the Book + Chapter + Verse numbers

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;      // single verse (easy mode)

    // constructor (sets up the reference)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // show “Book Chapter:Verse”
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}