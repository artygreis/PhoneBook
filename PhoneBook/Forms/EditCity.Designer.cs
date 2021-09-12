
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.Forms
{
    partial class EditCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCity));
            this.maskedEditBoxFormatNumber = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.maskedEditCityCode = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.autoLabelCityName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.autoLabelCityCode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelFormatNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.uC_GridCities = new PhoneBook.UserControls.UC_GridPhones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBoxFormatNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditCityCode)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedEditBoxFormatNumber
            // 
            this.maskedEditBoxFormatNumber.BeforeTouchSize = new System.Drawing.Size(184, 27);
            this.maskedEditBoxFormatNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditBoxFormatNumber.Location = new System.Drawing.Point(232, 128);
            this.maskedEditBoxFormatNumber.Name = "maskedEditBoxFormatNumber";
            this.maskedEditBoxFormatNumber.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditBoxFormatNumber.Size = new System.Drawing.Size(184, 27);
            this.maskedEditBoxFormatNumber.TabIndex = 2;
            this.maskedEditBoxFormatNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedEditBoxFormatNumber.Validated += new System.EventHandler(this.maskedEditBoxFormatNumber_Validated);
            // 
            // maskedEditCityCode
            // 
            this.maskedEditCityCode.BeforeTouchSize = new System.Drawing.Size(184, 27);
            this.maskedEditCityCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditCityCode.Location = new System.Drawing.Point(232, 96);
            this.maskedEditCityCode.Name = "maskedEditCityCode";
            this.maskedEditCityCode.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditCityCode.Size = new System.Drawing.Size(184, 27);
            this.maskedEditCityCode.TabIndex = 1;
            this.maskedEditCityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelCityName
            // 
            this.autoLabelCityName.DX = -148;
            this.autoLabelCityName.DY = 3;
            this.autoLabelCityName.ForeColor = System.Drawing.Color.White;
            this.autoLabelCityName.Gap = 10;
            this.autoLabelCityName.LabeledControl = this.textBoxCityName;
            this.autoLabelCityName.Location = new System.Drawing.Point(84, 69);
            this.autoLabelCityName.Name = "autoLabelCityName";
            this.autoLabelCityName.Size = new System.Drawing.Size(138, 19);
            this.autoLabelCityName.TabIndex = 0;
            this.autoLabelCityName.Text = "Наименование:";
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxCityName.Location = new System.Drawing.Point(232, 66);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(184, 26);
            this.textBoxCityName.TabIndex = 0;
            this.textBoxCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelCityCode
            // 
            this.autoLabelCityCode.DX = -115;
            this.autoLabelCityCode.DY = 4;
            this.autoLabelCityCode.ForeColor = System.Drawing.Color.White;
            this.autoLabelCityCode.Gap = 10;
            this.autoLabelCityCode.LabeledControl = this.maskedEditCityCode;
            this.autoLabelCityCode.Location = new System.Drawing.Point(117, 100);
            this.autoLabelCityCode.Name = "autoLabelCityCode";
            this.autoLabelCityCode.Size = new System.Drawing.Size(105, 19);
            this.autoLabelCityCode.TabIndex = 0;
            this.autoLabelCityCode.Text = "Код города:";
            // 
            // autoLabelFormatNumber
            // 
            this.autoLabelFormatNumber.DX = -157;
            this.autoLabelFormatNumber.DY = 4;
            this.autoLabelFormatNumber.ForeColor = System.Drawing.Color.White;
            this.autoLabelFormatNumber.Gap = 10;
            this.autoLabelFormatNumber.LabeledControl = this.maskedEditBoxFormatNumber;
            this.autoLabelFormatNumber.Location = new System.Drawing.Point(75, 132);
            this.autoLabelFormatNumber.Name = "autoLabelFormatNumber";
            this.autoLabelFormatNumber.Size = new System.Drawing.Size(147, 19);
            this.autoLabelFormatNumber.TabIndex = 0;
            this.autoLabelFormatNumber.Text = "Формат номера:";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlGrid.Controls.Add(this.uC_GridCities);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(0, 214);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(502, 241);
            this.pnlGrid.TabIndex = 0;
            // 
            // uC_GridCities
            // 
            this.uC_GridCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_GridCities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridCities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridCities.Location = new System.Drawing.Point(0, 0);
            this.uC_GridCities.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridCities.Name = "uC_GridCities";
            this.uC_GridCities.Size = new System.Drawing.Size(502, 241);
            this.uC_GridCities.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.maskedEditBoxFormatNumber);
            this.panel1.Controls.Add(this.maskedEditCityCode);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.labelCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.textBoxCityName);
            this.panel1.Controls.Add(this.autoLabelCityName);
            this.panel1.Controls.Add(this.autoLabelCityCode);
            this.panel1.Controls.Add(this.autoLabelFormatNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 214);
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
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(182, 36);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(139, 19);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Беларусь (+375)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактирование списка городов для";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Image = global::PhoneBook.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(331, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 5;
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
            this.btnEdit.Location = new System.Drawing.Point(183, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 32);
            this.btnEdit.TabIndex = 4;
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
            this.btnAdd.Location = new System.Drawing.Point(35, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 3;
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
            // EditCity
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
            this.Name = "EditCity";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditBoxFormatNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditCityCode)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCityName;
        private AutoLabel autoLabelCityName;
        private AutoLabel autoLabelCityCode;
        private AutoLabel autoLabelFormatNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private UserControls.UC_GridPhones uC_GridCities;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private MaskedEditBox maskedEditBoxFormatNumber;
        private MaskedEditBox maskedEditCityCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ErrorProvider errorValidating;
    }
}