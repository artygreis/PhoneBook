using Microsoft.EntityFrameworkCore;
using PhoneBook.Properties;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class EditAddress : Syncfusion.Windows.Forms.MetroForm
    {
        private AddressEdit currentAddress => uC_GridAddresses.DataGrid.SelectedItem as AddressEdit;
        public City City { get; set; }
        public EditAddress()
        {
            InitializeComponent();
            uC_GridAddresses.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            uC_GridAddresses.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            uC_GridAddresses.DataGrid.AllowSorting = false;

            UpdateData(new List<AddressEdit>() { new AddressEdit() });

            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteLocality);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteTypeStreet);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteStreetName);
            AutoCompleteSetting.SetAutoCompleteSetting(autoCompleteHouse);
        }

        /// <summary>
        /// Загрузка и обновление данных
        /// </summary>
        /// <param name="addresses"></param>
        private void UpdateData(List<AddressEdit> addresses)
        {
            uC_GridAddresses.DataGrid.DataSource = addresses;
            uC_GridAddresses.DataGrid.Columns["Id"].Visible = false;
            uC_GridAddresses.DataGrid.Columns["Locality"].Width = 170;
            uC_GridAddresses.DataGrid.Columns["TypeStreetId"].Visible = false;
            uC_GridAddresses.DataGrid.Columns["TypeStreetName"].Width = 150;
            uC_GridAddresses.DataGrid.Columns["StreetName"].Width = 140;
            uC_GridAddresses.DataGrid.Columns["House"].Width = 110;

            autoCompleteLocality.DataSource = addresses.Where(a => !string.IsNullOrEmpty(a.Locality)).Select(a => a.Locality).Distinct().ToList();
            autoCompleteLocality.RefreshColumns();
            autoCompleteLocality.Columns[0].MatchingColumn = true;

            using (var db = new ApplicationContext())
            {
                var typeStreet = db.TypeStreet.ToList();
                autoCompleteTypeStreet.DataSource = typeStreet;
                autoCompleteTypeStreet.RefreshColumns();
                autoCompleteTypeStreet.Columns[1].MatchingColumn = true;
                autoCompleteTypeStreet.Columns[0].Visible = false;
                autoCompleteTypeStreet.Columns[2].Visible = false;
            }

            autoCompleteStreetName.DataSource = addresses.Select(a => a.StreetName).Distinct().ToList();
            autoCompleteStreetName.RefreshColumns();
            autoCompleteStreetName.Columns[0].MatchingColumn = true;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditAddress_Load(object sender, System.EventArgs e)
        {
            LoadDataAddress();
            labelHeader.Text = labelHeader.Text.Replace("n", $"{City.CityName} ({City.CityCode})");
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataAddress()
        {
            using (var db = new ApplicationContext())
            {
                var addresses = db.City
                    .Include(c => c.Addresses)
                    .ThenInclude(t => t.TypeStreet)
                    .Where(c => c.Id == City.Id)
                    .FirstOrDefault()
                    .Addresses
                    .Select(a => new AddressEdit() 
                    {
                        Id = a.Id,
                        Locality = a.Locality,
                        TypeStreetId = a.TypeStreetId,
                        TypeStreetName = a.TypeStreet.TypeName,
                        StreetName = a.StreetName,
                        House = a.House
                    })
                    .ToList();
                UpdateData(addresses);
            }
        }
        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            errorValidating.Clear();
            if (btnEdit.Text == "Изменить")
            {
                if (currentAddress != null)
                {
                    if (!string.IsNullOrEmpty(currentAddress.Locality))
                    {
                        autoCompleteLocality.ActiveFocusControl = textBoxLocality;
                        autoCompleteLocality.SelectedValue = $"{currentAddress.Locality}";
                        autoCompleteLocality.ActiveFocusControl = null;
                    }
                    autoCompleteTypeStreet.ActiveFocusControl = textBoxTypeStreet;
                    autoCompleteTypeStreet.SelectedValue = $"{currentAddress.TypeStreetName}";
                    autoCompleteTypeStreet.ActiveFocusControl = null;
                    autoCompleteStreetName.ActiveFocusControl = textBoxStreetName;
                    autoCompleteStreetName.SelectedValue = $"{currentAddress.StreetName}";
                    autoCompleteStreetName.ActiveFocusControl = null;
                    textBoxHouse.Text = currentAddress.House;

                    btnAdd.Image = Resources.save;
                    btnAdd.Text = "Сохранить";
                    btnEdit.Image = Resources.cancel;
                    btnEdit.Text = "Отменить";
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Выберите в таблице адрес для редактирования.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (btnEdit.Text == "Отменить")
            {
                ClearTextBox();
                btnAdd.Text = "Добавить";
                btnAdd.Image = Resources.add;
                btnEdit.Text = "Изменить";
                btnEdit.Image = Resources.edit;
                btnDelete.Enabled = true;
            }
        }
        const int errorPadding = 3;
        /// <summary>
        /// Добавление или Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!IsValidation())
                return;

            if (btnAdd.Text == "Сохранить")
            {
                if (AddressIsExist())
                {
                    MessageBox.Show("Данный адрес уже существует!", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new ApplicationContext())
                {
                    if (currentAddress != null)
                    {
                        var tempAddress = new Address();
                        tempAddress.Id = currentAddress.Id;
                        tempAddress.Locality = textBoxLocality.Text.Trim();
                        tempAddress.TypeStreetId = Convert.ToInt32(autoCompleteTypeStreet.GetItemArray(textBoxTypeStreet.Text)[0]);
                        tempAddress.StreetName = textBoxStreetName.Text.Trim();
                        tempAddress.House = textBoxHouse.Text;

                        db.Address.Update(tempAddress);
                        db.SaveChanges();
                    }
                }
                ClearTextBox();
                LoadDataAddress();
                btnAdd.Text = "Добавить";
                btnAdd.Image = Resources.add;
                btnEdit.Text = "Изменить";
                btnEdit.Image = Resources.edit;
                btnDelete.Enabled = true;

            }
            else if (btnAdd.Text == "Добавить")
            {
                if (AddressIsExist())
                {
                    MessageBox.Show("Данный адрес уже существует!", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new ApplicationContext())
                {
                    var address = new Address()
                    {
                        Locality = textBoxLocality.Text.Trim(),
                        TypeStreetId = Convert.ToInt32(autoCompleteTypeStreet.GetItemArray(textBoxTypeStreet.Text)[0]),
                        StreetName = textBoxStreetName.Text.Trim(),
                        House = textBoxHouse.Text.Trim()
                    };
                    var city = db.City.Where(c => c.Id == City.Id).FirstOrDefault();
                    db.Address.Add(address);
                    address.Cities.Add(city);
                    db.SaveChanges();
                }
                ClearTextBox();
                LoadDataAddress();
            }
            else
            {
                ;
            }
        }
        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();
            if (string.IsNullOrEmpty(textBoxTypeStreet.Text))
            {
                errorValidating.SetError(textBoxTypeStreet, "Выберите тип улицы или введите новый.");
                errorValidating.SetIconPadding(textBoxTypeStreet, errorPadding);
                result = false;
            }

            if (string.IsNullOrEmpty(textBoxStreetName.Text))
            {
                errorValidating.SetError(textBoxStreetName, "Выберите наименование улицы или введите новое.");
                errorValidating.SetIconPadding(textBoxStreetName, errorPadding);
                result = false;
            }

            if (string.IsNullOrEmpty(textBoxHouse.Text))
            {
                errorValidating.SetError(textBoxHouse, "Укажите номер дома.");
                errorValidating.SetIconPadding(textBoxHouse, errorPadding);
                result = false;
            }

            return result;
        }
        /// <summary>
        /// Проверка существует ли данный адрес
        /// </summary>
        /// <returns></returns>
        private bool AddressIsExist()
        {
            var addresses = uC_GridAddresses.DataGrid.DataSource as List<AddressEdit>;
            var find = addresses
                .Where(a => a.Locality == textBoxLocality.Text.Trim() && a.TypeStreetName == textBoxTypeStreet.Text.Trim()
                    && a.StreetName == textBoxStreetName.Text.Trim() && a.House == textBoxHouse.Text.Trim()).ToList();
            return find.Count > 0;
        }
        /// <summary>
        /// Очистка текстовых полей
        /// </summary>
        private void ClearTextBox()
        {
            textBoxLocality.Text = "";
            textBoxTypeStreet.Text = "";
            textBoxStreetName.Text = "";
            textBoxHouse.Text = "";
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentAddress != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{(string.IsNullOrEmpty(currentAddress.Locality) ? "" : currentAddress.Locality + ", ")}{currentAddress.TypeStreetName} {currentAddress.StreetName}, {currentAddress.House}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return;
                using (var db = new ApplicationContext())
                {
                    var tempAddress = db.Address.Where(a => a.Id == currentAddress.Id).FirstOrDefault();
                    if (tempAddress != null)
                        db.Address.Remove(tempAddress);
                    db.SaveChanges();
                }
                LoadDataAddress();
            }
            else
            {
                MessageBox.Show("Выберите в таблице адрес для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxTypeStreet_Leave(object sender, EventArgs e)
        {
            var text = textBoxTypeStreet.Text;
            if (!string.IsNullOrEmpty(text) && autoCompleteTypeStreet.GetItemArray(text) == null)
            {
                var dialog = MessageBox.Show($"Вы действительно добавить тип улицы:\n " +
                       $"{text.ToLower().Trim()}", "Уведомление",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No)
                {
                    textBoxTypeStreet.Text = "";
                    return;
                }
                    
                using (var db = new ApplicationContext())
                {
                    db.TypeStreet.Add(new TypeStreet() { TypeName = text.Trim() });
                    db.SaveChanges();

                    var typeStreet = db.TypeStreet.ToList();
                    autoCompleteTypeStreet.DataSource = typeStreet;
                    autoCompleteTypeStreet.RefreshColumns();
                    autoCompleteTypeStreet.Columns[1].MatchingColumn = true;
                    autoCompleteTypeStreet.Columns[0].Visible = false;
                    autoCompleteTypeStreet.Columns[2].Visible = false;

                    autoCompleteTypeStreet.SelectedValue = text.ToLower().Trim();
                }
            }
        }
    }
}
