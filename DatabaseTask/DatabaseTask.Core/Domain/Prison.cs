using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        [Key]
        public int prison_id { get; set; }

        [MaxLength(50)]
        public string name { get; set; } = null!;

        [MaxLength(50)]
        public string location { get; set; } = null!;
        public int maximum_capacity { get; set; }

        public ICollection<Guards> guards { get; set; } = new List<Guards>();
        public ICollection<Building> buildings { get; set; } = new List<Building>();
        public ICollection<Block> blocks { get; set; } = new List<Block>();
    }
}
