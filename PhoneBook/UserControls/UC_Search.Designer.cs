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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Search));
            this.autoCompleteCountry = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCountry1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlAdv = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.searchNotCallTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxCountryNotCall = new System.Windows.Forms.TextBox();
            this.autoLabelCountryNotCall = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCityNotCall = new System.Windows.Forms.TextBox();
            this.autoLabelCityNotCall = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchByAddressTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxApartment = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.autoLabelCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelApartment = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.searchByPhoneTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.maskedEditNumber = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.autoLabelCity1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCity1 = new System.Windows.Forms.TextBox();
            this.autoLabelNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCountry1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnSearchByPhone = new System.Windows.Forms.Button();
            this.uC_GridPhones = new PhoneBook.UserControls.UC_GridPhones();
            this.panel5 = new System.Windows.Forms.Panel();
            this.autoCompleteCity = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteAddress = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteCountry1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteCity1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.autoCompleteCountryNotCall = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteCityNotCall = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv)).BeginInit();
            this.tabControlAdv.SuspendLayout();
            this.searchNotCallTab.SuspendLayout();
            this.searchByAddressTab.SuspendLayout();
            this.searchByPhoneTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountryNotCall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCityNotCall)).BeginInit();
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
            this.textBoxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountry.Location = new System.Drawing.Point(103, 15);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(170, 26);
            this.textBoxCountry.TabIndex = 0;
            // 
            // textBoxCountry1
            // 
            this.autoCompleteCountry1.SetAutoComplete(this.textBoxCountry1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCountry1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountry1.Location = new System.Drawing.Point(103, 15);
            this.textBoxCountry1.Name = "textBoxCountry1";
            this.textBoxCountry1.Size = new System.Drawing.Size(170, 26);
            this.textBoxCountry1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.tabControlAdv);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 162);
            this.panel1.TabIndex = 1;
            // 
            // tabControlAdv
            // 
            this.tabControlAdv.BeforeTouchSize = new System.Drawing.Size(674, 154);
            this.tabControlAdv.Controls.Add(this.searchByAddressTab);
            this.tabControlAdv.Controls.Add(this.searchByPhoneTab);
            this.tabControlAdv.Controls.Add(this.searchNotCallTab);
            this.tabControlAdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv.Location = new System.Drawing.Point(8, 8);
            this.tabControlAdv.Name = "tabControlAdv";
            this.tabControlAdv.Size = new System.Drawing.Size(674, 154);
            this.tabControlAdv.TabIndex = 6;
            this.tabControlAdv.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv_SelectedIndexChanged);
            // 
            // searchNotCallTab
            // 
            this.searchNotCallTab.Controls.Add(this.btnDelete);
            this.searchNotCallTab.Controls.Add(this.btnEdit);
            this.searchNotCallTab.Controls.Add(this.textBoxCountryNotCall);
            this.searchNotCallTab.Controls.Add(this.autoLabelCountryNotCall);
            this.searchNotCallTab.Controls.Add(this.textBoxCityNotCall);
            this.searchNotCallTab.Controls.Add(this.autoLabelCityNotCall);
            this.searchNotCallTab.Controls.Add(this.btnAdd);
            this.searchNotCallTab.Image = null;
            this.searchNotCallTab.ImageSize = new System.Drawing.Size(16, 16);
            this.searchNotCallTab.Location = new System.Drawing.Point(1, 31);
            this.searchNotCallTab.Name = "searchNotCallTab";
            this.searchNotCallTab.ShowCloseButton = true;
            this.searchNotCallTab.Size = new System.Drawing.Size(671, 121);
            this.searchNotCallTab.TabForeColor = System.Drawing.Color.White;
            this.searchNotCallTab.TabIndex = 1;
            this.searchNotCallTab.Text = "Не звонить";
            this.searchNotCallTab.ThemesEnabled = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(533, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = " Удалить";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(359, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = " Редактировать";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxCountryNotCall
            // 
            this.autoCompleteCountryNotCall.SetAutoComplete(this.textBoxCountryNotCall, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCountryNotCall.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountryNotCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountryNotCall.Location = new System.Drawing.Point(103, 15);
            this.textBoxCountryNotCall.Name = "textBoxCountryNotCall";
            this.textBoxCountryNotCall.Size = new System.Drawing.Size(170, 26);
            this.textBoxCountryNotCall.TabIndex = 7;
            // 
            // autoLabelCountryNotCall
            // 
            this.autoLabelCountryNotCall.DX = -86;
            this.autoLabelCountryNotCall.DY = 3;
            this.autoLabelCountryNotCall.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountryNotCall.Gap = 10;
            this.autoLabelCountryNotCall.LabeledControl = this.textBoxCountryNotCall;
            this.autoLabelCountryNotCall.Location = new System.Drawing.Point(17, 18);
            this.autoLabelCountryNotCall.Name = "autoLabelCountryNotCall";
            this.autoLabelCountryNotCall.Size = new System.Drawing.Size(76, 19);
            this.autoLabelCountryNotCall.TabIndex = 8;
            this.autoLabelCountryNotCall.Text = "Страна:";
            // 
            // textBoxCityNotCall
            // 
            this.autoCompleteCityNotCall.SetAutoComplete(this.textBoxCityNotCall, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCityNotCall.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCityNotCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCityNotCall.Location = new System.Drawing.Point(414, 15);
            this.textBoxCityNotCall.Name = "textBoxCityNotCall";
            this.textBoxCityNotCall.Size = new System.Drawing.Size(170, 26);
            this.textBoxCityNotCall.TabIndex = 12;
            // 
            // autoLabelCityNotCall
            // 
            this.autoLabelCityNotCall.DX = -71;
            this.autoLabelCityNotCall.DY = 3;
            this.autoLabelCityNotCall.ForeColor = System.Drawing.Color.White;
            this.autoLabelCityNotCall.Gap = 10;
            this.autoLabelCityNotCall.LabeledControl = this.textBoxCityNotCall;
            this.autoLabelCityNotCall.Location = new System.Drawing.Point(343, 18);
            this.autoLabelCityNotCall.Name = "autoLabelCityNotCall";
            this.autoLabelCityNotCall.Size = new System.Drawing.Size(61, 19);
            this.autoLabelCityNotCall.TabIndex = 12;
            this.autoLabelCityNotCall.Text = "Город:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(222, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = " Добавить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.panel3.Size = new System.Drawing.Size(8, 162);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 162);
            this.panel2.TabIndex = 0;
            // 
            // searchByAddressTab
            // 
            this.searchByAddressTab.Controls.Add(this.btnExportToPdf);
            this.searchByAddressTab.Controls.Add(this.btnSearch);
            this.searchByAddressTab.Controls.Add(this.textBoxCity);
            this.searchByAddressTab.Controls.Add(this.textBoxApartment);
            this.searchByAddressTab.Controls.Add(this.textBoxAddress);
            this.searchByAddressTab.Controls.Add(this.textBoxCountry);
            this.searchByAddressTab.Controls.Add(this.autoLabelCity);
            this.searchByAddressTab.Controls.Add(this.autoLabelApartment);
            this.searchByAddressTab.Controls.Add(this.autoLabelAddress);
            this.searchByAddressTab.Controls.Add(this.autoLabelCountry);
            this.searchByAddressTab.Image = null;
            this.searchByAddressTab.ImageSize = new System.Drawing.Size(16, 16);
            this.searchByAddressTab.Location = new System.Drawing.Point(1, 31);
            this.searchByAddressTab.Name = "searchByAddressTab";
            this.searchByAddressTab.ShowCloseButton = true;
            this.searchByAddressTab.Size = new System.Drawing.Size(671, 121);
            this.searchByAddressTab.TabFont = null;
            this.searchByAddressTab.TabForeColor = System.Drawing.Color.White;
            this.searchByAddressTab.TabIndex = 1;
            this.searchByAddressTab.Text = "Поиск по адресу";
            this.searchByAddressTab.ThemesEnabled = false;
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportToPdf.BackColor = System.Drawing.Color.White;
            this.btnExportToPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToPdf.Image")));
            this.btnExportToPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToPdf.Location = new System.Drawing.Point(478, 83);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(173, 32);
            this.btnExportToPdf.TabIndex = 5;
            this.btnExportToPdf.Text = "     Экспорт в PDF";
            this.btnExportToPdf.UseVisualStyleBackColor = false;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(297, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "     Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxCity
            // 
            this.autoCompleteCity.SetAutoComplete(this.textBoxCity, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCity.Location = new System.Drawing.Point(414, 15);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(170, 26);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxApartment
            // 
            this.textBoxApartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxApartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxApartment.Location = new System.Drawing.Point(568, 50);
            this.textBoxApartment.Name = "textBoxApartment";
            this.textBoxApartment.Size = new System.Drawing.Size(49, 26);
            this.textBoxApartment.TabIndex = 4;
            this.textBoxApartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAddress
            // 
            this.autoCompleteAddress.SetAutoComplete(this.textBoxAddress, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxAddress.Location = new System.Drawing.Point(103, 50);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(409, 26);
            this.textBoxAddress.TabIndex = 2;
            // 
            // autoLabelCity
            // 
            this.autoLabelCity.DX = -110;
            this.autoLabelCity.DY = 1;
            this.autoLabelCity.ForeColor = System.Drawing.Color.White;
            this.autoLabelCity.Gap = 10;
            this.autoLabelCity.LabeledControl = this.textBoxCity;
            this.autoLabelCity.Location = new System.Drawing.Point(304, 16);
            this.autoLabelCity.Name = "autoLabelCity";
            this.autoLabelCity.Size = new System.Drawing.Size(43, 15);
            this.autoLabelCity.TabIndex = 0;
            this.autoLabelCity.Text = "Город:";
            // 
            // autoLabelApartment
            // 
            this.autoLabelApartment.DX = -110;
            this.autoLabelApartment.DY = 1;
            this.autoLabelApartment.ForeColor = System.Drawing.Color.White;
            this.autoLabelApartment.Gap = 10;
            this.autoLabelApartment.LabeledControl = this.textBoxApartment;
            this.autoLabelApartment.Location = new System.Drawing.Point(458, 51);
            this.autoLabelApartment.Name = "autoLabelApartment";
            this.autoLabelApartment.Size = new System.Drawing.Size(24, 15);
            this.autoLabelApartment.TabIndex = 0;
            this.autoLabelApartment.Text = "КВ.";
            // 
            // autoLabelAddress
            // 
            this.autoLabelAddress.DX = -120;
            this.autoLabelAddress.DY = 1;
            this.autoLabelAddress.ForeColor = System.Drawing.Color.White;
            this.autoLabelAddress.Gap = 20;
            this.autoLabelAddress.LabeledControl = this.textBoxAddress;
            this.autoLabelAddress.Location = new System.Drawing.Point(-17, 51);
            this.autoLabelAddress.Name = "autoLabelAddress";
            this.autoLabelAddress.Size = new System.Drawing.Size(43, 15);
            this.autoLabelAddress.TabIndex = 0;
            this.autoLabelAddress.Text = "Адрес:";
            // 
            // autoLabelCountry
            // 
            this.autoLabelCountry.DX = -110;
            this.autoLabelCountry.DY = 1;
            this.autoLabelCountry.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountry.Gap = 10;
            this.autoLabelCountry.LabeledControl = this.textBoxCountry;
            this.autoLabelCountry.Location = new System.Drawing.Point(-7, 16);
            this.autoLabelCountry.Name = "autoLabelCountry";
            this.autoLabelCountry.Size = new System.Drawing.Size(49, 15);
            this.autoLabelCountry.TabIndex = 0;
            this.autoLabelCountry.Text = "Страна:";
            // 
            // searchByPhoneTab
            // 
            this.searchByPhoneTab.Controls.Add(this.maskedEditNumber);
            this.searchByPhoneTab.Controls.Add(this.autoLabelCity1);
            this.searchByPhoneTab.Controls.Add(this.textBoxCity1);
            this.searchByPhoneTab.Controls.Add(this.autoLabelNumber);
            this.searchByPhoneTab.Controls.Add(this.autoLabelCountry1);
            this.searchByPhoneTab.Controls.Add(this.textBoxCountry1);
            this.searchByPhoneTab.Controls.Add(this.btnSearchByPhone);
            this.searchByPhoneTab.Image = null;
            this.searchByPhoneTab.ImageSize = new System.Drawing.Size(16, 16);
            this.searchByPhoneTab.Location = new System.Drawing.Point(1, 31);
            this.searchByPhoneTab.Name = "searchByPhoneTab";
            this.searchByPhoneTab.ShowCloseButton = true;
            this.searchByPhoneTab.Size = new System.Drawing.Size(671, 121);
            this.searchByPhoneTab.TabFont = null;
            this.searchByPhoneTab.TabForeColor = System.Drawing.Color.White;
            this.searchByPhoneTab.TabIndex = 1;
            this.searchByPhoneTab.Text = "Поиск по номеру телефону";
            this.searchByPhoneTab.ThemesEnabled = false;
            // 
            // maskedEditNumber
            // 
            this.maskedEditNumber.BeforeTouchSize = new System.Drawing.Size(178, 26);
            this.maskedEditNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskedEditNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maskedEditNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditNumber.Location = new System.Drawing.Point(193, 50);
            this.maskedEditNumber.Name = "maskedEditNumber";
            this.maskedEditNumber.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditNumber.Size = new System.Drawing.Size(178, 26);
            this.maskedEditNumber.TabIndex = 13;
            this.maskedEditNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelCity1
            // 
            this.autoLabelCity1.DX = -53;
            this.autoLabelCity1.DY = 5;
            this.autoLabelCity1.ForeColor = System.Drawing.Color.White;
            this.autoLabelCity1.Gap = 10;
            this.autoLabelCity1.LabeledControl = this.textBoxCity1;
            this.autoLabelCity1.Location = new System.Drawing.Point(361, 20);
            this.autoLabelCity1.Name = "autoLabelCity1";
            this.autoLabelCity1.Size = new System.Drawing.Size(43, 15);
            this.autoLabelCity1.TabIndex = 12;
            this.autoLabelCity1.Text = "Город:";
            // 
            // textBoxCity1
            // 
            this.autoCompleteCity1.SetAutoComplete(this.textBoxCity1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxCity1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCity1.Location = new System.Drawing.Point(414, 15);
            this.textBoxCity1.Name = "textBoxCity1";
            this.textBoxCity1.Size = new System.Drawing.Size(170, 26);
            this.textBoxCity1.TabIndex = 11;
            // 
            // autoLabelNumber
            // 
            this.autoLabelNumber.DX = -120;
            this.autoLabelNumber.DY = 1;
            this.autoLabelNumber.ForeColor = System.Drawing.Color.White;
            this.autoLabelNumber.Gap = 20;
            this.autoLabelNumber.LabeledControl = this.maskedEditNumber;
            this.autoLabelNumber.Location = new System.Drawing.Point(73, 51);
            this.autoLabelNumber.Name = "autoLabelNumber";
            this.autoLabelNumber.Size = new System.Drawing.Size(104, 15);
            this.autoLabelNumber.TabIndex = 10;
            this.autoLabelNumber.Text = "Номер телефона:";
            // 
            // autoLabelCountry1
            // 
            this.autoLabelCountry1.DX = -59;
            this.autoLabelCountry1.DY = 5;
            this.autoLabelCountry1.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountry1.Gap = 10;
            this.autoLabelCountry1.LabeledControl = this.textBoxCountry1;
            this.autoLabelCountry1.Location = new System.Drawing.Point(44, 20);
            this.autoLabelCountry1.Name = "autoLabelCountry1";
            this.autoLabelCountry1.Size = new System.Drawing.Size(49, 15);
            this.autoLabelCountry1.TabIndex = 8;
            this.autoLabelCountry1.Text = "Страна:";
            // 
            // btnSearchByPhone
            // 
            this.btnSearchByPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchByPhone.BackColor = System.Drawing.Color.White;
            this.btnSearchByPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByPhone.Image")));
            this.btnSearchByPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByPhone.Location = new System.Drawing.Point(297, 83);
            this.btnSearchByPhone.Name = "btnSearchByPhone";
            this.btnSearchByPhone.Size = new System.Drawing.Size(107, 32);
            this.btnSearchByPhone.TabIndex = 6;
            this.btnSearchByPhone.Text = "     Найти";
            this.btnSearchByPhone.UseVisualStyleBackColor = false;
            this.btnSearchByPhone.Click += new System.EventHandler(this.btnSearchByPhone_Click);
            // 
            // uC_GridPhones
            // 
            this.uC_GridPhones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uC_GridPhones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridPhones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridPhones.Location = new System.Drawing.Point(0, 162);
            this.uC_GridPhones.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridPhones.Name = "uC_GridPhones";
            this.uC_GridPhones.Size = new System.Drawing.Size(690, 282);
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
            // autoCompleteCountry1
            // 
            this.autoCompleteCountry1.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountry1.ItemFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountry1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCountry1.ParentForm = this;
            this.autoCompleteCountry1.ShowCloseButton = false;
            this.autoCompleteCountry1.ShowColumnHeader = true;
            this.autoCompleteCountry1.ShowGripper = false;
            this.autoCompleteCountry1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCountry1.ThemeName = "Default";
            this.autoCompleteCountry1.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCountry1_AutoCompleteItemSelected);
            // 
            // autoCompleteCity1
            // 
            this.autoCompleteCity1.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCity1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCity1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCity1.ParentForm = this;
            this.autoCompleteCity1.ShowCloseButton = false;
            this.autoCompleteCity1.ShowColumnHeader = true;
            this.autoCompleteCity1.ShowGripper = false;
            this.autoCompleteCity1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCity1.ThemeName = "Default";
            this.autoCompleteCity1.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCity1_AutoCompleteItemSelected);
            // 
            // autoCompleteCountryNotCall
            // 
            this.autoCompleteCountryNotCall.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountryNotCall.ItemFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCountryNotCall.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCountryNotCall.ParentForm = this;
            this.autoCompleteCountryNotCall.ShowCloseButton = false;
            this.autoCompleteCountryNotCall.ShowColumnHeader = true;
            this.autoCompleteCountryNotCall.ShowGripper = false;
            this.autoCompleteCountryNotCall.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCountryNotCall.ThemeName = "Default";
            this.autoCompleteCountryNotCall.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCountryNotCall_AutoCompleteItemSelected);
            // 
            // autoCompleteCityNotCall
            // 
            this.autoCompleteCityNotCall.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCityNotCall.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteCityNotCall.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCityNotCall.ParentForm = this;
            this.autoCompleteCityNotCall.ShowCloseButton = false;
            this.autoCompleteCityNotCall.ShowColumnHeader = true;
            this.autoCompleteCityNotCall.ShowGripper = false;
            this.autoCompleteCityNotCall.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteCityNotCall.ThemeName = "Default";
            this.autoCompleteCityNotCall.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoCompleteCityNotCall_AutoCompleteItemSelected);
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
            this.Load += new System.EventHandler(this.UC_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv)).EndInit();
            this.tabControlAdv.ResumeLayout(false);
            this.searchNotCallTab.ResumeLayout(false);
            this.searchNotCallTab.PerformLayout();
            this.searchByAddressTab.ResumeLayout(false);
            this.searchByAddressTab.PerformLayout();
            this.searchByPhoneTab.ResumeLayout(false);
            this.searchByPhoneTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCountryNotCall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCityNotCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_GridPhones uC_GridPhones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private AutoLabel autoLabelCountry;
        private AutoComplete autoCompleteCountry;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private AutoLabel autoLabelCity;
        private AutoComplete autoCompleteCity;
        private AutoLabel autoLabelAddress;
        private TextBox textBoxApartment;
        private TextBox textBoxAddress;
        private AutoLabel autoLabelApartment;
        private Button btnSearch;
        private AutoComplete autoCompleteAddress;
        private TabControlAdv tabControlAdv;
        private TabPageAdv searchByAddressTab;
        private TabPageAdv searchByPhoneTab;
        private TabPageAdv searchNotCallTab;
        private AutoLabel autoLabelCountry1;
        private TextBox textBoxCountry1;
        private Button btnSearchByPhone;
        private AutoLabel autoLabelNumber;
        private AutoLabel autoLabelCity1;
        private TextBox textBoxCity1;
        private AutoComplete autoCompleteCountry1;
        private AutoComplete autoCompleteCity1;
        private AutoComplete autoCompleteCountryNotCall;
        private AutoComplete autoCompleteCityNotCall;
        private AutoLabel autoLabelCountryNotCall;
        private TextBox textBoxCountryNotCall;
        private AutoLabel autoLabelCityNotCall;
        private TextBox textBoxCityNotCall;
        private MaskedEditBox maskedEditNumber;
        private Button btnExportToPdf;
        private SaveFileDialog saveFileDialog;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
    }
}
