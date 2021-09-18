using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.Forms;
using PhoneBook.UserControls;
using Syncfusion.Windows.Forms;

namespace PhoneBook
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings["UserSourceDb"] == null || string.IsNullOrEmpty(settings["UserSourceDb"].Value))
            {
                var settingsForm = new SettingsApp();
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    btnSearchClick(btnSearch, new EventArgs());
                }
            }
            else
            {
                btnSearchClick(btnSearch, new EventArgs());
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
            AddControlToPanel(new UC_Search());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnAdd);
            AddControlToPanel(new UC_Add());
        }
    }
}
