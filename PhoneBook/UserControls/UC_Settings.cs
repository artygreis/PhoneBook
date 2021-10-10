using PhoneBook.Forms;
using Squirrel;
using System;
using System.Windows.Forms;
using Settings = PhoneBook.Types.Settings;
using System.Threading.Tasks;
using System.Drawing;

namespace PhoneBook.UserControls
{
    public partial class UC_Settings : UserControl
    {
        private Button buttonSetting;
        public UC_Settings()
        {
            InitializeComponent();
        }
        public UC_Settings(Button button) : this()
        {
            buttonSetting = button;
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
        private async void CheckForUpdates()
        {
            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/artygreis/PhoneBook"))
            {
                var result = await mgr.UpdateApp();
                if (result != null)
                {
                    AddTextToPicture();
                    btnApplyUpdate.Visible = true;
                }
                    
            }
        }
        private void AddTextToPicture()
        {
            string firstText = "!";

            PointF firstLocation = new PointF(3f, 0f);

            //previousBitmap = new Bitmap((Bitmap)button1.Image);

            Bitmap bitmap = (Bitmap)buttonSetting.Image;//load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Century Gothic", 10, FontStyle.Bold))
                {
                    graphics.FillEllipse(new SolidBrush(Color.Red), 0f, 0f, 15, 15);
                    graphics.DrawString(firstText, arialFont, Brushes.White, firstLocation);
                }
            }
            buttonSetting.Image = null;
            buttonSetting.Image = bitmap;
            //bitmap.Save(imageFilePath);//save the image file
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
