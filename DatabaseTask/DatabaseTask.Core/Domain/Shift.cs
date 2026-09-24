using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Shift
    {
        [Key]
        public int shift_id { get; set; }

        // FK -> Guards
        public int guards_id { get; set; }

        [ForeignKey(nameof(guards_id))]
        public Guards guards { get; set; } = null!;

        public int start_time { get; set; }
        public int finish_time { get; set; }
        public DateTime date { get; set; }
    }
}
