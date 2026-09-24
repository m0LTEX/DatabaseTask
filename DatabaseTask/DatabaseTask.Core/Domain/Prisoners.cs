using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Prisoners
    {
        [Key]
        public int prisoner_id { get; set; }

        // FK -> Chamber
        public int chamber_id { get; set; }

        [ForeignKey(nameof(chamber_id))]
        public Chamber chamber { get; set; } = null!;

        // FK -> Punishment
        public int punishment_id { get; set; }

        [ForeignKey(nameof(punishment_id))]
        public Punishment punishment { get; set; } = null!;

        // FK -> Crime
        public int crime_id { get; set; }

        [ForeignKey(nameof(crime_id))]
        public Crime crime { get; set; } = null!;
        
        [MaxLength(50)]
        public string first_name { get; set; } = null!;

        [MaxLength(50)]
        public string last_name { get; set; } = null!;
        public DateTime dob { get; set; }
        public int personal_number { get; set; }
        public DateTime arrival_date { get; set; }
        public bool prisoner_status { get; set; }

        public ICollection<Visit> visits { get; set; } = new List<Visit>();
    }
}
