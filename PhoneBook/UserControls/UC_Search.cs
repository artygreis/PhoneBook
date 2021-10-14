using Microsoft.EntityFrameworkCore;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
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
        private string maskNumber = "";
        public UC_Search()
        {
            InitializeComponent();
            uC_GridPhones.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            uC_GridPhones.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Any;

            UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteAddress);

            uC_GridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
        }

        private void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Number" && !string.IsNullOrEmpty(maskNumber))
            {
                e.Column = new GridMaskColumn() { MappingName = "Number", HeaderText = "Номер телефона", Mask = maskNumber };
            }
        }

        private void UpdateData(List<NumberPhoneView> numberPhones)
        {
            uC_GridPhones.DataGrid.DataSource = numberPhones;
            uC_GridPhones.DataGrid.Columns["Locality"].Width = 150;
            uC_GridPhones.DataGrid.Columns["TypeName"].Width = 80;
            uC_GridPhones.DataGrid.Columns["StreetName"].Width = 180;
            uC_GridPhones.DataGrid.Columns["House"].Width = 50;
            uC_GridPhones.DataGrid.Columns["Apartment"].Width = 50;
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
                    autoCompleteCountry.ActiveFocusControl = textBoxCountry;
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
                var countryId = autoCompleteCountry.GetItemArray(args.SelectedValue)[0];
                var cities = db.City
                    .Where(c => c.CountryId == Convert.ToInt32(countryId))
                    .Select(c => new CityCollection() { Id = c.Id, CityData = $"{c.CityName} ({c.CityCode})" })
                    .ToList();
                maskNumber = db.City.Where(c => c.CountryId == Convert.ToInt32(countryId)).FirstOrDefault()?.MaskNumber ?? "";
                autoCompleteCity.DataSource = cities;
                autoCompleteCity.RefreshColumns();
                autoCompleteCity.Columns[1].MatchingColumn = true;
                autoCompleteCity.Columns[0].Visible = false;

                if (cities.Count == 1)
                {
                    autoCompleteCity.ActiveFocusControl = textBoxCity;
                    autoCompleteCity.SelectedValue = $"{cities.FirstOrDefault().CityData}";
                    autoCompleteCity.ActiveFocusControl = null;
                }
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
                var cityId = autoCompleteCity.GetItemArray(args.SelectedValue)[0];
                var addresses = db.City
                    .Include(c => c.Addresses)
                    .ThenInclude(t => t.TypeStreet)
                    .Where(c => c.Id == Convert.ToInt32(cityId))
                    .FirstOrDefault()
                    .Addresses
                    .Select(a => new AddressCollection()
                    {
                        AddressId = a.Id,
                        DataAddress = $"{(string.IsNullOrEmpty(a.Locality) ? "" : a.Locality + ", ")}{a.TypeStreet.TypeName} {a.StreetName}, {a.House}"
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
            UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });
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
                    textBoxApartment.Text = ""; break;
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
                if (!string.IsNullOrEmpty(textBoxApartment.Text))
                {
                    numberPhones = numberPhones.Where(n => n.Apartment == textBoxApartment.Text).ToList();
                }
                numberPhones.Sort();
                UpdateData(numberPhones);
            }
        }

        private void UC_Search_Load(object sender, EventArgs e)
        {
            LoadDataToCountry();
        }
    }
}
