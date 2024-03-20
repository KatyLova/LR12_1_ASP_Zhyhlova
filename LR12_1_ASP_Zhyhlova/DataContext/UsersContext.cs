using Microsoft.EntityFrameworkCore;
using LR12_1_ASP_Zhyhlova.Models;


namespace LR12_1_ASP_Zhyhlova.DataContext
{
    class UsersContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=C:\\sqlite3\\db1.db");
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}
