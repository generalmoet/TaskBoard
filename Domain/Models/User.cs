namespace Domain.Models;

public class User
{
	public Guid Id { get; }
	public string UserName{ get; }
	public string Email { get; }
	public List<Goal>? Goals { get; set; }
	public List<Board>? Boards { get; set; }

	public User(string userName, string email)
	{
		UserName = userName;
		Email = email;
	}
}
