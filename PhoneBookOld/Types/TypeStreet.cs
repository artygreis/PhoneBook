using System.Collections.Generic;
using System.ComponentModel;

namespace PhoneBook.Types
{
    public class TypeStreet
    {
        public int Id { get; set; }
        [DisplayName("Тип локации")]
        public string TypeName { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
