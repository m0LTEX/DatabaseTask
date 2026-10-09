using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string TöötajaNumber { get; set; }

        [MaxLength(100)]
        public string Nimi { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(100)]
        public string Ametikoht { get; set; }

        public int? TerminalId { get; set; }
        public Terminal Terminal { get; set; }
    }
}