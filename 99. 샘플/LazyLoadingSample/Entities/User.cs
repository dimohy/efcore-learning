using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingSample.Entities;

[Table(nameof(User))]
public record User
{
    [Key]
    public string UserId { get; set; } = default!;

    public string UserName { get; set; } = default!;


    public virtual ICollection<Dept> Depts { get; set; } = default!;
}
