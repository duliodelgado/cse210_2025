// Video.cs  – stores title, author, length and a list of comments

using System;
using System.Collections.Generic;

public class Video
{
    public string Title     { get; set; }
    public string Author    { get; set; }
    public int    LengthSec { get; set; }

    private readonly List<Comment> _comments = new();

    public void AddComment(Comment c) => _comments.Add(c);
    public int  GetCommentCount()     => _comments.Count;

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthSec} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (Comment c in _comments)
            Console.WriteLine($"  • {c.GetDisplayText()}");
        Console.WriteLine();
    }
}