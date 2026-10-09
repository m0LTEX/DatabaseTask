using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Registreerimine
    {
        [Key]
        public int Id { get; set; }

        public int ReisijaId { get; set; }
        public Reisija Reisija { get; set; }

        public int LendId { get; set; }
        public Lend Lend { get; set; }

        [MaxLength(10)]
        public string IsteKohaNumber { get; set; }

        public DateTime RegistreerimiseAeg { get; set; }

        [MaxLength(50)]
        public string PiletiTuup { get; set; }

        public ICollection<Pagas> Pagasid { get; set; } = new List<Pagas>();
    }
}