using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class JobTypeList
    {
        [Key]
        public int JobTypeListID { get; set; }

        public int EmployeeID { get; set; }

        [MaxLength(20)]
        public string? JobID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;
    }
}
