using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        public int? OfficeID { get; set; }

        public int? IntranetID { get; set; }

        [ForeignKey(nameof(OfficeID))]
        public Office? Office { get; set; }

        [ForeignKey(nameof(IntranetID))]
        public Intranet? Intranet { get; set; }
    }
}
