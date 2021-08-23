
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCountry));
            this.autoLabelCountryName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.autoLabelCountryCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCountryCode = new System.Windows.Forms.TextBox();
            this.autoLabelCountDigits = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCountDigits = new System.Windows.Forms.TextBox();
            this.autoLabelExample = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.uC_GridCountries = new PhoneBook.UserControls.UC_GridPhones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.textBoxCountryName.TabIndex = 2;
            // 
            // autoLabelCountryCode
            // 
            this.autoLabelCountryCode.DX = -119;
            this.autoLabelCountryCode.DY = 3;
            this.autoLabelCountryCode.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountryCode.Gap = 10;
            this.autoLabelCountryCode.LabeledControl = this.textBoxCountryCode;
            this.autoLabelCountryCode.Location = new System.Drawing.Point(152, 78);
            this.autoLabelCountryCode.Name = "autoLabelCountryCode";
            this.autoLabelCountryCode.Size = new System.Drawing.Size(109, 19);
            this.autoLabelCountryCode.TabIndex = 0;
            this.autoLabelCountryCode.Text = "Код страны:";
            // 
            // textBoxCountryCode
            // 
            this.textBoxCountryCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountryCode.Location = new System.Drawing.Point(271, 75);
            this.textBoxCountryCode.Name = "textBoxCountryCode";
            this.textBoxCountryCode.Size = new System.Drawing.Size(184, 26);
            this.textBoxCountryCode.TabIndex = 3;
            // 
            // autoLabelCountDigits
            // 
            this.autoLabelCountDigits.DX = -251;
            this.autoLabelCountDigits.DY = 3;
            this.autoLabelCountDigits.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountDigits.Gap = 10;
            this.autoLabelCountDigits.LabeledControl = this.textBoxCountDigits;
            this.autoLabelCountDigits.Location = new System.Drawing.Point(20, 110);
            this.autoLabelCountDigits.Name = "autoLabelCountDigits";
            this.autoLabelCountDigits.Size = new System.Drawing.Size(241, 19);
            this.autoLabelCountDigits.TabIndex = 0;
            this.autoLabelCountDigits.Text = "Количество цифр в номере:";
            // 
            // textBoxCountDigits
            // 
            this.textBoxCountDigits.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountDigits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCountDigits.Location = new System.Drawing.Point(271, 107);
            this.textBoxCountDigits.Name = "textBoxCountDigits";
            this.textBoxCountDigits.Size = new System.Drawing.Size(184, 26);
            this.textBoxCountDigits.TabIndex = 4;
            // 
            // autoLabelExample
            // 
            this.autoLabelExample.DX = -158;
            this.autoLabelExample.DY = 3;
            this.autoLabelExample.ForeColor = System.Drawing.Color.White;
            this.autoLabelExample.Gap = 10;
            this.autoLabelExample.LabeledControl = this.textBoxExample;
            this.autoLabelExample.Location = new System.Drawing.Point(113, 142);
            this.autoLabelExample.Name = "autoLabelExample";
            this.autoLabelExample.Size = new System.Drawing.Size(148, 19);
            this.autoLabelExample.TabIndex = 0;
            this.autoLabelExample.Text = "Пример номера:";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxExample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxExample.Location = new System.Drawing.Point(271, 139);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(184, 26);
            this.textBoxExample.TabIndex = 5;
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
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBoxExample);
            this.panel1.Controls.Add(this.textBoxCountDigits);
            this.panel1.Controls.Add(this.textBoxCountryName);
            this.panel1.Controls.Add(this.textBoxCountryCode);
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
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Location = new System.Drawing.Point(333, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.Location = new System.Drawing.Point(190, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAdd.Location = new System.Drawing.Point(47, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.pnlGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxCountryCode;
        private AutoLabel autoLabelCountryName;
        private AutoLabel autoLabelCountryCode;
        private AutoLabel autoLabelCountDigits;
        private AutoLabel autoLabelExample;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.TextBox textBoxCountDigits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.UC_GridPhones uC_GridCountries;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}