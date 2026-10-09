using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Lend> Lend { get; set; }
        public DbSet<LennuFirma> LennuFirma { get; set; }
        public DbSet<Lennujaam> Lennujaam { get; set; }
        public DbSet<Lennuk> Lennuk { get; set; }
        public DbSet<LennuStaatuseAjalugu> LennuStaatuseAjalugu { get; set; }
        public DbSet<Pagas> Pagas { get; set; }
        public DbSet<Registreerimine> Registreerimine { get; set; }
        public DbSet<Reisija> Reisija { get; set; }
        public DbSet<Terminal> Terminal { get; set; }
        public DbSet<Töötaja> Töötaja { get; set; }
        public DbSet<Varav> Varav { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lend>()
                .HasOne(l => l.LahteLennujaam)
                .WithMany(a => a.LahteLennud)
                .HasForeignKey(l => l.LahteLennujaamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Lend>()
                .HasOne(l => l.SihtLennujaam)
                .WithMany(a => a.SihtLennud)
                .HasForeignKey(l => l.SihtLennujaamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Lend>()
                .HasOne(l => l.LennuFirma)
                .WithMany(f => f.Lennud)
                .HasForeignKey(l => l.LennuFirmaId);

            modelBuilder.Entity<Lend>()
                .HasOne(l => l.Lennuk)
                .WithMany(lk => lk.Lennud)
                .HasForeignKey(l => l.LennukId);

            modelBuilder.Entity<Lend>()
                .HasOne(l => l.Varav)
                .WithMany(v => v.Lennud)
                .HasForeignKey(l => l.VaravId);

            modelBuilder.Entity<Pagas>()
                .HasOne(p => p.Registreerimine)
                .WithMany(r => r.Pagasid)
                .HasForeignKey(p => p.RegistreerimiseId);
        }
    }
}