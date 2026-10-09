using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Lend
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Lennunumber { get; set; }

        public DateTime ValjumiseKuupaevJaAeg { get; set; }
        public DateTime SaabumiseKuupaevJaAeg { get; set; }

        public int LahteLennujaamId { get; set; }
        public Lennujaam LahteLennujaam { get; set; }

        public int SihtLennujaamId { get; set; }
        public Lennujaam SihtLennujaam { get; set; }

        public int LennuFirmaId { get; set; }
        public LennuFirma LennuFirma { get; set; }

        public int LennukId { get; set; }
        public Lennuk Lennuk { get; set; }

        public int VaravId { get; set; }
        public Varav Varav { get; set; }

        public ICollection<Registreerimine> Registreerimised { get; set; }
            = new List<Registreerimine>();

        public ICollection<LennuStaatuseAjalugu> StaatuseAjalugu { get; set; }
            = new List<LennuStaatuseAjalugu>();
    }
}