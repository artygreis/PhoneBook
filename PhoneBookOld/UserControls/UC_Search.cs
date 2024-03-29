﻿using Microsoft.EntityFrameworkCore;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Syncfusion.Pdf;
//using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Drawing;
using System.Drawing;
using Syncfusion.Pdf.Graphics;
using PhoneBook.Forms;
using System.Text.RegularExpressions;
using Syncfusion.WinForms.DataGrid.Enums;

namespace PhoneBook.UserControls
{
    public partial class UC_Search : UserControl
    {
        private string maskNumber = "";

        private NotCallView currentNotCallNumber => uC_GridPhones.DataGrid.SelectedItem as NotCallView;
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

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCountryNotCall);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteCityNotCall);

            uC_GridPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            uC_GridPhones.DataGrid.QueryRowHeight += DataGrid_QueryRowHeight;
            uC_GridPhones.DataGrid.QueryRowStyle += DataGrid_QueryRowStyle;

            saveFileDialog.Filter = "Pdf files(*.pdf)|*.pdf";
        }

        private void DataGrid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCity.Text)) return;

            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowData is NumberPhoneView)
                {
                    var currentNumber = (e.RowData as NumberPhoneView).Number;
                    using (var db = new ApplicationContext())
                    {
                        var notCallCount = db.NotCall.Where(n => n.Number == currentNumber && n.CityId == Convert.ToInt32(autoCompleteCity.GetItemArray(textBoxCity.Text)[0])).Count();
                        if (notCallCount > 0)
                            e.Style.BackColor = Color.IndianRed;
                    }
                }
            }
        }

        RowAutoFitOptions autoFitOptions = new RowAutoFitOptions();
        int autoHeight;
        private void DataGrid_QueryRowHeight(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowHeightEventArgs e)
        {
            if (this.uC_GridPhones.DataGrid.AutoSizeController.GetAutoRowHeight(e.RowIndex, autoFitOptions, out autoHeight))
            {
                if (autoHeight > 24)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
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
            uC_GridPhones.DataGrid.Columns["Locality"].Width = 150;
            uC_GridPhones.DataGrid.Columns["TypeName"].Width = 80;
            uC_GridPhones.DataGrid.Columns["StreetName"].Width = 180;
            uC_GridPhones.DataGrid.Columns["House"].Width = 50;
            uC_GridPhones.DataGrid.Columns["Apartment"].Width = 50;
        }

        private void UpdateDataNotCall(int cityId)
        {
            var numberPhones = new List<NumberPhoneView>();
            var notCalls = new List<NotCall>();
            uC_GridPhones.DataGrid.DataSource = new List<NotCallView>() { new NotCallView() };

            using (var db = new ApplicationContext())
            {
                notCalls = db.NotCall.Where(n => n.CityId == cityId).ToList();

                if (notCalls.Count() == 0)
                {
                    MessageBox.Show("Отсутствуют номера для данного города.",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                numberPhones = db.NumberPhone
                    .Include(a => a.Address)
                        .ThenInclude(t => t.TypeStreet)
                    .Include(a => a.Address)
                        .ThenInclude(c => c.Cities)
                    .Where(t => t.Address.Cities.FirstOrDefault().Id == cityId)
                    .Select(n => new NumberPhoneView()
                    {
                        Id = n.Id,
                        AddressId = n.AddressId,
                        Locality = n.Address.Locality,
                        TypeName = n.Address.TypeStreet.TypeName,
                        StreetName = n.Address.StreetName,
                        House = n.Address.House,
                        Apartment = n.Apartment,
                        Number = n.Number
                    }).ToList();
            }

            var notCallViews = new List<NotCallView>();

            foreach (var notCall in notCalls)
            {
                var findNumberPhones = numberPhones.Where(n => n.Number == notCall.Number).ToList();
                var address = findNumberPhones.Count() > 0 ? $"{(string.IsNullOrEmpty(findNumberPhones.First().Locality) ? "" : findNumberPhones.First().Locality + ", ")}{findNumberPhones.First().TypeName} {findNumberPhones.First().StreetName}, д. {findNumberPhones.First().House}, кв. {findNumberPhones.First().Apartment}" : "";
                notCallViews.Add(new NotCallView()
                {
                    Id = notCall.Id,
                    Number = notCall.Number,
                    Address = address,
                    Notes = notCall.Notes,
                    CityId = notCall.CityId
                });
            }

            uC_GridPhones.DataGrid.DataSource = notCallViews;
            uC_GridPhones.DataGrid.Columns["Number"].AllowHeaderTextWrapping = true;
            uC_GridPhones.DataGrid.HeaderRowHeight = 45;
            uC_GridPhones.DataGrid.Columns["Number"].Width = 90;
            uC_GridPhones.DataGrid.Columns["Address"].Width = 270;
            uC_GridPhones.DataGrid.Columns["Notes"].AllowTextWrapping = true;
            lblCount.Text = $"Количество: {notCallViews.Count()}";
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
                case "autoCompleteCountryNotCall":
                    textBoxCityNotCall.Text = "";
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    autoCompleteCityNotCall.DataSource = null;
                    autoCompleteCityNotCall.ResetHistory();
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

        private void autoCompleteCountryNotCall_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {
            ClearTextEditAndAutoComplete("autoCompleteCountryNotCall");
            SelectCountryAndComplete(autoCompleteCountryNotCall, autoCompleteCityNotCall, args);
            uC_GridPhones.DataGrid.DataSource = new List<NotCallView>() { new NotCallView() };
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
            if (tabControlAdv.SelectedTab.Name == "searchNotCallTab")
            {
                LoadDataToCountry(autoCompleteCountryNotCall, textBoxCountryNotCall);
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
        private void autoCompleteCityNotCall_AutoCompleteItemSelected(object sender, AutoCompleteItemEventArgs args)
        {

            using (var db = new ApplicationContext())
            {
                var cityId = autoCompleteCityNotCall.GetItemArray(args.SelectedValue)[0];

                SelectMask(Convert.ToInt32(cityId));

                UpdateDataNotCall(Convert.ToInt32(cityId));

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
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

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            var numberPhones = uC_GridPhones.DataGrid.DataSource as List<NumberPhoneView>;

            var listNotCall = new List<int>();

            if (numberPhones.Count < 2)
            {
                MessageBox.Show("Нет данных для экспорта", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();
            doc.PageSettings.Margins.All = 15;

            //Add a page.
            PdfPage page = doc.Pages.Add();
            //Create a PdfGrid.
            PdfGrid pdfGrid = new PdfGrid();

            //Create a DataTable.
            DataTable dataTable = new DataTable();
            //Add columns to the DataTable
            dataTable.Columns.Add("Нас. пункт");
            dataTable.Columns.Add("Адрес");
            dataTable.Columns.Add("Дом");
            dataTable.Columns.Add("Кв.");
            dataTable.Columns.Add("Номер телефона");
            //Add rows to the DataTable.
            foreach (var numberPhone in numberPhones)
            {
                dataTable.Rows.Add(new object[] 
                { 
                    numberPhone.Locality, 
                    numberPhone.TypeName + " "+ numberPhone.StreetName, 
                    numberPhone.House,
                    numberPhone.Apartment,
                    string.IsNullOrEmpty(numberPhone.Number) ? "" : string.Format("{0:"+ maskNumber +"}", Convert.ToInt64(numberPhone.Number))
                });
                
                Regex regex = new Regex(@"[^0-9]");
                var currentNumber = regex.Replace(numberPhone.Number, "");
                using (var db = new ApplicationContext())
                {
                    var notCallCount = db.NotCall.Where(n => n.Number == currentNumber && n.CityId == Convert.ToInt32(autoCompleteCity.GetItemArray(textBoxCity.Text)[0])).Count();
                    if (notCallCount > 0)
                    {
                        listNotCall.Add(dataTable.Rows.Count - 1);
                    }
                }
            }
            
            //Assign data source.
            pdfGrid.DataSource = dataTable;
            pdfGrid.Columns[0].Width = 150;
            pdfGrid.Columns[2].Width = 50;
            pdfGrid.Columns[3].Width = 50;
            pdfGrid.Columns[4].Width = 100;
            for (int i =0; i < pdfGrid.Columns.Count; i++)
            {
                pdfGrid.Columns[i].Format = new PdfStringFormat() { Alignment = PdfTextAlignment.Center, LineAlignment = PdfVerticalAlignment.Middle };

            }

            PdfGridRowStyle pdfGridRowStyle = new PdfGridRowStyle();
            pdfGridRowStyle.BackgroundBrush = PdfBrushes.IndianRed;
            foreach (var row in listNotCall)
            {
                pdfGrid.Rows[row].Style = pdfGridRowStyle;
            }

            //Creates the grid cell styles
            PdfGridRow header = pdfGrid.Headers[0];
            //Creates the header style
            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = PdfPens.Black;
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(0, 71, 160));
            headerStyle.TextBrush = PdfBrushes.White;
            headerStyle.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 14, FontStyle.Bold),  true);
            //Adds cell customizations
            for (int i = 0; i < header.Cells.Count; i++)
            {
                header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            //Applies the header style
            header.ApplyStyle(headerStyle);

            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.All = PdfPens.Black;
            cellStyle.Font = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12), true);
            cellStyle.TextBrush = PdfBrushes.Black;
            pdfGrid.Rows.ApplyStyle(cellStyle);

            //Draw grid to the page of PDF document.
            pdfGrid.Draw(page, new PointF(10, 10));
            saveFileDialog.FileName = textBoxAddress.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            //Save the document.
            doc.Save(filename);
            //close the document
            doc.Close(true);
            MessageBox.Show("Файл успешно сохранен", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addNotCall = new AddNotCallNumber();
            addNotCall.Mask = maskNumber;
            addNotCall.NotCall = new NotCall() { CityId = Convert.ToInt32(autoCompleteCityNotCall.GetItemArray(textBoxCityNotCall.Text)[0]) };
            if (addNotCall.ShowDialog() == DialogResult.OK)
            {
                using (var db = new ApplicationContext())
                {
                    db.NotCall.Add(addNotCall.NotCall);
                    db.SaveChanges();
                }
            }
            UpdateDataNotCall(Convert.ToInt32(autoCompleteCityNotCall.GetItemArray(textBoxCityNotCall.Text)[0]));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentNotCallNumber != null)
            {
                var editNotCall = new AddNotCallNumber();
                editNotCall.Mask = maskNumber;
                editNotCall.NameForm = "Редактирование информации:";
                using (var db = new ApplicationContext())
                {
                    var notCall = db.NotCall.Where(n => n.Id == currentNotCallNumber.Id).FirstOrDefault();
                    editNotCall.NotCall = notCall;
                }
                if (editNotCall.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new ApplicationContext())
                    {
                        db.NotCall.Update(editNotCall.NotCall);
                        db.SaveChanges();
                    }
                }
                UpdateDataNotCall(Convert.ToInt32(autoCompleteCityNotCall.GetItemArray(textBoxCityNotCall.Text)[0]));
            }
            else
            {
                MessageBox.Show("Выберите в таблице номер для редактирования.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentNotCallNumber != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите информацию о номере\n " +
                    $"{currentNotCallNumber.Number}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;
                using (var db = new ApplicationContext())
                {
                    var notCall = db.NotCall.Where(n => n.Id == currentNotCallNumber.Id).FirstOrDefault();
                    db.NotCall.Remove(notCall);
                    db.SaveChanges();
                }

                UpdateDataNotCall(Convert.ToInt32(autoCompleteCityNotCall.GetItemArray(textBoxCityNotCall.Text)[0]));
            }
            else
            {
                MessageBox.Show("Выберите в таблице номер для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
