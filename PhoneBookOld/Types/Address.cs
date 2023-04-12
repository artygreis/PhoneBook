using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Населенный пункт")]
        public string Locality { get; set; }
        [Display(Name = "Название")]
        public string StreetName { get; set; }
        [Display(Name = "Дом")]
        public string House { get; set; }

        public int TypeStreetId { get; set; }
        public TypeStreet TypeStreet { get; set; }

        public List<City> Cities { get; set; } = new List<City>();

        public List<NumberPhone> NumberPhones { get; set; } = new List<NumberPhone>();
    }
}
