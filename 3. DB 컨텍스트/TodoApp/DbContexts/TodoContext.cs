using Microsoft.EntityFrameworkCore;

using TodoApp.Entities;

namespace TodoApp.DbContexts;

public class TodoContext : DbContext
{
    public DbSet<UserInfo> Users => Set<UserInfo>();
    public DbSet<TodoInfo> Todos => Set<TodoInfo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // "database.db" 파일로 SQLite 사용
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Todo의 키인 `Seq`는 자동 증가로 설정
        modelBuilder.Entity<TodoInfo>()
            .Property(x => x.Seq)
            .ValueGeneratedOnAdd();
    }
}
