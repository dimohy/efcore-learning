using Microsoft.EntityFrameworkCore;

using TodoApp.Entities;

namespace TodoApp.DbContexts;

public class TodoContext : DbContext
{
    public DbSet<UserInfo> Users => Set<UserInfo>();
    public DbSet<TodoInfo> Todos => Set<TodoInfo>();
    public DbSet<TodoChangedHistory> TodoChangedHistories => Set<TodoChangedHistory>();
    //public DbSet<TagInfo> Tags => Set<TagInfo>();
    public DbSet<TodoTagInfo> TodoTags => Set<TodoTagInfo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // "database.db" 파일로 SQLite 사용
        optionsBuilder.UseSqlite("Data Source=database.db")
            //.AddInterceptors(new TaggedQueryCommandInterceptor());
            .LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Todo의 `Seq`키는 자동 증가
        modelBuilder.Entity<TodoInfo>()
            .Property(x => x.Seq)
            .ValueGeneratedOnAdd();

        // TodoChangedHistory는 복합키(TodoSeq, Seq)
        modelBuilder.Entity<TodoChangedHistory>()
            .HasKey(x => new { x.TodoSeq, x.Seq });
    }
}
