using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class LennuStaatuseAjalugu
    {
        [Key]
        public int Id { get; set; }

        public int LendId { get; set; }
        public Lend Lend { get; set; }

        [MaxLength(50)]
        public string Staatus { get; set; }

        public DateTime MuutmiseAeg { get; set; }

        [MaxLength(500)]
        public string Pohjus { get; set; }
    }
}