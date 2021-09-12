using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Город")]
        public string CityName { get; set; }
        [Display(Name = "Код города")]
        public string CityCode { get; set; }
        [Display(Name = "Маска номера")]
        public string MaskNumber { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
