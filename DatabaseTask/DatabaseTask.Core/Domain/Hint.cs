using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Hint
    {
        [Key]
        public int HintID { get; set; }

        public int? AnonymousID { get; set; }

        [MaxLength(200)]
        public string? HintMessageID { get; set; }

        [ForeignKey(nameof(AnonymousID))]
        public Anonymous? Anonymous { get; set; }
    }
}
