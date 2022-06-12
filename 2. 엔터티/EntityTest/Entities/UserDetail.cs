using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Entities;

public class UserDetail
{
    [Key]
    [ForeignKey(nameof(User))]
    public string Id { get; set; } = default!;

    public string Address { get; set; } = default!;

    public UserInfo User { get; set; } = default!;
}
