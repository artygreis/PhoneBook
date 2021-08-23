using PhoneBook.Types;
using System.Collections.Generic;

namespace PhoneBook.Forms
{
    public partial class EditCountry : Syncfusion.Windows.Forms.MetroForm
    {
        public EditCountry()
        {
            InitializeComponent();
            uC_GridCountries.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            uC_GridCountries.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            //GridControlSetting.SetGridControlSetting(uC_GridCountries);
            UpdateData(new List<Country>() { new Country() });
        }
        private void UpdateData(List<Country> countries)
        {
            uC_GridCountries.NumberPhoneDataGrid.DataSource = countries;
            uC_GridCountries.NumberPhoneDataGrid.Columns["Id"].Visible = false;
            uC_GridCountries.NumberPhoneDataGrid.Columns["CountryName"].Width = 150;
            uC_GridCountries.NumberPhoneDataGrid.Columns["CountryCode"].Width = 50;
            uC_GridCountries.NumberPhoneDataGrid.Columns["CountDigits"].Width = 50;
            uC_GridCountries.NumberPhoneDataGrid.Columns["Example"].Width = 150;
        }
    }
}
