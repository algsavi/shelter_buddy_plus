using Microsoft.EntityFrameworkCore;
using ShelterBuddy.CodePuzzle.Api.Models;

namespace ShelterBuddy.CodePuzzle.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AnimalModel> Animals { get; set; }
    }
}