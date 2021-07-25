using Microsoft.EntityFrameworkCore;
using PhoneBook.Types;

namespace PhoneBook
{
    public class DbInitializer
    {
        public static void InitializeDb()
        {
            using (var db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                db.Database.ExecuteSqlRaw(@"CREATE VIEW ListNumberPhone AS 
                                            SELECT NumberPhone.CityId, NumberPhone.AddressId, Address.Locality, TypeStreet.TypeName,
                                                    Address.StreetName, Address.House, NumberPhone.Apartment, NumberPhone.Number
                                            FROM NumberPhone NumberPhone
                                            INNER JOIN Address Address ON NumberPhone.AddressId = Address.Id
                                            INNER JOIN TypeStreet TypeStreet ON Address.TypeStreetId = TypeStreet.Id");

                db.Database.ExecuteSqlRaw(@"CREATE VIEW TypeStreetWithNameView AS 
                                            SELECT Address.Id, Address.Locality, TypeStreet.TypeName, Address.StreetName
                                            FROM TypeStreet TypeStreet 
                                            INNER JOIN Address Address ON TypeStreet.Id = Address.TypeStreetId");

                db.Country.Add(new Country() {
                    CountryName = "Беларусь",
                    CountryCode = "+375",
                    CountDigits = 12,
                    Example = "+375121234567"
                });

                db.TypeStreet.AddRange(new TypeStreet[] {
                    new TypeStreet(){ TypeName = "улица" },
                    new TypeStreet(){ TypeName = "переулок" },
                    new TypeStreet(){ TypeName = "проезд" },
                    new TypeStreet(){ TypeName = "проспект" },
                    new TypeStreet(){ TypeName = "тупик" },
                    new TypeStreet(){ TypeName = "шоссе" },
                    new TypeStreet(){ TypeName = "микрорайон" },
                    new TypeStreet(){ TypeName = "поселок" }
                });

                db.SaveChanges();
            }
        }
    }
}
