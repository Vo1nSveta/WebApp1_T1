using Microsoft.EntityFrameworkCore;

namespace WebApp1_T1.Data
{
    public class MyAppContext : DbContext
    {
        public DbSet<Workshop> Workshop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = Workshop.db");
            }
        }
    }
}
