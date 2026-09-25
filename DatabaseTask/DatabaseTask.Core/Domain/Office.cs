using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Office
    {
        [Key]
        public int OfficeID { get; set; }

        public int? IntranetID { get; set; }

        public int? CompanyID { get; set; }

        [MaxLength(20)]
        public string? AddressID { get; set; }

        [ForeignKey(nameof(IntranetID))]
        public Intranet? Intranet { get; set; }

        [ForeignKey(nameof(CompanyID))]
        public Company? Company { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}