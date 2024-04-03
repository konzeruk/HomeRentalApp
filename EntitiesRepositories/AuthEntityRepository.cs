using ApplicationContextDB;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntitiesRepositories
{
    public class AuthEntityRepository
    {
        private ContextAuthDB context;

        public AuthEntityRepository(string urlServer) =>
            context = new(urlServer);

        public async Task<AuthEntity?> GetUserAsync(string login, string password) =>
            await context
            .Auth
            .Where(x => x.Login == login && x.Password == password)
            .FirstOrDefaultAsync();
    }
}
