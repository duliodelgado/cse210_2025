// Comment.cs  – stores one YouTube comment
// Made by Dulio Delgado

public class Comment
{
    public string CommenterName { get; }
    public string Text          { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    public string GetDisplayText() => $"{CommenterName}: \"{Text}\"";
}