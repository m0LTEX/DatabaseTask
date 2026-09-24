using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Guards
    {
        [Key]
        public int guards_id { get; set; }

        // FK -> Prison
        public int prison_id { get; set; }

        [ForeignKey(nameof(prison_id))]
        public Prison prison { get; set; } = null!;

        [MaxLength(50)]
        public string first_name { get; set; } = null!;

        [MaxLength(50)]
        public string last_name { get; set; } = null!;
        public int worker_number { get; set; }

        [MaxLength(70)]
        public string job { get; set; } = null!; 
        

        public ICollection<Shift> shifts { get; set; } = new List<Shift>();
        public ICollection<Visit> visits { get; set; } = new List<Visit>();
    }
}
