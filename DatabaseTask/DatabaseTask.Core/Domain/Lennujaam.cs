using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Lennujaam
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nimi { get; set; }

        [MaxLength(100)]
        public string Riik { get; set; }

        [MaxLength(100)]
        public string Linn { get; set; }

        public ICollection<Lend> LahteLennud { get; set; } = new List<Lend>();

        public ICollection<Lend> SihtLennud { get; set; } = new List<Lend>();
    }
}