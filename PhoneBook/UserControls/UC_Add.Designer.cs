
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.UserControls
{
    partial class UC_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Add));
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.btnEditHouse = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnEditCountry = new System.Windows.Forms.Button();
            this.btnAddRange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.autoLabelCountry = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelCity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabelHouse = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_GridPhones1 = new PhoneBook.UserControls.UC_GridPhones();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelControl.Controls.Add(this.btnEditCity);
            this.panelControl.Controls.Add(this.btnEditHouse);
            this.panelControl.Controls.Add(this.btnEditAddress);
            this.panelControl.Controls.Add(this.btnEditCountry);
            this.panelControl.Controls.Add(this.btnAddRange);
            this.panelControl.Controls.Add(this.button1);
            this.panelControl.Controls.Add(this.btnAddSingle);
            this.panelControl.Controls.Add(this.textBoxHouse);
            this.panelControl.Controls.Add(this.textBoxAddress);
            this.panelControl.Controls.Add(this.textBoxCity);
            this.panelControl.Controls.Add(this.textBoxCountry);
            this.panelControl.Controls.Add(this.panel3);
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Controls.Add(this.panel5);
            this.panelControl.Controls.Add(this.autoLabelCountry);
            this.panelControl.Controls.Add(this.autoLabelCity);
            this.panelControl.Controls.Add(this.autoLabelAddress);
            this.panelControl.Controls.Add(this.autoLabelHouse);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(690, 162);
            this.panelControl.TabIndex = 0;
            // 
            // btnEditCity
            // 
            this.btnEditCity.BackColor = System.Drawing.Color.White;
            this.btnEditCity.FlatAppearance.BorderSize = 0;
            this.btnEditCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCity.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCity.Image")));
            this.btnEditCity.Location = new System.Drawing.Point(590, 20);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(40, 35);
            this.btnEditCity.TabIndex = 13;
            this.btnEditCity.UseVisualStyleBackColor = false;
            // 
            // btnEditHouse
            // 
            this.btnEditHouse.BackColor = System.Drawing.Color.White;
            this.btnEditHouse.FlatAppearance.BorderSize = 0;
            this.btnEditHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnEditHouse.Image")));
            this.btnEditHouse.Location = new System.Drawing.Point(590, 66);
            this.btnEditHouse.Name = "btnEditHouse";
            this.btnEditHouse.Size = new System.Drawing.Size(40, 35);
            this.btnEditHouse.TabIndex = 13;
            this.btnEditHouse.UseVisualStyleBackColor = false;
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.BackColor = System.Drawing.Color.White;
            this.btnEditAddress.FlatAppearance.BorderSize = 0;
            this.btnEditAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAddress.Image")));
            this.btnEditAddress.Location = new System.Drawing.Point(420, 66);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(40, 35);
            this.btnEditAddress.TabIndex = 13;
            this.btnEditAddress.UseVisualStyleBackColor = false;
            // 
            // btnEditCountry
            // 
            this.btnEditCountry.BackColor = System.Drawing.Color.White;
            this.btnEditCountry.FlatAppearance.BorderSize = 0;
            this.btnEditCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCountry.Image")));
            this.btnEditCountry.Location = new System.Drawing.Point(280, 20);
            this.btnEditCountry.Name = "btnEditCountry";
            this.btnEditCountry.Size = new System.Drawing.Size(40, 35);
            this.btnEditCountry.TabIndex = 13;
            this.btnEditCountry.UseVisualStyleBackColor = false;
            // 
            // btnAddRange
            // 
            this.btnAddRange.BackColor = System.Drawing.Color.White;
            this.btnAddRange.FlatAppearance.BorderSize = 0;
            this.btnAddRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRange.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRange.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRange.Image")));
            this.btnAddRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRange.Location = new System.Drawing.Point(244, 114);
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.Size = new System.Drawing.Size(247, 33);
            this.btnAddRange.TabIndex = 8;
            this.btnAddRange.Text = " Добавить список квартир";
            this.btnAddRange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRange.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(497, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = " Редактировать";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.BackColor = System.Drawing.Color.White;
            this.btnAddSingle.FlatAppearance.BorderSize = 0;
            this.btnAddSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSingle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSingle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSingle.Image")));
            this.btnAddSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSingle.Location = new System.Drawing.Point(30, 114);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(208, 33);
            this.btnAddSingle.TabIndex = 7;
            this.btnAddSingle.Text = " Добавить 1 квартиру";
            this.btnAddSingle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSingle.UseVisualStyleBackColor = false;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxHouse.Location = new System.Drawing.Point(534, 70);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(50, 26);
            this.textBoxHouse.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(104, 70);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(310, 26);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCity.Location = new System.Drawing.Point(414, 25);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(170, 26);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.Location = new System.Drawing.Point(104, 25);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(170, 26);
            this.textBoxCountry.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 154);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(682, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 154);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(690, 8);
            this.panel5.TabIndex = 2;
            // 
            // autoLabelCountry
            // 
            this.autoLabelCountry.DX = -86;
            this.autoLabelCountry.DY = 4;
            this.autoLabelCountry.ForeColor = System.Drawing.Color.White;
            this.autoLabelCountry.Gap = 10;
            this.autoLabelCountry.LabeledControl = this.textBoxCountry;
            this.autoLabelCountry.Location = new System.Drawing.Point(18, 29);
            this.autoLabelCountry.Name = "autoLabelCountry";
            this.autoLabelCountry.Size = new System.Drawing.Size(76, 19);
            this.autoLabelCountry.TabIndex = 9;
            this.autoLabelCountry.Text = "Страна:";
            // 
            // autoLabelCity
            // 
            this.autoLabelCity.DX = -71;
            this.autoLabelCity.DY = 4;
            this.autoLabelCity.ForeColor = System.Drawing.Color.White;
            this.autoLabelCity.Gap = 10;
            this.autoLabelCity.LabeledControl = this.textBoxCity;
            this.autoLabelCity.Location = new System.Drawing.Point(343, 29);
            this.autoLabelCity.Name = "autoLabelCity";
            this.autoLabelCity.Size = new System.Drawing.Size(61, 19);
            this.autoLabelCity.TabIndex = 10;
            this.autoLabelCity.Text = "Город:";
            // 
            // autoLabelAddress
            // 
            this.autoLabelAddress.DX = -86;
            this.autoLabelAddress.DY = 4;
            this.autoLabelAddress.ForeColor = System.Drawing.Color.White;
            this.autoLabelAddress.Gap = 20;
            this.autoLabelAddress.LabeledControl = this.textBoxAddress;
            this.autoLabelAddress.Location = new System.Drawing.Point(18, 74);
            this.autoLabelAddress.Name = "autoLabelAddress";
            this.autoLabelAddress.Size = new System.Drawing.Size(66, 19);
            this.autoLabelAddress.TabIndex = 11;
            this.autoLabelAddress.Text = "Адрес:";
            // 
            // autoLabelHouse
            // 
            this.autoLabelHouse.DX = -35;
            this.autoLabelHouse.DY = 4;
            this.autoLabelHouse.ForeColor = System.Drawing.Color.White;
            this.autoLabelHouse.Gap = 10;
            this.autoLabelHouse.LabeledControl = this.textBoxHouse;
            this.autoLabelHouse.Location = new System.Drawing.Point(499, 74);
            this.autoLabelHouse.Name = "autoLabelHouse";
            this.autoLabelHouse.Size = new System.Drawing.Size(25, 19);
            this.autoLabelHouse.TabIndex = 12;
            this.autoLabelHouse.Text = "Д.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_GridPhones1);
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 444);
            this.panel1.TabIndex = 0;
            // 
            // uC_GridPhones1
            // 
            this.uC_GridPhones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_GridPhones1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_GridPhones1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.uC_GridPhones1.Location = new System.Drawing.Point(0, 162);
            this.uC_GridPhones1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_GridPhones1.Name = "uC_GridPhones1";
            this.uC_GridPhones1.Size = new System.Drawing.Size(690, 282);
            this.uC_GridPhones1.TabIndex = 1;
            // 
            // UC_Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Add";
            this.Size = new System.Drawing.Size(690, 444);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel3;
        private UC_GridPhones uC_GridPhones1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button btnAddRange;
        private System.Windows.Forms.Button btnAddSingle;
        private AutoLabel autoLabelCountry;
        private AutoLabel autoLabelCity;
        private AutoLabel autoLabelAddress;
        private AutoLabel autoLabelHouse;
        private System.Windows.Forms.Button btnEditCountry;
        private System.Windows.Forms.Button btnEditCity;
        private System.Windows.Forms.Button btnEditHouse;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button button1;
    }
}
