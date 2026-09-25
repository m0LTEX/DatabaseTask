using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Children
    {
        [Key]
        public int ChildrenID { get; set; }

        public int? ParentID { get; set; }

        [MaxLength(20)]
        public string? FirstNameID { get; set; }

        [MaxLength(20)]
        public string? LastNameID { get; set; }

        public int? AgeID { get; set; }

        [ForeignKey(nameof(ParentID))]
        public Parent? Parent { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<VacationList> VacationLists { get; set; } = new List<VacationList>();
    }
}
