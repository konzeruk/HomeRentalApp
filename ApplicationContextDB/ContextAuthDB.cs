using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationContextDB
{
    public class ContextAuthDB : DbContext
    {
        private string urlServer;

        public DbSet<AuthEntity> Auth { get; set; } = null!;

        public ContextAuthDB(string urlServer, bool create = false)
        {
            this.urlServer = urlServer;

            if (create)
                Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(urlServer);
    }
}
