using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingSample.Entities;

[Table(nameof(Dept))]
public record Dept
{
    [Key]
    public string DeptId { get; set; } = default!;

    public string DeptName { get; set; } = default!;

    
    public virtual ICollection<User> Users { get; set; } = default!;
}
