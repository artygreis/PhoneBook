using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.SettingsControl
{
    public class AutoCompleteSetting
    {
        public static void SetAutoCompleteSetting(AutoComplete autoComplete)
        {
            autoComplete.ShowColumnHeader = false;
            autoComplete.TextColor = Color.Black;
            autoComplete.ItemFont = new Font("Century Gothic", 10.25F);
        }
    }
}
