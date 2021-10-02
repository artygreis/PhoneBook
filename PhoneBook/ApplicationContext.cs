using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Services;
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
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(SqliteConnection());
        }
        private SqliteConnection SqliteConnection()
        {
            var settings = Settings.Load();
            var conn = new SqliteConnection($"Data Source={settings.UserSourceDb};");
            if (!string.IsNullOrEmpty(settings.Password))
            {
                var password = CryptoService.Decrypt(settings.Password);
                conn.ConnectionString =
                    new SqliteConnectionStringBuilder(conn.ConnectionString)
                    { Password = password }
                    .ToString();
            }
            return conn;
        }
        public bool RekeyDb(string oldPassword, string newPassword)
        {
            var conn = SqliteConnection();
            try
            {
                var settings = Settings.Load();
                if (CryptoService.Decrypt(settings.Password) == oldPassword)
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "SELECT quote($newPassword);";
                    command.Parameters.AddWithValue("$newPassword", newPassword);
                    var quotedNewPassword = (string)command.ExecuteScalar();

                    command.CommandText = "PRAGMA rekey = " + quotedNewPassword;
                    command.Parameters.Clear();
                    command.ExecuteNonQuery();
                    settings.Password = CryptoService.Encrypt(newPassword);
                    settings.Save();
                    return true;
                }
                throw new Exception();
            }
            catch
            {
                return false;
            }
            finally
            {
                conn?.Close();
            }
        }
    }
}
