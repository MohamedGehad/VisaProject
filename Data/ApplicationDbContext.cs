using Microsoft.EntityFrameworkCore;
using VisaProject.Models;

namespace VisaProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Armina> Armina { get; set; }
        public DbSet<Bahrain> Bahrain { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<CountryDayCost> countryDayCosts    { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Turky> Turky{ get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                       .HasOne(u => u.CountryFrom)
                       .HasForeignKey(u => u.CountryFromId);

        }


    }
}
