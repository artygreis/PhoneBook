﻿using Microsoft.EntityFrameworkCore;
using PhoneBook.Types;
using System.Collections.Generic;
using System.Linq;

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

                //db.Database.ExecuteSqlRaw(@"CREATE VIEW ListNumberPhone AS 
                //                            SELECT NumberPhone.CityId, NumberPhone.AddressId, Address.Locality, TypeStreet.TypeName,
                //                                    Address.StreetName, Address.House, NumberPhone.Apartment, NumberPhone.Number
                //                            FROM NumberPhone NumberPhone
                //                            INNER JOIN Address Address ON NumberPhone.AddressId = Address.Id
                //                            INNER JOIN TypeStreet TypeStreet ON Address.TypeStreetId = TypeStreet.Id");

                //db.Database.ExecuteSqlRaw(@"CREATE VIEW TypeStreetWithNameView AS 
                //                            SELECT Address.Id, Address.Locality, TypeStreet.TypeName, Address.StreetName
                //                            FROM TypeStreet TypeStreet 
                //                            INNER JOIN Address Address ON TypeStreet.Id = Address.TypeStreetId");

                var country = new Country()
                {
                    CountryName = "Беларусь",
                    CountryCode = "+375",
                    CountDigits = 12,
                    Example = "+375121234567"
                };

                db.Country.Add(country);

                var city = new City()
                {
                    CityName = "Сморгонь",
                    CityCode = "1592",
                    MaskNumber = "9-99-99",
                };

                country.Cities.Add(city);

                var typeStreets = new TypeStreet[] {
                    new TypeStreet(){ TypeName = "улица" },
                    new TypeStreet(){ TypeName = "переулок" },
                    new TypeStreet(){ TypeName = "проезд" },
                    new TypeStreet(){ TypeName = "проспект" },
                    new TypeStreet(){ TypeName = "тупик" },
                    new TypeStreet(){ TypeName = "шоссе" },
                    new TypeStreet(){ TypeName = "микрорайон" },
                    new TypeStreet(){ TypeName = "поселок" }
                };

                db.TypeStreet.AddRange(typeStreets);

                var address = new Address()
                {
                    StreetName = "Гагарина",
                    House = "10",
                    NumberPhones = new List<NumberPhone>()
                    {
                        new NumberPhone(){ Apartment = "8", Number = "1-23-45" }
                    }
                };

                typeStreets[0].Addresses.Add(address);

                address.Cities.Add(city);

                db.SaveChanges();
            }
        }
    }
}
