using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Chamber
    {
        [Key]
        public int chamber_id { get; set; }

        // FK -> Block
        public int block_id { get; set; }

        [ForeignKey(nameof(block_id))]
        public Block block { get; set; } = null!;

        public int number { get; set; }
        public int floor { get; set; }
        public int maximum_capacity { get; set; }

        public ICollection<Prisoners> prisoners { get; set; } = new List<Prisoners>();
    }
}
