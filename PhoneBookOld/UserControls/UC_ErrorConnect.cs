using Microsoft.EntityFrameworkCore;
using PhoneBook.Forms;
using PhoneBook.Properties;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Settings = PhoneBook.Types.Settings;

namespace PhoneBook.UserControls
{
    public partial class UC_ErrorConnect : UserControl
    {
        public UC_ErrorConnect()
        {
            InitializeComponent();
        }
        private void UC_ErrorConnect_Load(object sender, EventArgs e)
        {
        }
    }
}
