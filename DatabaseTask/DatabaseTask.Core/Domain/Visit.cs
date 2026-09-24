using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public int visit_id { get; set; }

        // FK -> Guards
        public int guards_id { get; set; }

        [ForeignKey(nameof(guards_id))]
        public Guards guards { get; set; } = null!;

        // FK -> Prisoners
        public int prisoner_id { get; set; }

        [ForeignKey(nameof(prisoner_id))]
        public Prisoners prisoner { get; set; } = null!;

        public DateTime date { get; set; }
        public int start_time { get; set; }
        public int finish_time { get; set; }

        [MaxLength(60)]
        public string visiting_status { get; set; } = null!; 
        
    }
}
