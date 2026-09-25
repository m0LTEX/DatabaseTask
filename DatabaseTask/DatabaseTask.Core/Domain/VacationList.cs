using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class VacationList
    {
        [Key]
        public int VacationListID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime? VacationStartID { get; set; }

        public DateTime? VacationEndID { get; set; }

        public int? VacationDaysMaxID { get; set; }

        public int? ChildrenID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; } = null!;

        [ForeignKey(nameof(ChildrenID))]
        public Children? Children { get; set; }
    }
}