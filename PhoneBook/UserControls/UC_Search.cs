using Microsoft.EntityFrameworkCore;
using PhoneBook.SettingsControl;
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

            UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteAddress);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteHouse);

            LoadDataToCountry();
        }
        private void UpdateData(List<NumberPhoneView> numberPhones)
        {
            uC_GridPhones.NumberPhoneDataGrid.DataSource = numberPhones;
            uC_GridPhones.NumberPhoneDataGrid.Columns["Locality"].Width = 150;
            uC_GridPhones.NumberPhoneDataGrid.Columns["TypeName"].Width = 80;
            uC_GridPhones.NumberPhoneDataGrid.Columns["StreetName"].Width = 180;
            uC_GridPhones.NumberPhoneDataGrid.Columns["House"].Width = 50;
            uC_GridPhones.NumberPhoneDataGrid.Columns["Apartment"].Width = 50;
        }
        /// <summary>
        /// Загрузка информации о странах
        /// </summary>
        private void LoadDataToCountry()
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country
                    .Select(c => new CountryCollection() { Id = c.Id, CountryData = $"{c.CountryName} ({c.CountryCode})" })
                    .ToList();

                autoCompleteCountry.DataSource = countries;
                autoCompleteCountry.RefreshColumns();
                autoCompleteCountry.Columns[1].MatchingColumn = true;
                autoCompleteCountry.Columns[0].Visible = false;
                if (countries.Count == 1)
                {
                    autoCompleteCountry.SelectedValue = $"{countries.FirstOrDefault().CountryData}";
                    autoCompleteCountry.ActiveFocusControl = null;
                }
            }
        }
        /// <summary>
        /// Выбор страны и формирование списка городов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void autoCompleteCountry_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteCountry");
            using (var db = new ApplicationContext())
            {
                var cities = db.City
                    .Where(c => c.CountryId == Convert.ToInt32(args.ItemArray[0]))
                    .Select(c => new CityCollection() { Id = c.Id, CityData = $"{c.CityName} ({c.CityCode})" })
                    .ToList();

                autoCompleteCity.DataSource = cities;
                autoCompleteCity.RefreshColumns();
                autoCompleteCity.Columns[1].MatchingColumn = true;
                autoCompleteCity.Columns[0].Visible = false;
            }
        }
        /// <summary>
        /// Выбор города и формирование списка адресов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void autoCompleteCity_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteCity");
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
                autoCompleteAddress.Columns[1].MatchingColumn = true;
                autoCompleteAddress.Columns[0].Visible = false;
            }
        }
        /// <summary>
        /// Выбор адреса и формирование списка домов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void autoCompleteAddress_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteHouse");
            using (var db = new ApplicationContext())
            {
                var numberHouse = db.Address
                    .Where(a => a.Id == Convert.ToInt32(args.ItemArray[0]))
                    .Select(a => a.House)
                    .ToList();

                autoCompleteHouse.DataSource = numberHouse;
                autoCompleteHouse.RefreshColumns();
                autoCompleteHouse.Columns[0].MatchingColumn = true;
            }
        }
        private void autoCompleteHouse_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteAddress");
        }
        /// <summary>
        /// Сброс данных для поиска
        /// </summary>
        /// <param name="autoComplete"></param>
        private void ClearTextEditAndAutoComplete(string autoComplete)
        {
            switch (autoComplete)
            {
                case "autoCompleteCountry": 
                    textBoxCity.Text = ""; 
                    autoCompleteCity.DataSource = null;
                    autoCompleteCity.ResetHistory();
                    goto case "autoCompleteCity";
                case "autoCompleteCity": 
                    textBoxAddress.Text = ""; 
                    autoCompleteAddress.DataSource = null;
                    autoCompleteAddress.ResetHistory();
                    goto case "autoCompleteAddress";
                case "autoCompleteAddress": 
                    textBoxHouse.Text = ""; 
                    autoCompleteHouse.DataSource = null;
                    autoCompleteHouse.ResetHistory();
                    goto case "autoCompleteHouse";
                case "autoCompleteHouse": textBoxApartment.Text = ""; break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Поиск в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(autoCompleteCountry.GetItemArray(textBoxCountry.Text)?.ToString()) ||
                string.IsNullOrEmpty(autoCompleteCity.GetItemArray(textBoxCity.Text)?.ToString()) ||
                string.IsNullOrEmpty(autoCompleteAddress.GetItemArray(textBoxAddress.Text)?.ToString()))
            {
                MessageBox.Show("Слишком большой диапазон для поиска! Укажите страну, город и адрес.",
                    "Дополнительная информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (var db = new ApplicationContext())
            {
                var addressId = Convert.ToInt32(autoCompleteAddress.GetItemArray(textBoxAddress.Text)[0]);
                var numberPhones = db.NumberPhoneView
                    .Where(n => n.AddressId == addressId)
                    .ToList();
                if (!string.IsNullOrEmpty(autoCompleteHouse.GetItemArray(textBoxHouse.Text)?.ToString()))
                {
                    numberPhones = numberPhones.Where(n => n.House == textBoxHouse.Text).ToList();
                }
                if (!string.IsNullOrEmpty(textBoxApartment.Text))
                {
                    numberPhones = numberPhones.Where(n => n.Apartment == textBoxApartment.Text).ToList();
                }
                UpdateData(numberPhones);
            }

        }
    }
}
