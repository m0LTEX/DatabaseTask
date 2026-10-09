using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Varav
    {
        [Key]
        public int Id { get; set; }

        public int VaravaNumber { get; set; }

        [MaxLength(100)]
        public string Asukoht { get; set; }

        [MaxLength(100)]
        public string MaxLennukiSuurus { get; set; }

        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public ICollection<Lend> Lennud { get; set; } = new List<Lend>();
    }
}