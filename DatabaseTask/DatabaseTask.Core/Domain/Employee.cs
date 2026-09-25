using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public int? SickPapersListID { get; set; }
        public int? JobTypeListID { get; set; }
        public int? VacationListID { get; set; }
        public int? HealthControlListID { get; set; }
        public int? PermissionsID { get; set; }
        public int? AnonymousID { get; set; }
        public int? OfficeID { get; set; }
        public int? ParentID { get; set; }
        public int? ChildrenID { get; set; }

        [MaxLength(20)]
        public string? FirstNameID { get; set; }

        [MaxLength(20)]
        public string? LastNameID { get; set; }

        public int? AgeID { get; set; }

        [ForeignKey(nameof(SickPapersListID))]
        public SickPapersList? SickPapersList { get; set; }

        [ForeignKey(nameof(JobTypeListID))]
        public JobTypeList? JobTypeList { get; set; }

        [ForeignKey(nameof(VacationListID))]
        public VacationList? VacationList { get; set; }

        [ForeignKey(nameof(HealthControlListID))]
        public HealthControlList? HealthControlList { get; set; }

        [ForeignKey(nameof(PermissionsID))]
        public Permissions? Permissions { get; set; }

        [ForeignKey(nameof(AnonymousID))]
        public Anonymous? Anonymous { get; set; }

        [ForeignKey(nameof(OfficeID))]
        public Office? Office { get; set; }

        [ForeignKey(nameof(ParentID))]
        public Parent? Parent { get; set; }

        [ForeignKey(nameof(ChildrenID))]
        public Children? Children { get; set; }
    }
}
