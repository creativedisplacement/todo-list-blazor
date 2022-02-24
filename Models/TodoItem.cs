namespace TodoList.Models;

public class TodoItem
{
    public TodoItem(string? title)
    {
        Title = title;
    }
    public string? Title { get;  }
    public bool IsDone { get; set; }
}