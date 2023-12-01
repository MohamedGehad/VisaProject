using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
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
        public DbSet<CountryDayCost> countryDayCosts { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Turky> Turky { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<validation> Validations { get; set; }
        public DbSet<UserValidation> userValidations  { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Image>()
                .HasIndex(E => E.UserId).IsUnique();


            modelBuilder.Entity<Armina>()
        .HasIndex(E => E.ImageId).IsUnique();

            modelBuilder.Entity<Bahrain>()
        .HasIndex(E => E.ImageId).IsUnique();

            modelBuilder.Entity<Turky>()
        .HasIndex(E => E.ImageId).IsUnique();

            modelBuilder.Entity<User>()
        .HasOne(e => e.CountryFrom)
        .WithMany()
        .HasForeignKey(e => e.CountryFromId)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(e => e.CountryLiveIn)
                .WithMany()
                .HasForeignKey(e => e.CountryliveInId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CountryDayCost>()
       .HasIndex(E => new {E.DayId , E.CountryId}).IsUnique();

            modelBuilder.Entity<UserValidation>().HasKey(E => new { E.UserId, E.ValidationId });



        }


    }
}
