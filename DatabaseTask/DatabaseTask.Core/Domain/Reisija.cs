using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Reisija
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nimi { get; set; }

        public DateTime Sunniaeg { get; set; }

        [MaxLength(100)]
        public string DokumendiNumber { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public ICollection<Registreerimine> Registreerimised { get; set; } = new List<Registreerimine>();
    }
}