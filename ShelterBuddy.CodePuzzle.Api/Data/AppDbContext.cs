using Microsoft.EntityFrameworkCore;
using ShelterBuddy.CodePuzzle.Api.Models;

namespace ShelterBuddy.CodePuzzle.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AnimalModel> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=p@ssw0rd;Persist Security Info=True;User ID=sa;Initial Catalog=master;Data Source=CXJ0221\SQLEXPRESS");
        }
    }
}