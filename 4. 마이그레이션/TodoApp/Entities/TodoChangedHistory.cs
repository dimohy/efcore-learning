using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Entities
{
    [Table(nameof(TodoChangedHistory))]
    public class TodoChangedHistory
    {
        // 복합 키
        [ForeignKey(nameof(Todo))]
        public int TodoSeq { get; set; }
        public int Seq { get; set; }
        //

        public TodoChangedKind ChangedKind { get; set; }
        public string Before { get; set; } = default!;
        public string After { get; set; } = default!;

        public TodoInfo Todo { get; set; } = default!;
    }

    public enum TodoChangedKind
    {
        할일날짜변경 = 1,
        완료날짜변경 = 2,
        완료유무변경 = 3,
        메모변경 = 4,
        삭제유무변경 = 5,
    }
}
