public class UserRepository
{
    private static readonly  List<User> users = new List<User>
    {
        new User { Email = "user@example.com", Password = "password123" }
    }

    public User GetUserByEmailAndPassword(string email, string password)
    {
        return users.FirstOrDefault(u => u.Email == email && u.Password == password);
    }
}