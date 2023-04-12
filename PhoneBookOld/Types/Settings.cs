using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Types
{
    public class Settings : AppSettings<Settings>
    {
        public string UserSourceDb { get; set; }
        public string Password { get; set; }
    }
}
