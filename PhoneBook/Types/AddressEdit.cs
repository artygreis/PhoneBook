using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    class AddressEdit
    {
        public int Id { get; set; }
        [Display(Name = "Населенный пункт")]
        public string Locality { get; set; }
        public int TypeStreetId { get; set; }
        [Display(Name = "Тип улицы")]
        public string TypeStreetName { get; set; }
        [Display(Name = "Название улицы")]
        public string StreetName { get; set; }
        [Display(Name = "Дом")]
        public string House { get; set; }
    }
}
