using Microsoft.EntityFrameworkCore;
using PhoneBook.Forms;
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
    public partial class UC_Add : UserControl
    {
        public UC_Add()
        {
            InitializeComponent();

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteAddress);

            UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            LoadDataToCountry();
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
                var temp = autoCompleteCountry.Columns.Count;
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
        /// Редактирование списка стран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCountry_Click(object sender, EventArgs e)
        {
            var editCountryForm = new EditCountry();
            if (editCountryForm.ShowDialog() == DialogResult.OK)
            {
                textBoxCountry.Text = "";
                autoCompleteCountry.DataSource = null;
                autoCompleteCountry.ResetHistory();
                ClearTextEditAndAutoComplete("autoCompleteCountry");
                LoadDataToCountry();
            }
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
                    break;
                default:
                    break;
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

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountry.Text))
            {
                MessageBox.Show("Укажите Страну.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var editCityForm = new EditCity();
                using (var db = new ApplicationContext())
                {
                    var countryId = autoCompleteCountry.GetItemArray(textBoxCountry.Text)[0];
                    editCityForm.Country = db.Country.Where(c => c.Id == Convert.ToInt32(countryId)).FirstOrDefault();
                }
                if (editCityForm.ShowDialog() == DialogResult.OK)
                {
                    textBoxCity.Text = "";
                    autoCompleteCity.DataSource = null;
                    autoCompleteCity.ResetHistory();
                    ClearTextEditAndAutoComplete("autoCompleteCity");
                    autoCompleteCountry.ActiveFocusControl = textBoxCountry;
                    autoCompleteCountry.SelectedValue = textBoxCountry.Text;
                    autoCompleteCountry.ActiveFocusControl = null;
                }
            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountry.Text) || string.IsNullOrEmpty(textBoxCity.Text))
            {
                MessageBox.Show("Укажите Страну и Город.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var editAddressForm = new EditAddress();
                using (var db = new ApplicationContext())
                {
                    var cityId = autoCompleteCity.GetItemArray(textBoxCity.Text)[0];
                    editAddressForm.City = db.City.Where(c => c.Id == Convert.ToInt32(cityId)).FirstOrDefault();
                }
                if (editAddressForm.ShowDialog() == DialogResult.OK)
                {
                    textBoxAddress.Text = "";
                    autoCompleteAddress.DataSource = null;
                    autoCompleteAddress.ResetHistory();
                    autoCompleteCity.ActiveFocusControl = textBoxCity;
                    autoCompleteCity.SelectedValue = textBoxCity.Text;
                    autoCompleteCity.ActiveFocusControl = null;
                }
            }
        }
    }
}
