using Microsoft.EntityFrameworkCore;
using LazyLoadingSample.Entities;

namespace LazyLoadingSample.DbContexts;

public class Context : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Dept> Depts => Set<Dept>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // "database.db" 파일로 SQLite 사용
        optionsBuilder.UseSqlite("Data Source=database.db")
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
