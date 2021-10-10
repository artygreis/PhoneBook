using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.Forms;
using PhoneBook.SettingsControl;
using PhoneBook.Types;
using PhoneBook.UserControls;
using Squirrel;
using Syncfusion.Windows.Forms;

namespace PhoneBook
{
    public partial class MainForm : MetroForm
    {
        private bool availableUpdate = false;
        public MainForm()
        {
            InitializeComponent();
            if (!CheckExistDb())
            {
                var settingsForm = new SettingsApp();
                settingsForm.ShowDialog();
            }
            btnSearchClick(btnSearch, new EventArgs());
            CheckForUpdates();
        }
        private bool CheckExistDb()
        {
            var settings = Settings.Load();
            if (settings == null || string.IsNullOrEmpty(settings?.UserSourceDb ?? ""))
                return false;

            if (!string.IsNullOrEmpty(settings?.UserSourceDb ?? "") && !File.Exists(settings.UserSourceDb))
            {
                settings.UserSourceDb = "";
                settings.Password = "";
                settings.Save();
                return false;
            }
                
            return true;
        }
        private async void CheckForUpdates()
        {
            using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/artygreis/PhoneBook"))
            {
                var result = await mgr.UpdateApp();
                if (result != null)
                {
                    SettingsPicture.AddTextToPicture(btnSettings);
                    availableUpdate = true;
                }
            }
        }
        private void MoveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnSearchClick(object sender, EventArgs e)
        {
            MoveSidePanel(btnSearch);
            if (CheckExistDb())
                AddControlToPanel(new UC_Search());
            else
                AddControlToPanel(new UC_ErrorConnect());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnAdd);
            if (CheckExistDb())
                AddControlToPanel(new UC_Add());
            else
                AddControlToPanel(new UC_ErrorConnect());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSettings);
            AddControlToPanel(new UC_Settings(btnSettings, availableUpdate));
        }
    }
}
