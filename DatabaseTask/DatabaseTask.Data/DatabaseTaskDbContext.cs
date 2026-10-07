using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

<<<<<<< HEAD
        public DbSet<Bookable> Bookable { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceOrder> ServiceOrder { get; set; }
=======
        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Guards> Guards { get; set; }
        public DbSet<Prison> Prison { get; set; }
        public DbSet<Block> Block { get; set; }

        public DbSet<Building> Building { get; set; }

        public DbSet<Chamber> Chamber { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<Prisoners> Prisoners { get; set; }
        public DbSet<Visitors> Visitors { get; set; }
        public DbSet<Punishment> Punishment { get; set; }
        public DbSet<Crime> Crime { get; set; }



>>>>>>> 80dccca5e33909e10c06392c90f13634c65f8d27

    }
}
