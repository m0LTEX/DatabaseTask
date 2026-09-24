using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Crime
    {
        [Key]
        public int crime_id { get; set; }

        [MaxLength(100)]
        public string name { get; set; } = null!;

        [MaxLength(200)]
        public string description { get; set; } = null!;
        public int difficulty_level { get; set; }

        public ICollection<Prisoners> prisoners { get; set; } = new List<Prisoners>();
    }
}
