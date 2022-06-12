using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApp.Entities;

[Table(nameof(UserInfo))]
public record UserInfo
{
    [Key]
    public string UserId { get; set; } = default!;
    public string UserName { get; set; } = default!;

    public virtual ICollection<TodoInfo> Todos { get; } = default!;
}
