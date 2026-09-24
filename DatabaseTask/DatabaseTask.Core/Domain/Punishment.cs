using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Punishment
    {
        [Key]
        public int punishment_id { get; set; }

        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        [MaxLength(60)]
        public string punishment_type { get; set; } = null!;

        public ICollection<Prisoners> prisoners { get; set; } = new List<Prisoners>();
    }
}
