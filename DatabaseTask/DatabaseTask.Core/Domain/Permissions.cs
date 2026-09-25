using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Permissions
    {
        [Key]
        public int PermissionsID { get; set; }

        public int? EmployeeID { get; set; }

        public int? LendingID { get; set; }

        public int? HintID { get; set; }

        public int? RequestID { get; set; }

        public int? AnonymousID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee? Employee { get; set; }

        [ForeignKey(nameof(LendingID))]
        public Lending? Lending { get; set; }

        [ForeignKey(nameof(HintID))]
        public Hint? Hint { get; set; }

        [ForeignKey(nameof(RequestID))]
        public Request? Request { get; set; }

        [ForeignKey(nameof(AnonymousID))]
        public Anonymous? Anonymous { get; set; }
    }
}
