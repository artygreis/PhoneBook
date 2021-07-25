using Microsoft.EntityFrameworkCore;
using PhoneBook.Types;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<TypeStreet> TypeStreet { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<NumberPhoneView> NumberPhoneView { get; set; }
        public DbSet<TypeStreetWithNameView> TypeStreetWithNameView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<City>()
                .HasMany(a => a.Addresses)
                .WithMany(c => c.Cities)
                .UsingEntity<NumberPhone>(
                j => j
                    .HasOne(pt => pt.Address)
                    .WithMany(t => t.NumberPhones)
                    .HasForeignKey(pt => pt.AddressId),
                j => j
                    .HasOne(pt => pt.City)
                    .WithMany(p => p.NumberPhones)
                    .HasForeignKey(pt => pt.CityId),
                j =>
                {
                    j.HasKey(t => new{ t.AddressId, t.CityId });
                    j.ToTable("NumberPhone");
                }
                );

            modelBuilder
                .Entity<NumberPhoneView>((np =>
               {
                   np.HasNoKey();
                   np.ToView("NumberPhoneView");
               }));

            modelBuilder
                .Entity<TypeStreetWithNameView>((ts =>
                {
                    ts.HasNoKey();
                    ts.ToView("TypeStreetWithNameView");
                }));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["PhoneDatabase"].ConnectionString);
        }
    }
}
