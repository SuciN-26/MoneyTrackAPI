using Microsoft.EntityFrameworkCore;
using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Data
{
    public class MoneyTrackDbContext : DbContext
    {
        public MoneyTrackDbContext(DbContextOptions<MoneyTrackDbContext> ctx) : base(ctx) { }
        
        // register the classes
        public DbSet<User> Users { get; set; }
        public DbSet<TypeExpense> TypeExpenses { get; set; }
        public DbSet<CategoryExpense> CategoryExpenses { get; set; }
    }
}
