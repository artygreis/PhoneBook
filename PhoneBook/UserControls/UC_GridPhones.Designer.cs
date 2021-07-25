using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace PhoneBook.UserControls
{
    partial class UC_GridPhones
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
            PhoneBook.Types.NumberPhoneView numberPhoneView1 = new PhoneBook.Types.NumberPhoneView();
            PhoneBook.Types.NumberPhoneView numberPhoneView2 = new PhoneBook.Types.NumberPhoneView();
            this.numberPhoneViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.numberPhoneViewGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numberPhoneViewBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPhoneViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // numberPhoneViewBindingSource
            // 
            numberPhoneView1.AddressId = 0;
            numberPhoneView1.Apartment = "8";
            numberPhoneView1.CityId = 0;
            numberPhoneView1.House = "10";
            numberPhoneView1.Locality = null;
            numberPhoneView1.Number = null;
            numberPhoneView1.StreetName = null;
            numberPhoneView1.TypeName = null;
            numberPhoneView2.AddressId = 0;
            numberPhoneView2.Apartment = null;
            numberPhoneView2.CityId = 0;
            numberPhoneView2.House = null;
            numberPhoneView2.Locality = null;
            numberPhoneView2.Number = null;
            numberPhoneView2.StreetName = null;
            numberPhoneView2.TypeName = null;
            this.numberPhoneViewBindingSource.DataSource = new PhoneBook.Types.NumberPhoneView[] {
        numberPhoneView1,
        numberPhoneView2};
            this.numberPhoneViewBindingSource.Position = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.numberPhoneViewGrid);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(8, 8);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(674, 472);
            this.mainPanel.TabIndex = 0;
            // 
            // numberPhoneViewGrid
            // 
            this.numberPhoneViewGrid.AccessibleName = "Table";
            this.numberPhoneViewGrid.AllowEditing = false;
            this.numberPhoneViewGrid.AllowResizingColumns = true;
            this.numberPhoneViewGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            this.numberPhoneViewGrid.BackColor = System.Drawing.Color.Silver;
            this.numberPhoneViewGrid.DataSource = this.numberPhoneViewBindingSource;
            this.numberPhoneViewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberPhoneViewGrid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberPhoneViewGrid.HeaderRowHeight = 28;
            this.numberPhoneViewGrid.Location = new System.Drawing.Point(0, 0);
            this.numberPhoneViewGrid.Name = "numberPhoneViewGrid";
            this.numberPhoneViewGrid.RowHeight = 25;
            this.numberPhoneViewGrid.Size = new System.Drawing.Size(674, 472);
            this.numberPhoneViewGrid.Style.BorderColor = System.Drawing.Color.Gray;
            this.numberPhoneViewGrid.Style.CaptionSummaryRowStyle.BackColor = System.Drawing.Color.White;
            this.numberPhoneViewGrid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberPhoneViewGrid.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Window;
            this.numberPhoneViewGrid.Style.HeaderStyle.Font.Bold = true;
            this.numberPhoneViewGrid.Style.HeaderStyle.Font.Size = 10F;
            this.numberPhoneViewGrid.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.numberPhoneViewGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(682, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 488);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 8);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 488);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 8);
            this.panel4.TabIndex = 2;
            // 
            // UC_GridPhones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_GridPhones";
            this.Size = new System.Drawing.Size(690, 488);
            ((System.ComponentModel.ISupportInitialize)(this.numberPhoneViewBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberPhoneViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.BindingSource numberPhoneViewBindingSource;
        private SfDataGrid numberPhoneViewGrid;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
