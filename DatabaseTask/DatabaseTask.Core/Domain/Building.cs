using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Building
    {
        [Key]
        public int building_id { get; set; }

        // FK -> Prison
        public int prison_id { get; set; }

        [ForeignKey(nameof(prison_id))]
        public Prison prison { get; set; } = null!;
    }
}
