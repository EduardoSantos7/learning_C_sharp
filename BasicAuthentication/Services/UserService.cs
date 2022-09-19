using BasicAuthentication.Models;

namespace BasicAuthentication.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        {
            new User() { Email = "fake@hotmail.com", Password = "12345" },
            new User() { Email = "fake2@hotmail.com", Password = "12345" }
        };

        public bool IsUser(string email, string password) => users.Where(d => d.Email == email && d.Password == password).Count() > 0;
    }
}