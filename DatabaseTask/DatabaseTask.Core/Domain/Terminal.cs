using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Terminal
    {
        [Key]
        public int Id { get; set; }

        public int TerminaliNumber { get; set; }

        [MaxLength(100)]
        public string Nimetus { get; set; }

        [MaxLength(150)]
        public string Asukoht { get; set; }

        public ICollection<Varav> Varavad { get; set; } = new List<Varav>();
        public ICollection<Töötaja> Töötajad { get; set; } = new List<Töötaja>();
    }
}