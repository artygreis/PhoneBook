using System.ComponentModel;

namespace PhoneBook.Types
{
    public class TypeStreetWithNameView
    {
        public int Id { get; set; }
        [DisplayName("Населенный пункт")]
        public string Locality { get; set; }
        [DisplayName("Тип локации")]
        public string TypeName { get; set; }
        [DisplayName("Название")]
        public string StreetName { get; set; }
    }
}
