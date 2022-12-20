using AlifTest.Domain.Entities;
using AlifTest.Persistence.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AlifTest.Persistence.Repositories
{
    public class AlifDbContext : DbContext, IAlifDbContext
    {

        public AlifDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //entities
        public DbSet<ClientEntity> Clients { get; set; }
    }
}
