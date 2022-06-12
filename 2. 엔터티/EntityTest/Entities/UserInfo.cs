using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Entities;

[Table(nameof(UserInfo))]
public class UserInfo
{
    [Key]
    public string Id { get; set; }

    public UserInfo(string id)
    {
        Id = id;
    }

    public IList<Todo> Todos { get; set; } = default!;
    public UserDetail Detail { get; set; } = default!;
}
