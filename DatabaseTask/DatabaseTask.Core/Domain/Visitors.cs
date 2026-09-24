using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Visitors
    {
        [Key]
        public int visitors_id { get; set; }

        public string name { get; set; } = null!;
        public int personal_number { get; set; }
        public string telephone_number { get; set; } = null!;

        [MaxLength(50)]
        public string relation_to_prisoner { get; set; } = null!;
    }
}
