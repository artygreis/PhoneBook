using System.Collections.Generic;
using System.ComponentModel;

namespace PhoneBook.Types
{
    public class Address
    {
        public int Id { get; set; }
        [DisplayName("Населенный пункт")]
        public string Locality { get; set; }
        [DisplayName("Название")]
        public string StreetName { get; set; }
        [DisplayName("Дом")]
        public string House { get; set; }

        public int? TypeStreetId { get; set; }
        public TypeStreet TypeStreet { get; set; }

        public List<City> Cities { get; set; }
        public List<NumberPhone> NumberPhones { get; set; }
    }
}
