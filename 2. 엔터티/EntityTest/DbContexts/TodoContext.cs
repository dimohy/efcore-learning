using EntityTest.Entities;

using Microsoft.EntityFrameworkCore;

namespace EFCoreFirstApp.DbContexts;

public class TodoContext : DbContext
{
    public DbSet<UserInfo> Users => Set<UserInfo>();
    public DbSet<UserDetail> UserDetails => Set<UserDetail>();
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // "database.db" 파일로 SQLite 사용
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Todo의 키인 `Seq`는 자동 증가로 설정
        modelBuilder.Entity<Todo>()
            .Property(x => x.Seq)
            .ValueGeneratedOnAdd();
    }
}
