namespace NoteApp;

public class Note
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsTicked { get; set; } = false;
    public bool IsEdit { get; set; } = false;
    public int Counter { get; set; }

    public Note(string title, string description, int counter)
    {
        Title = title;
        Description = description;
        Counter = counter;
    }
}