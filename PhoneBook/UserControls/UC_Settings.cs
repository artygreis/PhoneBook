using PhoneBook.Forms;
using Squirrel;
using System;
using System.Windows.Forms;
using Settings = PhoneBook.Types.Settings;
using PhoneBook.SettingsControl;

namespace PhoneBook.UserControls
{
    public partial class UC_Settings : UserControl
    {
        private Button buttonSetting;
        public UC_Settings()
        {
            InitializeComponent();
        }
        public UC_Settings(Button button, bool update) : this()
        {
            buttonSetting = button;
            btnApplyUpdate.Visible = update;
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsApp();
            settingsForm.Text = $"Настройка нового телефонного справоника (базы данных)";
            settingsForm.ShowDialog();
        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            errorValidating.Clear();
            var settings = Settings.Load();
            if (string.IsNullOrEmpty(settings.Password))
            {
                MessageBox.Show("Невозможно задать пароль к базе данных, которая была создана без пароля.\n" +
                    "Можно изменить только существующий пароль!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
        private async void CheckForUpdates()
        {
            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/artygreis/PhoneBook"))
            {
                var result = await mgr.UpdateApp();
                if (result != null)
                {
                    SettingsPicture.AddTextToPicture(buttonSetting);
                    btnApplyUpdate.Visible = true;
                }
                    
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckForUpdates();
        }

        private void btnApplyUpdate_Click(object sender, EventArgs e)
        {
            UpdateManager.RestartApp();
        }
    }
}
