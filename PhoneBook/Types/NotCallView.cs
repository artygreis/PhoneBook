using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Types
{
    public class NotCallView
    {
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }
        [Display(Name = "Номер телефона")]
        public string Number { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Примечание")]
        public string Notes { get; set; }
        [Display(AutoGenerateField = false)]
        public int CityId { get; set; }
    }
}
