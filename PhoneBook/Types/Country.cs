using System.Collections.Generic;
using System.ComponentModel;

namespace PhoneBook.Types
{
    public class Country
    {
        public int Id { get; set; }
        [DisplayName("Название страны")]
        public string CountryName { get; set; }
        [DisplayName("Код страны")]
        public string CountryCode { get; set; }
        [DisplayName("Кол-во цифр в номере")]
        public int CountDigits { get; set; }
        [DisplayName("Пример")]
        public string Example { get; set; }

        public List<City> Cities { get; set; }
    }
}
