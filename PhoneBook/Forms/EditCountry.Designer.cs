
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.Forms
{
    partial class EditCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCountry));
            this.maskedEditBoxExample = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.maskedEditCountryCode = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.autoLabelCountryName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.autoLabelCountryCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCountDigits = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCountDigits = new System.Windows.Forms.MaskedTextBox();
            this.autoLabelExample = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.uC_GridCountries = new PhoneBook.UserControls.UC_GridPhones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBoxExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditCountryCode)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedEditBoxExample
            // 
            this.maskedEditBoxExample.BeforeTouchSize = new System.Drawing.Size(184, 27);
            this.maskedEditBoxExample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditBoxExample.Location = new System.Drawing.Point(271, 135);
            this.maskedEditBoxExample.Name = "maskedEditBoxExample";
            this.maskedEditBoxExample.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditBoxExample.Size = new System.Drawing.Size(184, 27);
            this.maskedEditBoxExample.TabIndex = 3;
            this.maskedEditBoxExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedEditBoxExample.Validated += new System.EventHandler(this.maskedEditBoxExample_Validated);
            // 
            // maskedEditCountryCode
            // 
            this.maskedEditCountryCode.BeforeTouchSize = new System.Drawing.Size(184, 27);
            this.maskedEditCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditCountryCode.Location = new System.Drawing.Point(271, 73);
            this.maskedEditCountryCode.Name = "maskedEditCountryCode";
            this.maskedEditCountryCode.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditCountryCode.Size = new System.Drawing.Size(184, 27);
            this.maskedEditCountryCode.TabIndex = 1;
            this.maskedEditCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelCountryName
            // 
            this.autoLabelCountryName.DX = -148;
            this.autoLabelCountryName.DY = 3;
            this.autoLabelCountryName.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountryName.Gap = 10;
            this.autoLabelCountryName.LabeledControl = this.textBoxCountryName;
            this.autoLabelCountryName.Location = new System.Drawing.Point(123, 46);
            this.autoLabelCountryName.Name = "autoLabelCountryName";
            this.autoLabelCountryName.Size = new System.Drawing.Size(138, 19);
            this.autoLabelCountryName.TabIndex = 0;
            this.autoLabelCountryName.Text = "Наименование:";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountryName.Location = new System.Drawing.Point(271, 43);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(184, 26);
            this.textBoxCountryName.TabIndex = 0;
            this.textBoxCountryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelCountryCode
            // 
            this.autoLabelCountryCode.DX = -119;
            this.autoLabelCountryCode.DY = 4;
            this.autoLabelCountryCode.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountryCode.Gap = 10;
            this.autoLabelCountryCode.LabeledControl = this.maskedEditCountryCode;
            this.autoLabelCountryCode.Location = new System.Drawing.Point(152, 77);
            this.autoLabelCountryCode.Name = "autoLabelCountryCode";
            this.autoLabelCountryCode.Size = new System.Drawing.Size(109, 19);
            this.autoLabelCountryCode.TabIndex = 0;
            this.autoLabelCountryCode.Text = "Код страны:";
            // 
            // autoLabelCountDigits
            // 
            this.autoLabelCountDigits.DX = -251;
            this.autoLabelCountDigits.DY = 4;
            this.autoLabelCountDigits.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountDigits.Gap = 10;
            this.autoLabelCountDigits.LabeledControl = this.textBoxCountDigits;
            this.autoLabelCountDigits.Location = new System.Drawing.Point(20, 108);
            this.autoLabelCountDigits.Name = "autoLabelCountDigits";
            this.autoLabelCountDigits.Size = new System.Drawing.Size(241, 19);
            this.autoLabelCountDigits.TabIndex = 0;
            this.autoLabelCountDigits.Text = "Количество цифр в номере:";
            // 
            // textBoxCountDigits
            // 
            this.textBoxCountDigits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountDigits.Location = new System.Drawing.Point(271, 104);
            this.textBoxCountDigits.Mask = "00";
            this.textBoxCountDigits.Name = "textBoxCountDigits";
            this.textBoxCountDigits.Size = new System.Drawing.Size(184, 27);
            this.textBoxCountDigits.TabIndex = 2;
            this.textBoxCountDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelExample
            // 
            this.autoLabelExample.DX = -158;
            this.autoLabelExample.DY = 4;
            this.autoLabelExample.ForeColor = System.Drawing.Color.White;
            this.autoLabelExample.Gap = 10;
            this.autoLabelExample.LabeledControl = this.maskedEditBoxExample;
            this.autoLabelExample.Location = new System.Drawing.Point(113, 139);
            this.autoLabelExample.Name = "autoLabelExample";
            this.autoLabelExample.Size = new System.Drawing.Size(148, 19);
            this.autoLabelExample.TabIndex = 0;
            this.autoLabelExample.Text = "Пример номера:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Controls.Add(this.uC_GridCountries);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(0, 224);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(502, 231);
            this.pnlGrid.TabIndex = 0;
            // 
            // uC_GridCountries
            // 
            this.uC_GridCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_GridCountries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridCountries.Location = new System.Drawing.Point(0, 0);
            this.uC_GridCountries.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridCountries.Name = "uC_GridCountries";
            this.uC_GridCountries.Size = new System.Drawing.Size(502, 231);
            this.uC_GridCountries.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.maskedEditBoxExample);
            this.panel1.Controls.Add(this.maskedEditCountryCode);
            this.panel1.Controls.Add(this.textBoxCountDigits);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBoxCountryName);
            this.panel1.Controls.Add(this.autoLabelCountryName);
            this.panel1.Controls.Add(this.autoLabelCountryCode);
            this.panel1.Controls.Add(this.autoLabelCountDigits);
            this.panel1.Controls.Add(this.autoLabelExample);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 224);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(468, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактирование списка стран:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(328, 176);
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
            this.btnEdit.Location = new System.Drawing.Point(180, 176);
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
            this.btnAdd.Location = new System.Drawing.Point(32, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorValidating
            // 
            this.errorValidating.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValidating.ContainerControl = this;
            // 
            // EditCountry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBarHeight = 6;
            this.ClientSize = new System.Drawing.Size(502, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditCountry";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBoxExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditCountryCode)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private AutoLabel autoLabelCountryName;
        private AutoLabel autoLabelCountryCode;
        private AutoLabel autoLabelCountDigits;
        private AutoLabel autoLabelExample;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.UC_GridPhones uC_GridCountries;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxCountDigits;
        private MaskedEditBox maskedEditBoxExample;
        private MaskedEditBox maskedEditCountryCode;
        private System.Windows.Forms.ErrorProvider errorValidating;
    }
}