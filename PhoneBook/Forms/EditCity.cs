using PhoneBook.Properties;
using PhoneBook.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class EditCity : Syncfusion.Windows.Forms.MetroForm
    {
        private City currentCity => uC_GridCities.DataGrid.SelectedItem as City;
        public Country Country { get; set; }
        public EditCity()
        {
            InitializeComponent();
            uC_GridCities.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            uC_GridCities.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            uC_GridCities.DataGrid.HeaderRowHeight = 40;
            uC_GridCities.DataGrid.AllowSorting = false;

            UpdateData(new List<City>() { new City() });

            maskedEditBoxFormatNumber.GotFocus += MaskedEditBoxFormatNumber_GotFocus;
            maskedEditCityCode.Mask = "9999999";
        }
        /// <summary>
        /// Заполнение информации о формате номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaskedEditBoxFormatNumber_GotFocus(object sender, EventArgs e)
        {
            if (!IsValidation())
                return;
            //if (string.IsNullOrEmpty(maskedEditCityCode.Text.Replace(" ", "")))
            //{
            //    maskedEditCityCode.Focus();
            //    MessageBox.Show("Укажите Код города.", "Уведомление",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (!ValidateMaskNumber())
            {
                var tempText = maskedEditBoxFormatNumber.Text.Replace(" ", "");
                maskedEditBoxFormatNumber.Text = tempText;
                return;
            }
            
            maskedEditBoxFormatNumber.Text = GetMaskNumber(Country.CountDigits - 
                maskedEditCityCode.Text.Replace(" ", "").Length - Country.CountryCode.Replace("+", "").Length);
        }

        private void UpdateData(List<City> cities)
        {
            uC_GridCities.DataGrid.DataSource = cities;
            uC_GridCities.DataGrid.Columns["Id"].Visible = false;
            uC_GridCities.DataGrid.Columns["CityName"].Width = 201;
            uC_GridCities.DataGrid.Columns["CityCode"].Width = 121;
            uC_GridCities.DataGrid.Columns["MaskNumber"].Width = 161;
            uC_GridCities.DataGrid.Columns["CountryId"].Visible = false;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditCity_Load(object sender, System.EventArgs e)
        {
            labelCountry.Text = $"{Country.CountryName} ({Country.CountryCode})";
            LoadDataCity();
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataCity()
        {
            using (var db = new ApplicationContext())
            {
                var cities = db.City.Where(c => c.CountryId == Country.Id).ToList();
                UpdateData(cities);
            }
        }
        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();

            if (string.IsNullOrEmpty(textBoxCityName.Text))
            {
                errorValidating.SetError(textBoxCityName, "Введите нименование города.");
                errorValidating.SetIconPadding(textBoxCityName, errorPadding);
                result = false;
            }

            if (string.IsNullOrEmpty(maskedEditCityCode.Text.Replace(" ", "")))
            {
                errorValidating.SetError(maskedEditCityCode, "Введите код города.");
                errorValidating.SetIconPadding(maskedEditCityCode, errorPadding);
                result = false;
            }

            if (maskedEditCityCode.Text.StartsWith('0'))
            {
                errorValidating.SetError(maskedEditCityCode, "Код города должен быть в международном формате и не начинаться с 0.");
                errorValidating.SetIconPadding(maskedEditCityCode, errorPadding);
                result = false;
            }

            if (ValidateMaskNumber())
            {
                errorValidating.SetError(maskedEditBoxFormatNumber, "Проверьте количество символов маркера \"#\".");
                errorValidating.SetIconPadding(maskedEditBoxFormatNumber, errorPadding);
                result = false;
            }

            return result;
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
                if (currentCity != null)
                {
                    textBoxCityName.Text = currentCity.CityName;
                    maskedEditCityCode.Text = currentCity.CityCode;
                    maskedEditBoxFormatNumber.Text = currentCity.MaskNumber;


                    btnAdd.Image = Resources.save;
                    btnAdd.Text = "Сохранить";
                    btnEdit.Image = Resources.cancel;
                    btnEdit.Text = "Отменить";
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Выберите в таблице город для редактирования.", "Уведомление",
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
        const int errorPadding = 4;
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
                using (var db = new ApplicationContext())
                {
                    if (currentCity != null)
                    {
                        currentCity.CityName = textBoxCityName.Text.Trim();
                        currentCity.CityCode = maskedEditCityCode.Text.Replace(" ", "");
                        currentCity.MaskNumber = maskedEditBoxFormatNumber.Text.Trim();

                        db.City.Update(currentCity);
                        db.SaveChanges();
                    }
                }
                ClearTextBox();
                LoadDataCity();
                btnAdd.Text = "Добавить";
                btnAdd.Image = Resources.add;
                btnEdit.Text = "Изменить";
                btnEdit.Image = Resources.edit;
                btnDelete.Enabled = true;

            }
            else if (btnAdd.Text == "Добавить")
            {

                using (var db = new ApplicationContext())
                {
                    db.City.Add(new City()
                    {
                        CityName = textBoxCityName.Text.Trim(),
                        CityCode = maskedEditCityCode.Text.Replace(" ", ""),
                        MaskNumber = maskedEditBoxFormatNumber.Text.Trim(),
                        CountryId = Country.Id
                    });

                    db.SaveChanges();
                }
                ClearTextBox();
                LoadDataCity();
            }
            else
            {
                ;
            }
        }
        /// <summary>
        /// Очистка текстовых полей
        /// </summary>
        private void ClearTextBox()
        {
            textBoxCityName.Text = "";
            maskedEditCityCode.Text = "";
            maskedEditBoxFormatNumber.Text = "";
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentCity != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{currentCity.CityName} {currentCity.CityCode} {currentCity.MaskNumber}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return; 
                using (var db = new ApplicationContext())
                {
                    db.City.Remove(currentCity);

                    db.SaveChanges();
                }
                LoadDataCity();
            }
            else
            {
                MessageBox.Show("Выберите в таблице город для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Формирование формата номера
        /// </summary>
        /// <param name="countDigits"></param>
        /// <returns></returns>
        private string GetMaskNumber(int countDigits)
        {
            if (countDigits >= 5)
            {
                return $"{new string('#', countDigits - 4)}-##-##";
            }
            else
            {
                return new string('#', countDigits);
            }
        }
        /// <summary>
        /// Проверка итогового формата номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedEditBoxFormatNumber_Validated(object sender, EventArgs e)
        {
            var regex = new Regex(@"[^#-]");
            if (regex.IsMatch(maskedEditBoxFormatNumber.Text))
            {
                errorValidating.SetError(maskedEditBoxFormatNumber, "В качестве маркера нужно использовать \"#\", а в качестве разделителя \"-\".");
                errorValidating.SetIconPadding(maskedEditBoxFormatNumber, errorPadding);

                return;
            }
            errorValidating.Clear();


            //if (string.IsNullOrEmpty(maskedEditCityCode.Text.Replace(" ", ""))) return;
            //if (ValidateMaskNumber())
            //{
            //    MessageBox.Show("Проверьте формат номера.", "Уведомление",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        /// <summary>
        /// Проверка соответсвие формата номера
        /// </summary>
        /// <returns></returns>
        private bool ValidateMaskNumber()
        {
            var regex = new Regex(@"[^#]");
            var tempCountNumber = regex.Replace(maskedEditBoxFormatNumber.Text.Replace(" ", ""), "").Length;
            var tempCountNumberRight = Country.CountDigits - maskedEditCityCode.Text.Replace(" ", "").Length - Country.CountryCode.Replace("+", "").Length;
            return tempCountNumberRight != tempCountNumber;
        }
    }
}
