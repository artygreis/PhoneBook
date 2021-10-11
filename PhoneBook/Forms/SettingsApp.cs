using Microsoft.EntityFrameworkCore;
using PhoneBook.Services;
using PhoneBook.Types;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class SettingsApp : Syncfusion.Windows.Forms.MetroForm
    {

        readonly string DefaultPath = Path.GetFullPath(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", @".."));
        int currentControlNumber = 1;
        public SettingsApp()
        {
            InitializeComponent();
            rdbNew.CheckedChanged += radioButton_CheckedChanged;
            rdbExist.CheckedChanged += radioButton_CheckedChanged;
            openFileDialog.Filter = "DB files(*.db)|*.db";
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            var settings = Settings.Load();
            if (settings == null || string.IsNullOrEmpty(settings.UserSourceDb))
            {
                var dialog = MessageBox.Show($"Прекратить первоначальную настройку приложения и справочника?\n" +
                $"Дальнейшая работа с программой будет некорректной.", "Предупреждение",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                    DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void AddOneApartment_Load(object sender, System.EventArgs e)
        {
            VisiblePanel(currentControlNumber);
            textBoxSourceDb.Text = DefaultPath;
            radioButton_CheckedChanged(rdbNew, new EventArgs());
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDefault.Enabled = false;
            btnChangeFolder.Enabled = false;
            textBoxSourceDb.Enabled = false;
            textBoxSourceFile.Enabled = false;
            btnSearchFile.Enabled = false;
            errorValidating.Clear();
            var radioButton = (RadioButton)sender;
            if (radioButton.Name == "rdbNew")
            {
                textBoxSourceDb.Enabled = true;
                checkBoxDefault.Enabled = true;
                checkBoxDefault_CheckedChanged(checkBoxDefault, new EventArgs());
            }
            if (radioButton.Name == "rdbExist")
            {
                textBoxSourceFile.Enabled = true;
                btnSearchFile.Enabled = true;
            }
        }

        private void VisiblePanel(int numberPanel)
        {
            pnlStep1.Visible = false;
            pnlStep2.Visible = false;
            pnlStep3.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            switch(numberPanel)
            {
                case 1:
                    pnlStep1.Visible = true;
                    btnNext.Enabled = true;
                    break;
                case 2:
                    pnlStep2.Visible = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    break;
                case 3:
                    pnlStep3.Visible = true;
                    btnPrevious.Enabled = true;
                    break;
            }
        }
        private bool ValidatingPanel(int numberPanel)
        {
            errorValidating.Clear();
            switch (numberPanel)
            {
                case 1:
                    if (rdbNew.Checked && checkBoxDefault.Checked)
                    {
                        var dialog = MessageBox.Show($"При использовании пути к базе данных по умолчанию, при удалении приложения " +
                            $"будет удалена и сама база данных (телефонный справочник)", "Предупреждение",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Cancel)
                            return false;
                    }
                    return CheckSourceData();
                case 2:
                    if (!checkBoxPassword.Checked && string.IsNullOrEmpty(textBoxPassword.Text))
                    {
                        errorValidating.SetError(textBoxPassword, "Укажите пароль.");
                        errorValidating.SetIconPadding(textBoxPassword, 4);
                        return false;
                    }
                    return CheckAndSaveUserSettings();
            }
            return true;
        }
        private bool CheckSourceData()
        {
            if (!Directory.Exists(textBoxSourceDb.Text))
            {
                errorValidating.SetError(textBoxSourceDb, "Проверьте указанный путь.");
                errorValidating.SetIconAlignment(textBoxSourceDb, ErrorIconAlignment.MiddleLeft);
                errorValidating.SetIconPadding(textBoxSourceDb, 4);
                return false;
            }
            if (rdbExist.Checked)
            {
                if (!File.Exists(textBoxSourceFile.Text))
                {
                    errorValidating.SetError(textBoxSourceFile, "Не найден файл.");
                    errorValidating.SetIconAlignment(textBoxSourceFile, ErrorIconAlignment.MiddleLeft);
                    errorValidating.SetIconPadding(textBoxSourceFile, 4);
                    return false;
                }
            }
            return true;
        }
        private string GetNameFile(string defaultName)
        {
            var listFiles = Directory.GetFiles(textBoxSourceDb.Text).Select(f => Path.GetFileName(f)).ToList();
            int count = 1;
            while(true)
            {
                if (listFiles.Contains(defaultName))
                {
                    defaultName = defaultName.Substring(0, defaultName.LastIndexOf('.')) + count + ".db";
                    count++;
                }
                else
                {
                    return defaultName;
                }
            }
        }
        private bool CheckAndSaveUserSettings()
        {
            var settings = Settings.Load();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (rdbExist.Checked)
                settings.UserSourceDb = $"{textBoxSourceFile.Text}";
            if (rdbNew.Checked)
                settings.UserSourceDb = $"{textBoxSourceDb.Text}\\{GetNameFile(config.AppSettings.Settings["DefaultFileNameDb"].Value)}";
            if (!string.IsNullOrEmpty(textBoxPassword.Text.Replace(" ", "")))
            {
                settings.Password = CryptoService.Encrypt(textBoxPassword.Text.Trim());
            }
            settings.Save();
            using (var db = new ApplicationContext())
            {
                try
                {
                    DbInitializer.InitializeDb();
                    db.Database.OpenConnection();
                    db.Database.CloseConnection();
                }
                catch
                {
                    errorValidating.SetError(textBoxPassword, "Проверьте данные для подключения");
                    errorValidating.SetIconPadding(textBoxPassword, 4);
                    Settings.DeleteFileSettings();
                    return false;
                }
            }
            return true;
        }
        private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
        {
            btnChangeFolder.Enabled = false;
            if (!checkBoxDefault.Checked)
            {
                btnChangeFolder.Enabled = true;
            }
            if (checkBoxDefault.Checked)
                textBoxSourceDb.Text = DefaultPath;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentControlNumber -= 1;
            VisiblePanel(currentControlNumber);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidatingPanel(currentControlNumber)) return;
            currentControlNumber += 1;
            VisiblePanel(currentControlNumber);
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            errorValidating.Clear();
            textBoxSourceDb.Text = folderBrowserDialog.SelectedPath;
            
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            errorValidating.Clear();
            textBoxSourceFile.Text = openFileDialog.FileName;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            errorValidating.Clear();
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.Enabled = false;
                lblInfo.Visible = true;
            }
            else
            {
                textBoxPassword.Enabled = true;
                lblInfo.Visible = false;
            }  
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
