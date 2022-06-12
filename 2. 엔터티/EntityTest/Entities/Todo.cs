using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Entities;

[Table(nameof(Todo))]
public class Todo
{
    [Key]
    public int Seq { get; set; }

    public UserInfo User { get; set; } = default!;
}
