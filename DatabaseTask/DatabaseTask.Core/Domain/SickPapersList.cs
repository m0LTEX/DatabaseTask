using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class SickPapersList
    {
        [Key]
        public int SickPapersListID { get; set; }

        public int EmployeeID { get; set; }

        [MaxLength(200)]
        public string? SickReasoningMessageID { get; set; }

        public DateTime? SickStart { get; set; }

        public DateTime? SickEnd { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;
    }
}
