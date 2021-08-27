using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using System.Windows.Forms;
using PhoneBook.Types;

namespace PhoneBook.UserControls
{
    public partial class UC_GridPhones : UserControl
    {
        public GridSelectionMode SelectionModeGrid
        {
            set
            {
                if (value != 0)
                    generalViewGrid.SelectionMode = value;
                else
                    generalViewGrid.SelectionMode = GridSelectionMode.Single;
            }
        }
        public SelectionUnit SelectionUnitGrid
        {
            set
            {
                if (value != 0)
                    generalViewGrid.SelectionUnit = value;
                else
                    generalViewGrid.SelectionUnit = SelectionUnit.Row;
            }
        }

        public SfDataGrid DataGrid
        {
            get
            {
                return generalViewGrid;
            }
        }
        public UC_GridPhones()
        {
            InitializeComponent();
            
            //NumberPhoneDataGrid.AutoGenerateColumns = false;
        }
    }
}
