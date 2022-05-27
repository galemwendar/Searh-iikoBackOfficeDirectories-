using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BackOffice> BackOffice => Set<BackOffice>();
        public DbSet<Servers> Servers => Set<Servers>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BackOffice.db");
        }

    }
}
