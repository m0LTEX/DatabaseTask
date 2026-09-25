using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Anonymous
    {
        [Key]
        public int AnonymousID { get; set; }

        public int? IntranetID { get; set; }

        public int? HintID { get; set; }

        [ForeignKey(nameof(IntranetID))]
        public Intranet? Intranet { get; set; }

        [ForeignKey(nameof(HintID))]
        public Hint? Hint { get; set; }
    }
}
