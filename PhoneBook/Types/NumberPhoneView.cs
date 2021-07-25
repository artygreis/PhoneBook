using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NumberPhoneView
    {
        [Display(AutoGenerateField = false)]
        public int CityId { get; set; }
        [Display(AutoGenerateField = false)]
        public int AddressId { get; set; }
        [Display(Name = "Населенный пункт")]
        public string Locality { get; set; }
        [Display(Name = "Тип")]
        public string TypeName { get; set; }
        [Display(Name = "Название улицы")]
        public string StreetName { get; set; }
        [Display(Name = "Дом")]
        public string House { get; set; }
        [Display(Name = "Кв.")]
        public string Apartment { get; set; }
        [Display(Name = "Номер телефона")]
        public string Number { get; set; }

    }
}
