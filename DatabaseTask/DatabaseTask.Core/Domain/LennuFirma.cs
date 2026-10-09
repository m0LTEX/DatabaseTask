using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class LennuFirma
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Riik { get; set; }

        [MaxLength(100)]
        public string Telefon { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public ICollection<Lend> Lennud { get; set; } = new List<Lend>();
    }
}