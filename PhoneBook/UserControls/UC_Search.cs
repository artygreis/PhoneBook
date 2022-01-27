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
using System.Text.RegularExpressions;
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

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteAddress);

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry1);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity1);

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
        private void LoadDataToCountry(AutoComplete country, TextBox textBox)
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country
                    .Select(c => new CountryCollection() { Id = c.Id, CountryData = $"{c.CountryName} ({c.CountryCode})" })
                    .ToList();

                country.DataSource = countries;
                country.RefreshColumns();
                country.Columns[1].MatchingColumn = true;
                country.Columns[0].Visible = false;

                if (countries.Count == 1)
                {
                    country.ActiveFocusControl = textBox;
                    country.SelectedValue = $"{countries.FirstOrDefault().CountryData}";
                    country.ActiveFocusControl = null;
                }
            }
        }
        private void SelectCountryAndComplete(AutoComplete country, AutoComplete city, AutoCompleteItemEventArgs args)
        {
            using (var db = new ApplicationContext())
            {
                var countryId = country.GetItemArray(args.SelectedValue)[0];
                var cities = db.City
                    .Where(c => c.CountryId == Convert.ToInt32(countryId))
                    .Select(c => new CityCollection() { Id = c.Id, CityData = $"{c.CityName} ({c.CityCode})" })
                    .ToList();
                //maskNumber = db.City.Where(c => c.CountryId == Convert.ToInt32(countryId)).FirstOrDefault()?.MaskNumber ?? "";
                city.DataSource = cities;
                city.RefreshColumns();
                city.Columns[1].MatchingColumn = true;
                city.Columns[0].Visible = false;

                if (cities.Count == 1)
                {
                    city.ActiveFocusControl = textBoxCity;
                    city.SelectedValue = $"{cities.FirstOrDefault().CityData}";
                    city.ActiveFocusControl = null;
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
            SelectCountryAndComplete(autoCompleteCountry, autoCompleteCity, args);
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

                SelectMask(Convert.ToInt32(cityId));

                autoCompleteAddress.DataSource = addresses;
                autoCompleteAddress.RefreshColumns();
                autoCompleteAddress.Columns[1].MatchingColumn = true;
                autoCompleteAddress.Columns[0].Visible = false;
            }
        }
        private void SelectMask(int cityId)
        {
            using (var db = new ApplicationContext())
                maskNumber = db.City.Where(c => c.Id == cityId).FirstOrDefault()?.MaskNumber ?? "";
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
                case "autoCompleteCountry1":
                    textBoxCity1.Text = "";
                    autoCompleteCity1.DataSource = null;
                    autoCompleteCity1.ResetHistory();
                    goto case "autoCompleteCity1";
                case "autoCompleteCity1":
                    maskedEditNumber.Text = "";
                    break;
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
            tabControlAdv_SelectedIndexChanged(tabControlAdv, new EventArgs());
            //tabControlAdv.SelectedTab = searchByAddressTab;
        }

        private void autoCompleteCountry1_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteCountry1");
            SelectCountryAndComplete(autoCompleteCountry1, autoCompleteCity1, args);
        }

        private void tabControlAdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            if (tabControlAdv.SelectedTab.Name == "searchByPhoneTab")
            {
                LoadDataToCountry(autoCompleteCountry1, textBoxCountry1);
            }
            if (tabControlAdv.SelectedTab.Name == "searchByAddressTab")
            {
                LoadDataToCountry(autoCompleteCountry, textBoxCountry);
            }
        }

        private void autoCompleteCity1_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteCity1");

            using (var db = new ApplicationContext())
            {
                var cityId = autoCompleteCity1.GetItemArray(args.SelectedValue)[0];

                SelectMask(Convert.ToInt32(cityId));

                maskedEditNumber.Mask = maskNumber;
            }
        }

        private void btnSearchByPhone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(autoCompleteCountry1.GetItemArray(textBoxCountry1.Text)?.ToString()) ||
                string.IsNullOrEmpty(autoCompleteCity1.GetItemArray(textBoxCity1.Text)?.ToString()))
            {
                MessageBox.Show("Укажите страну и город перед вводом номера телефона для поиска.",
                    "Дополнительная информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Regex regex = new Regex(@"[^0-9]");
            using (var db = new ApplicationContext())
            {
                var numberPhones = db.NumberPhoneView
                    .Where(n => n.Number == regex.Replace(maskedEditNumber.Text, ""))
                    .ToList();

                numberPhones.Sort();
                UpdateData(numberPhones);
            }

        }
    }
}
