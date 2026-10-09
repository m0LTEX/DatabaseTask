using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Pagas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string PagasilipikuNumber { get; set; }

        [MaxLength(40)]
        public string Kaal { get; set; }

        [MaxLength(50)]
        public string PagasiTuup { get; set; }

        public int RegistreerimiseId { get; set; }
        public Registreerimine Registreerimine { get; set; }
    }
}