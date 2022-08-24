using BlazorApp1.Data;

namespace BlazorApp1.Services
{
    public class UserService
    {
        public async Task AddNewUser(User user)
        {
            var context = new AppDbContext();
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<List<User>> FetchUsers()
        {
            var context = new AppDbContext();
            List<User> users = context.Users.ToList();
            return users;
        }
    }
}
