using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Lending
    {
        [Key]
        public int LendingID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime? LendingStartID { get; set; }

        public DateTime? LendingEndID { get; set; }

        [MaxLength(50)]
        public string? LendingItems { get; set; }

        [MaxLength(200)]
        public string? LendingMessage { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;
    }
}