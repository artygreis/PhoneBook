
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    partial class AddSingleNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSingleNumber));
            this.autoLabelApartment = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxApartment = new System.Windows.Forms.TextBox();
            this.autoLabelNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.maskedEditNumber = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoLabelApartment
            // 
            this.autoLabelApartment.DY = -24;
            this.autoLabelApartment.ForeColor = System.Drawing.Color.White;
            this.autoLabelApartment.Gap = 5;
            this.autoLabelApartment.LabeledControl = this.textBoxApartment;
            this.autoLabelApartment.Location = new System.Drawing.Point(101, 78);
            this.autoLabelApartment.Name = "autoLabelApartment";
            this.autoLabelApartment.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelApartment.Size = new System.Drawing.Size(120, 19);
            this.autoLabelApartment.TabIndex = 0;
            this.autoLabelApartment.Text = "Квартира, №:";
            // 
            // textBoxApartment
            // 
            this.textBoxApartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxApartment.Location = new System.Drawing.Point(101, 102);
            this.textBoxApartment.Name = "textBoxApartment";
            this.textBoxApartment.Size = new System.Drawing.Size(184, 27);
            this.textBoxApartment.TabIndex = 0;
            this.textBoxApartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoLabelNumber
            // 
            this.autoLabelNumber.DY = -24;
            this.autoLabelNumber.ForeColor = System.Drawing.Color.White;
            this.autoLabelNumber.Gap = 5;
            this.autoLabelNumber.LabeledControl = this.maskedEditNumber;
            this.autoLabelNumber.Location = new System.Drawing.Point(101, 139);
            this.autoLabelNumber.Name = "autoLabelNumber";
            this.autoLabelNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelNumber.Size = new System.Drawing.Size(156, 19);
            this.autoLabelNumber.TabIndex = 0;
            this.autoLabelNumber.Text = "Номер телефона:";
            // 
            // maskedEditNumber
            // 
            this.maskedEditNumber.BeforeTouchSize = new System.Drawing.Size(184, 27);
            this.maskedEditNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditNumber.Location = new System.Drawing.Point(101, 163);
            this.maskedEditNumber.Name = "maskedEditNumber";
            this.maskedEditNumber.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditNumber.Size = new System.Drawing.Size(184, 27);
            this.maskedEditNumber.TabIndex = 1;
            this.maskedEditNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxApartment);
            this.panel1.Controls.Add(this.maskedEditNumber);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.autoLabelApartment);
            this.panel1.Controls.Add(this.autoLabelNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 249);
            this.panel1.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(31, 39);
            this.labelAddress.MaximumSize = new System.Drawing.Size(350, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(273, 19);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Добавление данных по адресу: ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(351, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.MaximumSize = new System.Drawing.Size(350, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(273, 19);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Добавление данных по адресу: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAdd.Image = global::PhoneBook.Properties.Resources.save;
            this.btnAdd.Location = new System.Drawing.Point(246, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Сохранить";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSingleNumber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBarHeight = 6;
            this.ClientSize = new System.Drawing.Size(388, 249);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSingleNumber";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOneApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private AutoLabel autoLabelApartment;
        private AutoLabel autoLabelNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
        private MaskedEditBox maskedEditNumber;
        private TextBox textBoxApartment;
        private Label labelAddress;
    }
}