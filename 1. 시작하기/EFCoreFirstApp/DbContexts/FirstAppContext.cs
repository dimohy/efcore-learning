using EFCoreFirstApp.Entities;

using Microsoft.EntityFrameworkCore;

namespace EFCoreFirstApp.DbContexts;

public class FirstAppContext : DbContext
{
    public DbSet<LogHistory> LogHistories => Set<LogHistory>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // "database.db" 파일로 SQLite 사용
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // LogHistory의 키인 `Seq`는 자동 증가로 설정
        modelBuilder.Entity<LogHistory>()
            .Property(x => x.Seq)
            .ValueGeneratedOnAdd();
    }
}
