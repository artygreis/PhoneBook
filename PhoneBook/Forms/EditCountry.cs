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
    public partial class EditCountry : Syncfusion.Windows.Forms.MetroForm
    {
        Regex regex = new Regex(@"[^0-9]");
        const int errorPadding = 4;
        private Country currentCountry => uC_GridCountries.DataGrid.SelectedItem as Country;
        public EditCountry()
        {
            InitializeComponent();
            uC_GridCountries.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            uC_GridCountries.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            uC_GridCountries.DataGrid.HeaderRowHeight = 40;
            uC_GridCountries.DataGrid.AllowSorting = false;

            UpdateData(new List<Country>() { new Country() });

            maskedEditBoxExample.GotFocus += MaskedEditBoxExample_GotFocus;
            maskedEditCountryCode.Mask = "+99999";
        }
        private bool IsValidation()
        {
            var result = true;
            errorValidating.Clear();
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                errorValidating.SetError(textBoxCountryName, "Введите наименование страны.");
                errorValidating.SetIconPadding(textBoxCountryName, errorPadding);
                result = false;
            }
            if (string.IsNullOrEmpty(maskedEditCountryCode.Text) || maskedEditCountryCode.Text.Replace(" ", "").Length <= 1)
            {
                errorValidating.SetError(maskedEditCountryCode, "Укажите Код страны в международном формате.");
                errorValidating.SetIconPadding(maskedEditCountryCode, errorPadding);
                result = false;
            }
            if (string.IsNullOrEmpty(textBoxCountDigits.Text))
            {
                errorValidating.SetError(textBoxCountDigits, "Введите количество цифр в номере с учетом кода страны и кода города, но без знака +.");
                errorValidating.SetIconPadding(textBoxCountDigits, errorPadding);
                result = false;
            }
            return result;
        }
        /// <summary>
        /// Формирование маски для примера номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaskedEditBoxExample_GotFocus(object sender, EventArgs e)
        {
            if (!IsValidation())
                return;
            //if (string.IsNullOrEmpty(maskedEditCountryCode.Text) || maskedEditCountryCode.Text.Replace(" ", "").Length <= 1)
            //{
            //    maskedEditCountryCode.Focus();
            //    errorValidating.SetError(maskedEditCountryCode, "Укажите Код страны в международном формате.");
            //    errorValidating.SetIconPadding(maskedEditCountryCode, errorPadding);
            //    return;
            //}
            //errorValidating.Clear();
            //if (string.IsNullOrEmpty(textBoxCountDigits.Text))
            //{
            //    textBoxCountDigits.Focus();
            //    errorValidating.SetError(textBoxCountDigits, "Укажите Количество всех цифр в номере.");
            //    errorValidating.SetIconPadding(textBoxCountDigits, errorPadding);
            //    return;
            //}
            //errorValidating.Clear();
            maskedEditBoxExample.Mask = "+" + new string('#', Convert.ToInt32(textBoxCountDigits.Text));
            if (regex.Replace(maskedEditBoxExample.Text, "").Length == Convert.ToInt32(textBoxCountDigits.Text))
            {
                var tempText = maskedEditBoxExample.Text.Replace(" ", "");
                maskedEditBoxExample.Text = tempText;
                return;
            }
            maskedEditBoxExample.Text = maskedEditCountryCode.Text;
        }

        private void UpdateData(List<Country> countries)
        {
            uC_GridCountries.DataGrid.DataSource = countries;
            uC_GridCountries.DataGrid.Columns["Id"].Visible = false;
            uC_GridCountries.DataGrid.Columns["CountryName"].Width = 140;
            uC_GridCountries.DataGrid.Columns["CountryCode"].Width = 103;
            uC_GridCountries.DataGrid.Columns["CountDigits"].Width = 100;
            uC_GridCountries.DataGrid.Columns["CountDigits"].AllowHeaderTextWrapping = true;
            uC_GridCountries.DataGrid.Columns["Example"].Width = 140;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EditCountry_Load(object sender, System.EventArgs e)
        {
            LoadDataCountry();
        }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        private void LoadDataCountry()
        {
            using (var db = new ApplicationContext())
            {
                var countries = db.Country.ToList();
                UpdateData(countries);
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
            if (currentCountry != null)
            {
                textBoxCountryName.Text = currentCountry.CountryName;
                maskedEditCountryCode.Text = currentCountry.CountryCode;
                textBoxCountDigits.Text = currentCountry.CountDigits.ToString();
                maskedEditBoxExample.Text = currentCountry.Example;


                btnAdd.Image = Resources.save;
                btnAdd.Text = "Сохранить";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Выберите в таблице страну для редактирования.", "Уведомление", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Добавление или Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (!IsValidation())
                return;

            var example = "";
                if (maskedEditBoxExample.Text.Replace(" ", "").Length > maskedEditCountryCode.Text.Replace(" ", "").Length) example = maskedEditBoxExample.Text;
                if (btnAdd.Text == "Сохранить")
                {
                    using (var db = new ApplicationContext())
                    {
                        if (currentCountry != null)
                        {
                            currentCountry.CountryName = textBoxCountryName.Text.Trim();
                            currentCountry.CountryCode = maskedEditCountryCode.Text.Replace(" ", "");
                            currentCountry.CountDigits = Convert.ToInt32(textBoxCountDigits.Text);
                            currentCountry.Example = example;

                            db.Country.Update(currentCountry);
                            db.SaveChanges();
                        }
                    }
                    ClearTextBox();
                    LoadDataCountry();
                    btnAdd.Text = "Добавить";
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;

                }
                else if (btnAdd.Text == "Добавить")
                {

                    using (var db = new ApplicationContext())
                    {
                        db.Country.Add(new Country()
                        {
                            CountryName = textBoxCountryName.Text.Trim(),
                            CountryCode = maskedEditCountryCode.Text.Replace(" ", ""),
                            CountDigits = Convert.ToInt32(textBoxCountDigits.Text),
                            Example = example
                        });

                        db.SaveChanges();
                    }
                    ClearTextBox();
                    LoadDataCountry();
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
            textBoxCountryName.Text = "";
            maskedEditCountryCode.Text = "";
            textBoxCountDigits.Text = "";
            maskedEditBoxExample.Text = "";
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (currentCountry != null)
            {
                var dialog = MessageBox.Show($"Вы действительно хотите удалить запись:\n " +
                    $"{currentCountry.CountryName} {currentCountry.CountryCode} {currentCountry.CountDigits}", "Уведомление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No) return; 
                using (var db = new ApplicationContext())
                {
                    db.Country.Remove(currentCountry);

                    db.SaveChanges();
                }
                LoadDataCountry();
            }
            else
            {
                MessageBox.Show("Выберите в таблице страну для удаления.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Проверка примера номера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedEditBoxExample_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedEditCountryCode.Text) || 
                maskedEditCountryCode.Text.Replace(" ", "").Length <= 1 || string.IsNullOrEmpty(textBoxCountDigits.Text)) return;

            if (maskedEditBoxExample.Text.Replace(" ", "").Length > maskedEditCountryCode.Text.Replace(" ", "").Length &&
                regex.Replace(maskedEditBoxExample.Text, "").Length < Convert.ToInt32(textBoxCountDigits.Text))
            {
                MessageBox.Show("Пример не соответствует введенным данным.", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var tempText = maskedEditBoxExample.Text.Replace(" ", "");
                maskedEditBoxExample.Focus();
                maskedEditBoxExample.Text = tempText;
            }
        }
    }
}
