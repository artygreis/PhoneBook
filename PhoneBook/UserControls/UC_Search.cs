using Microsoft.EntityFrameworkCore;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.UserControls
{
    public partial class UC_Search : UserControl
    {
        public UC_Search()
        {
            InitializeComponent();
            uC_GridPhones.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            uC_GridPhones.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Any;

            LoadDataToCountry();
        }
        private void LoadDataToCountry()
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country
                    .Select(c => new CountryCollection() { Id = c.Id, CountryData = $"{c.CountryName} ({c.CountryCode})" })
                    .ToList();

                autoCompleteCountry.DataSource = countries;
                autoCompleteCountry.RefreshColumns();
                autoCompleteCountry.Columns[1].ColumnHeaderText = "Страна";
                autoCompleteCountry.Columns[1].MatchingColumn = true;
                autoCompleteCountry.Columns[0].Visible = false;
            }
        }

        private void autoCompleteCountry_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            using (var db = new ApplicationContext())
            {
                var cities = db.City
                    .Where(c => c.CountryId == Convert.ToInt32(args.ItemArray[0]))
                    .Select(c => new CityCollection() { Id = c.Id, CityData = $"{c.CityName} ({c.CityCode})" })
                    .ToList();

                autoCompleteCity.DataSource = cities;
                autoCompleteCity.RefreshColumns();
                autoCompleteCity.Columns[1].ColumnHeaderText = "Город";
                autoCompleteCity.Columns[1].MatchingColumn = true;
                autoCompleteCity.Columns[0].Visible = false;
            }
        }

        private void autoCompleteCity_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            using (var db = new ApplicationContext())
            {
                var addresses = db.City
                    .Include(c => c.Addresses)
                    .ThenInclude(t => t.TypeStreet)
                    .Where(c => c.Id == Convert.ToInt32(args.ItemArray[0]))
                    .FirstOrDefault()
                    .Addresses
                    .Select(a => new AddressCollection()
                    {
                        AddressId = a.Id,
                        DataAddress = $"{(string.IsNullOrEmpty(a.Locality) ? "" : a.Locality + ", ")}{a.TypeStreet.TypeName} {a.StreetName}"
                    })
                    .ToList();

                autoCompleteAddress.DataSource = addresses;
                autoCompleteAddress.RefreshColumns();
                autoCompleteAddress.Columns[1].ColumnHeaderText = "Адрес";
                autoCompleteAddress.Columns[1].MatchingColumn = true;
                autoCompleteAddress.Columns[0].Visible = false;
            }
        }

        private void autoCompleteAddress_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            using (var db = new ApplicationContext())
            {
                //var adresses
            }
        }
    }
}
