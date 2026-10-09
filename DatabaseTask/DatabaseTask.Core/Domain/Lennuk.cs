using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Lennuk
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Registreerimisnumber { get; set; }

        [MaxLength(100)]
        public string Mudel { get; set; }

        public int IsteKohtadeArv { get; set; }
        public int ValmistamiseAasta { get; set; }

        public ICollection<Lend> Lennud { get; set; } = new List<Lend>();
    }
}