using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StageManagmentTwo.Entities;

namespace StageManagmentTwo
{
    public class DbContextStageManagmentTwo : DbContext
    {
        public DbContextStageManagmentTwo()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProgramStage>().Property(p => p.PriceEuro).HasPrecision(10, 2);
            modelBuilder.Entity<ProgramStage>().Property(p => p.StartPaidEuro).HasPrecision(10, 2);
            modelBuilder.Entity<ProgramStage>().Property(p => p.EndPaidEuro).HasPrecision(10, 2);
            modelBuilder.Entity<Ticket>().Property(p => p.PriceEuro).HasPrecision(10, 2);
            modelBuilder.Entity<Ticket>().Property(p => p.PayedPriceEuro).HasPrecision(10, 2);

            modelBuilder.Entity<Account>().HasIndex(u => u.Username).IsUnique();

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = 1,
                    Username = "admin",
                    HashPassword = BCrypt.Net.BCrypt.HashPassword("admin")
                }
            );

            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    ArtistCategorie = ArtistCategorie.Musiker,
                    ArtistName = "Bushido"
                });

            modelBuilder.Entity<ProgramStage>().HasData(
                new ProgramStage
                {
                    ProgramStageId = 1,
                    Name = "Junge Berliner",
                    PriceEuro = 5000,
                    StartPaidEuro = 100,
                    EndPaidEuro = 4900,
                    IsPaid = true,
                    Duration = new TimeSpan(12, 50, 23),
                    ArtistId = 1,
                });

            modelBuilder.Entity<Performance>().HasData(
                new Performance
                {
                    PerfomanceId = 1,
                    Name = "Berliner 1",
                    SartPerformance = new DateTime(2024, 09, 14, 12, 00, 00),
                    EndPerformance = new DateTime(2024, 09, 14, 00, 00, 00),
                    IsActive = true,
                    ProgramStageId = 1,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    TicketId = 1,
                    SeatNumber = 1,
                    SeatRow = SeatRow.A,
                    CustomerFirstname = "Ana",
                    CustomerLastname = "Stanisic",
                    CustomerAddress = "Hauptstrasse 83a",
                    CustomerCountry = "Feldkirch",
                    CustomerPLZ = 4854,
                    CustomerCategorie = CustomerCategorie.Normal,
                    PriceEuro = 100,
                    PayedPriceEuro = 100,
                    PerformanceId = 1,
                });
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<ProgramStage> ProgramStages { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
