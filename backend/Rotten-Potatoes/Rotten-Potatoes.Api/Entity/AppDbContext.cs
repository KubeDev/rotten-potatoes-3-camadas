using Microsoft.EntityFrameworkCore;
using Rotten_Potatoes.Domain.Models;

namespace Rotten_Potatoes.Api.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

