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
        public DbSet<NumberPhone> NumberPhone { get; set; }
        public DbSet<NumberPhoneView> NumberPhoneView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<NumberPhoneView>((np =>
               {
                   np.HasNoKey();
                   np.ToView("NumberPhoneView");
               }));

            //modelBuilder
            //    .Entity<TypeStreetWithNameView>((ts =>
            //    {
            //        ts.HasNoKey();
            //        ts.ToView("TypeStreetWithNameView");
            //    }));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["PhoneDatabase"].ConnectionString);
        }
    }
}
