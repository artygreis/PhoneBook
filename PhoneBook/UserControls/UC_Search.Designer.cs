using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;

namespace PhoneBook.UserControls
{
    partial class UC_Search
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.autoCompleteCountry = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxApartment = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.autoLabelCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelApartment = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelHouse = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_GridPhones = new PhoneBook.UserControls.UC_GridPhones();
            this.panel5 = new System.Windows.Forms.Panel();
            this.autoCompleteCity = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteAddress = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // autoCompleteCountry
            // 
            this.autoCompleteCountry.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountry.ItemFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountry.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCountry.ParentForm = this;
            this.autoCompleteCountry.ShowCloseButton = false;
            this.autoCompleteCountry.ShowColumnHeader = true;
            this.autoCompleteCountry.ShowGripper = false;
            this.autoCompleteCountry.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCountry.ThemeName = "Default";
            this.autoCompleteCountry.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCountry_AutoCompleteItemSelected);
            // 
            // textBoxCountry
            // 
            this.autoCompleteCountry.SetAutoComplete(this.textBoxCountry, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCountry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.Location = new System.Drawing.Point(104, 18);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(169, 26);
            this.textBoxCountry.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.textBoxApartment);
            this.panel1.Controls.Add(this.textBoxHouse);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.textBoxCountry);
            this.panel1.Controls.Add(this.autoLabelCity);
            this.panel1.Controls.Add(this.autoLabelApartment);
            this.panel1.Controls.Add(this.autoLabelHouse);
            this.panel1.Controls.Add(this.autoLabelAddress);
            this.panel1.Controls.Add(this.autoLabelCountry);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 135);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(262, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxCity
            // 
            this.autoCompleteCity.SetAutoComplete(this.textBoxCity, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.Location = new System.Drawing.Point(414, 19);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(169, 26);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxApartment
            // 
            this.textBoxApartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxApartment.Location = new System.Drawing.Point(571, 60);
            this.textBoxApartment.Name = "textBoxApartment";
            this.textBoxApartment.Size = new System.Drawing.Size(49, 26);
            this.textBoxApartment.TabIndex = 4;
            this.textBoxApartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxHouse.Location = new System.Drawing.Point(466, 60);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(49, 26);
            this.textBoxHouse.TabIndex = 3;
            this.textBoxHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            this.autoCompleteAddress.SetAutoComplete(this.textBoxAddress, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(104, 60);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(312, 26);
            this.textBoxAddress.TabIndex = 2;
            // 
            // autoLabelCity
            // 
            this.autoLabelCity.DX = -71;
            this.autoLabelCity.DY = 3;
            this.autoLabelCity.ForeColor = System.Drawing.Color.White;
            this.autoLabelCity.Gap = 10;
            this.autoLabelCity.LabeledControl = this.textBoxCity;
            this.autoLabelCity.Location = new System.Drawing.Point(343, 22);
            this.autoLabelCity.Name = "autoLabelCity";
            this.autoLabelCity.Size = new System.Drawing.Size(61, 19);
            this.autoLabelCity.TabIndex = 0;
            this.autoLabelCity.Text = "Город:";
            // 
            // autoLabelApartment
            // 
            this.autoLabelApartment.DX = -42;
            this.autoLabelApartment.DY = 3;
            this.autoLabelApartment.ForeColor = System.Drawing.Color.White;
            this.autoLabelApartment.Gap = 10;
            this.autoLabelApartment.LabeledControl = this.textBoxApartment;
            this.autoLabelApartment.Location = new System.Drawing.Point(529, 63);
            this.autoLabelApartment.Name = "autoLabelApartment";
            this.autoLabelApartment.Size = new System.Drawing.Size(32, 19);
            this.autoLabelApartment.TabIndex = 0;
            this.autoLabelApartment.Text = "КВ.";
            // 
            // autoLabelHouse
            // 
            this.autoLabelHouse.DX = -35;
            this.autoLabelHouse.DY = 3;
            this.autoLabelHouse.ForeColor = System.Drawing.Color.White;
            this.autoLabelHouse.Gap = 10;
            this.autoLabelHouse.LabeledControl = this.textBoxHouse;
            this.autoLabelHouse.Location = new System.Drawing.Point(431, 63);
            this.autoLabelHouse.Name = "autoLabelHouse";
            this.autoLabelHouse.Size = new System.Drawing.Size(25, 19);
            this.autoLabelHouse.TabIndex = 0;
            this.autoLabelHouse.Text = "Д.";
            // 
            // autoLabelAddress
            // 
            this.autoLabelAddress.DX = -86;
            this.autoLabelAddress.DY = 3;
            this.autoLabelAddress.ForeColor = System.Drawing.Color.White;
            this.autoLabelAddress.Gap = 20;
            this.autoLabelAddress.LabeledControl = this.textBoxAddress;
            this.autoLabelAddress.Location = new System.Drawing.Point(18, 63);
            this.autoLabelAddress.Name = "autoLabelAddress";
            this.autoLabelAddress.Size = new System.Drawing.Size(66, 19);
            this.autoLabelAddress.TabIndex = 0;
            this.autoLabelAddress.Text = "Адрес:";
            // 
            // autoLabelCountry
            // 
            this.autoLabelCountry.DX = -86;
            this.autoLabelCountry.DY = 3;
            this.autoLabelCountry.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountry.Gap = 10;
            this.autoLabelCountry.LabeledControl = this.textBoxCountry;
            this.autoLabelCountry.Location = new System.Drawing.Point(18, 21);
            this.autoLabelCountry.Name = "autoLabelCountry";
            this.autoLabelCountry.Size = new System.Drawing.Size(76, 19);
            this.autoLabelCountry.TabIndex = 0;
            this.autoLabelCountry.Text = "Страна:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 8);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(682, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 135);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 135);
            this.panel2.TabIndex = 0;
            // 
            // uC_GridPhones
            // 
            this.uC_GridPhones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uC_GridPhones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridPhones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridPhones.Location = new System.Drawing.Point(0, 135);
            this.uC_GridPhones.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridPhones.Name = "uC_GridPhones";
            this.uC_GridPhones.Size = new System.Drawing.Size(690, 309);
            this.uC_GridPhones.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.uC_GridPhones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(690, 444);
            this.panel5.TabIndex = 1;
            // 
            // autoCompleteCity
            // 
            this.autoCompleteCity.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCity.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCity.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCity.ParentForm = this;
            this.autoCompleteCity.ShowCloseButton = false;
            this.autoCompleteCity.ShowColumnHeader = true;
            this.autoCompleteCity.ShowGripper = false;
            this.autoCompleteCity.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCity.ThemeName = "Default";
            this.autoCompleteCity.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCity_AutoCompleteItemSelected);
            // 
            // autoCompleteAddress
            // 
            this.autoCompleteAddress.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteAddress.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteAddress.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteAddress.ParentForm = this;
            this.autoCompleteAddress.ShowCloseButton = false;
            this.autoCompleteAddress.ShowColumnHeader = true;
            this.autoCompleteAddress.ShowGripper = false;
            this.autoCompleteAddress.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteAddress.ThemeName = "Default";
            this.autoCompleteAddress.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteAddress_AutoCompleteItemSelected);
            // 
            // UC_Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(690, 444);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_GridPhones uC_GridPhones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabelCountry;
        private AutoComplete autoCompleteCountry;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private AutoLabel autoLabelCity;
        private AutoComplete autoCompleteCity;
        private AutoLabel autoLabelAddress;
        private TextBox textBoxApartment;
        private TextBox textBoxHouse;
        private TextBox textBoxAddress;
        private AutoLabel autoLabelApartment;
        private AutoLabel autoLabelHouse;
        private Button button1;
        private AutoComplete autoCompleteAddress;
    }
}
