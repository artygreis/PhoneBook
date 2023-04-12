using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Название страны")]
        public string CountryName { get; set; }
        [Display(Name = "Код страны")]
        public string CountryCode { get; set; }
        [Display(Name = "Кол-во цифр в номере")]
        public int CountDigits { get; set; }
        [Display(Name = "Пример")]
        public string Example { get; set; }

        public List<City> Cities { get; set; } = new List<City>();

        public override string ToString()
        {
            return $"{CountryName} ({CountryCode})";
        }
    }
}
