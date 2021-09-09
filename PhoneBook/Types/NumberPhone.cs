using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NumberPhone
    {
        public int Id { get; set; }
        [Display(Name = "Квартира, №")]
        public string Apartment { get; set; }
        [Display(Name = "Номер телефона")]
        public string Number { get; set; }

        public int AddressId { get; set; }
        [Display(AutoGenerateField = false)]
        public Address Address { get; set; }
    }
}
