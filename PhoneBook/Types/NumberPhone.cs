using System.ComponentModel;

namespace PhoneBook.Types
{
    public class NumberPhone
    {
        public int Id { get; set; }
        [DisplayName("Квартира")]
        public string Apartment { get; set; }
        [DisplayName("Номер телефона")]
        public string Number { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
