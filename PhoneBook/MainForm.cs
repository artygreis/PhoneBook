using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.UserControls;
using Syncfusion.Windows.Forms;

namespace PhoneBook
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            btnSearchClick(btnSearch, new EventArgs());
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            DbInitializer.InitializeDb();
        }
    }
}
