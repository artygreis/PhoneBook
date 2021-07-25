using System.ComponentModel;

namespace PhoneBook.Types
{
    public class NumberPhone
    {
        public int CityId { get; set; }
        public City City { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        [DisplayName("Квартира")]
        public string Apartment { get; set; }
        [DisplayName("Номер телефона")]
        public string Number { get; set; }
    }
}
