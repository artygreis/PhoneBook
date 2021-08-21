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
                    numberPhoneViewGrid.SelectionMode = value;
                else
                    numberPhoneViewGrid.SelectionMode = GridSelectionMode.Single;
            }
        }
        public SelectionUnit SelectionUnitGrid
        {
            set
            {
                if (value != 0)
                    numberPhoneViewGrid.SelectionUnit = value;
                else
                    numberPhoneViewGrid.SelectionUnit = SelectionUnit.Row;
            }
        }

        public SfDataGrid NumberPhoneDataGrid
        {
            get
            {
                return numberPhoneViewGrid;
            }
        }
        public UC_GridPhones()
        {
            InitializeComponent();
            
            //NumberPhoneDataGrid.AutoGenerateColumns = false;
        }
    }
}
