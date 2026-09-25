using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }

        public int EmployeeID { get; set; }

        [MaxLength(200)]
        public string? RequestMessageID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;
    }
}
