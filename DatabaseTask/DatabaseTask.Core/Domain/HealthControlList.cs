using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthControlList
    {
        [Key]
        public int HealthControlListID { get; set; }

        public int EmployeeID { get; set; }

        [MaxLength(50)]
        public string? HealthState { get; set; }

        public DateTime? HealthControlDate { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;
    }
}
