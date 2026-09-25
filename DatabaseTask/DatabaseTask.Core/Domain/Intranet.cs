using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Intranet
    {
        [Key]
        public int IntranetID { get; set; }

        public int? EmployeeID { get; set; }

        public int? CompanyID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee? Employee { get; set; }

        [ForeignKey(nameof(CompanyID))]
        public Company? Company { get; set; }

        public ICollection<Office> Offices { get; set; } = new List<Office>();

        public ICollection<Anonymous> Anonymouses { get; set; } = new List<Anonymous>();
    }
}