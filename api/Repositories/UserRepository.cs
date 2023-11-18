using api.Models;

namespace api.Repositories
{
    public class UserRepository
    {
        public static User Get(string usermail, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Joao", Email = "joao.cara@outlook.com.br", Password = "1234", Role = "manager" }
            };

            return users.FirstOrDefault(x => x.Email == usermail && x.Password == password);
        }
    }
}
