
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Entities;

[Table(nameof(TodoInfo))]
public record TodoInfo
{
    [Key]
    public int Seq { get; set; }

    public DateOnly? TodoDate { get; set; }
    public DateOnly? CompleteDate { get; set; }
    public bool IsComplete { get; set; }
    public string? Memo { get; set; }
    public bool IsDel { get; set; }

    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = default!;
    
    public virtual UserInfo User { get; set; } = default!;

    public virtual ICollection<TodoChangedHistory> Histories { get; } = default!;
    public virtual ICollection<TodoTagInfo> Tags { get; set; } = default!;
}
