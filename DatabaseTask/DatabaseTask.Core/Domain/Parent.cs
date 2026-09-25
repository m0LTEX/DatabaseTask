using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Parent
    {
        [Key]
        public int ParentID { get; set; }

        public int? ChildrenID { get; set; }

        public int? EmployeeID { get; set; }

        [MaxLength(20)]
        public string? FirstNameID { get; set; }

        [MaxLength(20)]
        public string? LastNameID { get; set; }

        public int? AgeID { get; set; }

        [ForeignKey(nameof(ChildrenID))]
        public Children? Children { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee? Employee { get; set; }
    }
}
