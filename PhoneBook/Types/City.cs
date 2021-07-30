using System.Collections.Generic;
using System.ComponentModel;

namespace PhoneBook.Types
{
    public class City
    {
        public int Id { get; set; }
        [DisplayName("Город")]
        public string CityName { get; set; }
        [DisplayName("Код города")]
        public string CityCode { get; set; }
        [DisplayName("Маска номера")]
        public string MaskNumber { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
