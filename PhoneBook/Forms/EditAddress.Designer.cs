
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    partial class EditAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAddress));
            this.autoLabelLocality = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxLocality = new System.Windows.Forms.TextBox();
            this.autoLabelTypeStreet = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxTypeStreet = new System.Windows.Forms.TextBox();
            this.autoLabelStreetName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.autoLabelExample = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.uC_GridAddresses = new PhoneBook.UserControls.UC_GridPhones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.autoCompleteTypeStreet = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteLocality = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteHouse = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.autoCompleteStreetName = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.pnlGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteTypeStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteLocality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteStreetName)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabelLocality
            // 
            this.autoLabelLocality.DY = -24;
            this.autoLabelLocality.ForeColor = System.Drawing.Color.White;
            this.autoLabelLocality.Gap = 5;
            this.autoLabelLocality.LabeledControl = this.textBoxLocality;
            this.autoLabelLocality.Location = new System.Drawing.Point(34, 44);
            this.autoLabelLocality.Name = "autoLabelLocality";
            this.autoLabelLocality.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelLocality.Size = new System.Drawing.Size(276, 19);
            this.autoLabelLocality.TabIndex = 0;
            this.autoLabelLocality.Text = "Населенный пункт (если нужно):";
            // 
            // textBoxLocality
            // 
            this.autoCompleteLocality.SetAutoComplete(this.textBoxLocality, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBoxLocality.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxLocality.Location = new System.Drawing.Point(34, 68);
            this.textBoxLocality.Name = "textBoxLocality";
            this.textBoxLocality.Size = new System.Drawing.Size(276, 26);
            this.textBoxLocality.TabIndex = 0;
            this.textBoxLocality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelTypeStreet
            // 
            this.autoLabelTypeStreet.DY = -24;
            this.autoLabelTypeStreet.ForeColor = System.Drawing.Color.White;
            this.autoLabelTypeStreet.Gap = 5;
            this.autoLabelTypeStreet.LabeledControl = this.textBoxTypeStreet;
            this.autoLabelTypeStreet.Location = new System.Drawing.Point(34, 100);
            this.autoLabelTypeStreet.Name = "autoLabelTypeStreet";
            this.autoLabelTypeStreet.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelTypeStreet.Size = new System.Drawing.Size(95, 19);
            this.autoLabelTypeStreet.TabIndex = 0;
            this.autoLabelTypeStreet.Text = "Тип улицы:";
            // 
            // textBoxTypeStreet
            // 
            this.autoCompleteTypeStreet.SetAutoComplete(this.textBoxTypeStreet, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxTypeStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxTypeStreet.Location = new System.Drawing.Point(34, 124);
            this.textBoxTypeStreet.Name = "textBoxTypeStreet";
            this.textBoxTypeStreet.Size = new System.Drawing.Size(141, 27);
            this.textBoxTypeStreet.TabIndex = 1;
            // 
            // autoLabelStreetName
            // 
            this.autoLabelStreetName.DY = -24;
            this.autoLabelStreetName.ForeColor = System.Drawing.Color.White;
            this.autoLabelStreetName.Gap = 5;
            this.autoLabelStreetName.LabeledControl = this.textBoxStreetName;
            this.autoLabelStreetName.Location = new System.Drawing.Point(198, 100);
            this.autoLabelStreetName.Name = "autoLabelStreetName";
            this.autoLabelStreetName.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelStreetName.Size = new System.Drawing.Size(193, 19);
            this.autoLabelStreetName.TabIndex = 0;
            this.autoLabelStreetName.Text = "Наименование улицы:";
            // 
            // textBoxStreetName
            // 
            this.autoCompleteStreetName.SetAutoComplete(this.textBoxStreetName, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxStreetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxStreetName.Location = new System.Drawing.Point(198, 124);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(253, 27);
            this.textBoxStreetName.TabIndex = 2;
            // 
            // autoLabelExample
            // 
            this.autoLabelExample.DY = -24;
            this.autoLabelExample.ForeColor = System.Drawing.Color.White;
            this.autoLabelExample.Gap = 5;
            this.autoLabelExample.LabeledControl = this.textBoxHouse;
            this.autoLabelExample.Location = new System.Drawing.Point(474, 100);
            this.autoLabelExample.Name = "autoLabelExample";
            this.autoLabelExample.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelExample.Size = new System.Drawing.Size(74, 19);
            this.autoLabelExample.TabIndex = 0;
            this.autoLabelExample.Text = "Дом, №:";
            // 
            // textBoxHouse
            // 
            this.autoCompleteHouse.SetAutoComplete(this.textBoxHouse, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.textBoxHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxHouse.Location = new System.Drawing.Point(474, 124);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(85, 27);
            this.textBoxHouse.TabIndex = 3;
            this.textBoxHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Controls.Add(this.uC_GridAddresses);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(0, 206);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(594, 306);
            this.pnlGrid.TabIndex = 0;
            // 
            // uC_GridAddresses
            // 
            this.uC_GridAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_GridAddresses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridAddresses.Location = new System.Drawing.Point(0, 0);
            this.uC_GridAddresses.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridAddresses.Name = "uC_GridAddresses";
            this.uC_GridAddresses.Size = new System.Drawing.Size(594, 306);
            this.uC_GridAddresses.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.textBoxTypeStreet);
            this.panel1.Controls.Add(this.textBoxHouse);
            this.panel1.Controls.Add(this.textBoxStreetName);
            this.panel1.Controls.Add(this.textBoxLocality);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.autoLabelLocality);
            this.panel1.Controls.Add(this.autoLabelTypeStreet);
            this.panel1.Controls.Add(this.autoLabelStreetName);
            this.panel1.Controls.Add(this.autoLabelExample);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 206);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(551, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(232, 19);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Редактирование адреса n:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(375, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.Image = global::PhoneBook.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(227, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 32);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAdd.Image = global::PhoneBook.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(79, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // autoCompleteTypeStreet
            // 
            this.autoCompleteTypeStreet.HeaderFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteTypeStreet.ItemFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteTypeStreet.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteTypeStreet.ParentForm = this;
            this.autoCompleteTypeStreet.ShowCloseButton = false;
            this.autoCompleteTypeStreet.ShowColumnHeader = true;
            this.autoCompleteTypeStreet.ShowGripper = false;
            this.autoCompleteTypeStreet.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteTypeStreet.ThemeName = "Default";
            // 
            // autoCompleteLocality
            // 
            this.autoCompleteLocality.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteLocality.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteLocality.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteLocality.ParentForm = this;
            this.autoCompleteLocality.ShowCloseButton = false;
            this.autoCompleteLocality.ShowColumnHeader = true;
            this.autoCompleteLocality.ShowGripper = false;
            this.autoCompleteLocality.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteLocality.ThemeName = "Default";
            // 
            // autoCompleteHouse
            // 
            this.autoCompleteHouse.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteHouse.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteHouse.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteHouse.ParentForm = this;
            this.autoCompleteHouse.ShowCloseButton = false;
            this.autoCompleteHouse.ShowColumnHeader = true;
            this.autoCompleteHouse.ShowGripper = false;
            this.autoCompleteHouse.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteHouse.ThemeName = "Default";
            // 
            // autoCompleteStreetName
            // 
            this.autoCompleteStreetName.HeaderFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteStreetName.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoCompleteStreetName.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteStreetName.ParentForm = this;
            this.autoCompleteStreetName.ShowCloseButton = false;
            this.autoCompleteStreetName.ShowColumnHeader = true;
            this.autoCompleteStreetName.ShowGripper = false;
            this.autoCompleteStreetName.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoCompleteStreetName.ThemeName = "Default";
            // 
            // EditAddress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBarHeight = 6;
            this.ClientSize = new System.Drawing.Size(594, 512);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAddress";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditAddress_Load);
            this.pnlGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteTypeStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteLocality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteStreetName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLocality;
        private AutoLabel autoLabelLocality;
        private AutoLabel autoLabelTypeStreet;
        private AutoLabel autoLabelStreetName;
        private AutoLabel autoLabelExample;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.UC_GridPhones uC_GridAddresses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
        private AutoComplete autoCompleteTypeStreet;
        private AutoComplete autoCompleteLocality;
        private TextBox textBoxHouse;
        private TextBox textBoxStreetName;
        private AutoComplete autoCompleteHouse;
        private AutoComplete autoCompleteStreetName;
        private TextBox textBoxTypeStreet;
    }
}