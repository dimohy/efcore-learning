using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Entities
{
    [Table(nameof(TodoTagInfo))]
    public class TodoTagInfo
    {
        [Key]
        public string TagId { get; set; } = default!;

        public string Descption { get; set; } = "";

        public virtual ICollection<TodoInfo> Todos { get; } = default!;
    }
}
