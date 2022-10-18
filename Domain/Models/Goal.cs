namespace Domain.Models;

public class Goal
{
    public Guid Id { get; }
    public string Title { get; set; }
    public string Text { get; set; }
    public GoalState State { get; set; }
    public List<User>? Executors { get; set; }

    public Goal(string title, string text)
    {
        Title = title;
        Text = text;
        State = GoalState.Free;
    }
}
