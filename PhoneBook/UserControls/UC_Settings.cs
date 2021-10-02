using Microsoft.EntityFrameworkCore;
using PhoneBook.Forms;
using PhoneBook.Properties;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Settings = PhoneBook.Types.Settings;

namespace PhoneBook.UserControls
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsApp();
            settingsForm.Text = $"Настройка нового телефонного справоника (базы данных)";
            settingsForm.ShowDialog();
        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            var settings = Settings.Load();
            if (!string.IsNullOrEmpty(settings.Password) && string.IsNullOrEmpty(textBoxOldPassword.Text))
            {
                errorValidating.SetError(textBoxOldPassword, "Введите старый пароль.");
                errorValidating.SetIconAlignment(textBoxOldPassword, ErrorIconAlignment.MiddleRight);
                errorValidating.SetIconPadding(textBoxOldPassword, 4);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                errorValidating.SetError(textBoxNewPassword, "Введите новый пароль.");
                errorValidating.SetIconAlignment(textBoxNewPassword, ErrorIconAlignment.MiddleRight);
                errorValidating.SetIconPadding(textBoxNewPassword, 4);
                return;
            }
            using (var db = new ApplicationContext())
            {
                if (db.RekeyDb(textBoxOldPassword.Text.Trim(), textBoxNewPassword.Text.Trim()))
                {
                    MessageBox.Show("Пароль был успешно изменен.", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxOldPassword.Text = "";
                    textBoxNewPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении пароля. Проверьте старый пароль.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            var settings = Settings.Load();
            if (settings != null || !string.IsNullOrEmpty(settings?.UserSourceDb ?? ""))
            {
                textBoxSourceFile.Text = settings.UserSourceDb;
            }
        }
    }
}
