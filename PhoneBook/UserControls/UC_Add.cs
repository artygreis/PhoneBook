using Microsoft.EntityFrameworkCore;
using PhoneBook.Forms;
using PhoneBook.Properties;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PhoneBook.UserControls
{
    public partial class UC_Add : UserControl
    {
        private string maskNumber = "";
        private NumberPhoneView currentNumberPhone => uC_GridPhones.DataGrid.SelectedItem as NumberPhoneView;
        public UC_Add()
        {
            InitializeComponent();

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountry);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCity);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteAddress);

            //UpdateData(new List<NumberPhoneView>() { new NumberPhoneView() });

            uC_GridPhones.DataGrid.ShowRowHeader = true;
            uC_GridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            uC_GridPhones.DataGrid.DrawCell += DataGrid_DrawCell;
            uC_GridPhones.DataGrid.CellClick += DataGrid_CellClick;

            LoadDataToCountry();
        }

        private void DataGrid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataColumn.ColumnIndex == 0)
            {
                var res = MessageBox.Show("Вы действительно хотите удалить данную запись?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    int deletingRowIndex = uC_GridPhones.DataGrid.TableControl.ResolveToRecordIndex(e.DataRow.RowIndex);
                    using (var db = new ApplicationContext())
                    {
                        var deleteRow = uC_GridPhones.DataGrid.View.Records[deletingRowIndex].Data as NumberPhoneView;
                        var deleteRecord = db.NumberPhone.Where(n => n.Id == deleteRow.Id).FirstOrDefault();
                        if (deleteRecord != null)
                        {
                            db.NumberPhone.Remove(deleteRecord);
                            db.SaveChanges();

                            var numberPhones = db.NumberPhoneView
                                .Where(n => n.AddressId == Convert.ToInt32(autoCompleteAddress.GetItemArray(textBoxAddress.Text)[0]))
                                .ToList();
                            UpdateData(numberPhones);
                        }    
                    }
                    e.Cancel = true;
                    var recordsCount = uC_GridPhones.DataGrid.View.Records.Count;
                    if (recordsCount != 0)
                    {
                        uC_GridPhones.DataGrid.SelectedItem = uC_GridPhones.DataGrid.View.Records[0];

                    }
                }
            }
        }

        private void DataGrid_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (uC_GridPhones.DataGrid.ShowRowHeader && e.RowIndex != 0)
            {
                if (e.ColumnIndex == 0)
                {
                    e.Handled = true;
                    Rectangle rect = new Rectangle(e.Bounds.X + 7, e.Bounds.Y + 7, e.Bounds.Width - 14, e.Bounds.Height - 12);
                    e.Graphics.FillRectangle(new SolidBrush(uC_GridPhones.DataGrid.Style.RowHeaderStyle.BackColor),
                        new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2));
                    e.Graphics.DrawImage(new Bitmap(Resources.remove), rect);
                }
            }
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
            uC_GridPhones.DataGrid.Columns["Locality"].Width = 140;
            uC_GridPhones.DataGrid.Columns["TypeName"].Width = 70;
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
                maskNumber = db.City.Where(c => c.Id == Convert.ToInt32(cityId)).FirstOrDefault().MaskNumber;
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

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountry.Text) || string.IsNullOrEmpty(textBoxCity.Text) || string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Укажите Страну, Город и Адрес.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addSingleNumber = new AddSingleNumber();
                addSingleNumber.Mask = maskNumber;
                addSingleNumber.Address = textBoxAddress.Text;
                if (addSingleNumber.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationContext())
                    {
                        var addressId = autoCompleteAddress.GetItemArray(textBoxAddress.Text)[0];
                        var singleNumber = addSingleNumber.NumberPhone;
                        singleNumber.AddressId = Convert.ToInt32(addressId);
                        db.NumberPhone.Add(singleNumber);
                        db.SaveChanges();

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == Convert.ToInt32(addressId))
                            .ToList();
                        UpdateData(numberPhones);
                    }
                }
            }
        }

        private void autoCompleteAddress_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            using (var db = new ApplicationContext())
            {
                var numberPhones = db.NumberPhoneView
                    .Where(n => n.AddressId == Convert.ToInt32(args.ItemArray[0]))
                    .ToList();
                numberPhones.Sort();
                UpdateData(numberPhones);
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountry.Text) || string.IsNullOrEmpty(textBoxCity.Text) || string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Укажите Страну, Город и Адрес.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addRangeNumber = new AddRangeNumber(maskNumber);
                addRangeNumber.Address = textBoxAddress.Text;
                addRangeNumber.AddressId = Convert.ToInt32(autoCompleteAddress.GetItemArray(textBoxAddress.Text)[0]);
                if (addRangeNumber.ShowDialog() == DialogResult.OK)
                {
                    var listNumbers = addRangeNumber.NumberPhones;
                    
                    using (var db = new ApplicationContext())
                    {
                        if (listNumbers.Count != 0)
                        {
                            db.NumberPhone.AddRange(listNumbers);
                            db.SaveChanges();
                        }

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == Convert.ToInt32(Convert.ToInt32(autoCompleteAddress.GetItemArray(textBoxAddress.Text)[0])))
                            .ToList();
                        numberPhones.Sort();
                        UpdateData(numberPhones);
                    }
                }
            }
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            if (currentNumberPhone != null)
            {
                var editSingleNumber = new AddSingleNumber();
                editSingleNumber.Mask = maskNumber;
                editSingleNumber.Address = textBoxAddress.Text;
                using (var db = new ApplicationContext())
                {
                    var numberPhone = db.NumberPhone.Where(n => n.Id == currentNumberPhone.Id).FirstOrDefault();
                    editSingleNumber.NumberPhone = numberPhone;
                }
                if (editSingleNumber.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationContext())
                    {
                        var singleNumber = editSingleNumber.NumberPhone;
                        db.NumberPhone.Update(singleNumber);
                        db.SaveChanges();

                        var numberPhones = db.NumberPhoneView
                            .Where(n => n.AddressId == singleNumber.AddressId)
                            .ToList();
                        UpdateData(numberPhones);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.", "Уведомление",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
