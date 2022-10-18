namespace Domain.Models;

public class Board
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public User Creator { get; set; }
    public List<User>? Members { get; set; }

    public Board(User creator, string name)
    {
        Name = name;
        Creator = creator;
    }
}
