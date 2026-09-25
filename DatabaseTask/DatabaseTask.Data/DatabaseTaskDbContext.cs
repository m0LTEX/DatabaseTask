using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Company> Companies { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Intranet> Intranets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTypeList> JobTypeLists { get; set; }
        public DbSet<HealthControlList> HealthControlLists { get; set; }
        public DbSet<SickPapersList> SickPapersLists { get; set; }
        public DbSet<VacationList> VacationLists { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<Anonymous> Anonymouses { get; set; }
        public DbSet<Hint> Hints { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Children> Childrens { get; set; }
    }
}
