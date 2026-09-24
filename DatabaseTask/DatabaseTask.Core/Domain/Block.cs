using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public int block_id { get; set; }

        // FK -> Prison
        public int prison_id { get; set; }

        [ForeignKey(nameof(prison_id))]
        public Prison prison { get; set; } = null!;

        public int number { get; set; }

        [MaxLength(50)]
        public string name { get; set; } = null!;
        public int security_level { get; set; }

        public ICollection<Chamber> chambers { get; set; } = new List<Chamber>();
    }
}
