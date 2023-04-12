
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    partial class AddNotCallNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNotCallNumber));
            this.autoLabelNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.maskedEditNumber = new Syncfusion.Windows.Forms.Tools.MaskedEditBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.autoLabelNotes = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabelNumber
            // 
            this.autoLabelNumber.DY = -24;
            this.autoLabelNumber.ForeColor = System.Drawing.Color.White;
            this.autoLabelNumber.Gap = 5;
            this.autoLabelNumber.LabeledControl = this.maskedEditNumber;
            this.autoLabelNumber.Location = new System.Drawing.Point(22, 48);
            this.autoLabelNumber.Name = "autoLabelNumber";
            this.autoLabelNumber.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelNumber.Size = new System.Drawing.Size(156, 19);
            this.autoLabelNumber.TabIndex = 0;
            this.autoLabelNumber.Text = "Номер телефона:";
            // 
            // maskedEditNumber
            // 
            this.maskedEditNumber.BeforeTouchSize = new System.Drawing.Size(341, 27);
            this.maskedEditNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskedEditNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.maskedEditNumber.Location = new System.Drawing.Point(22, 72);
            this.maskedEditNumber.Name = "maskedEditNumber";
            this.maskedEditNumber.PositionAt = Syncfusion.Windows.Forms.Tools.SpecialCursorPosition.FirstMaskPosition;
            this.maskedEditNumber.Size = new System.Drawing.Size(341, 27);
            this.maskedEditNumber.TabIndex = 0;
            this.maskedEditNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.rtxtNotes);
            this.panel1.Controls.Add(this.autoLabelNotes);
            this.panel1.Controls.Add(this.maskedEditNumber);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.autoLabelNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 299);
            this.panel1.TabIndex = 1;
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rtxtNotes.Location = new System.Drawing.Point(22, 141);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(341, 96);
            this.rtxtNotes.TabIndex = 1;
            this.rtxtNotes.Text = "";
            // 
            // autoLabelNotes
            // 
            this.autoLabelNotes.DY = -24;
            this.autoLabelNotes.ForeColor = System.Drawing.Color.White;
            this.autoLabelNotes.Gap = 5;
            this.autoLabelNotes.LabeledControl = this.rtxtNotes;
            this.autoLabelNotes.Location = new System.Drawing.Point(22, 117);
            this.autoLabelNotes.Name = "autoLabelNotes";
            this.autoLabelNotes.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelNotes.Size = new System.Drawing.Size(118, 19);
            this.autoLabelNotes.TabIndex = 8;
            this.autoLabelNotes.Text = "Примечание:";
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(234, 19);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Добавление информации: ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSave.Image = global::PhoneBook.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(246, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorValidating
            // 
            this.errorValidating.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValidating.ContainerControl = this;
            // 
            // AddNotCallNumber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionBarHeight = 6;
            this.ClientSize = new System.Drawing.Size(388, 299);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNotCallNumber";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOneApartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskedEditNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private AutoLabel autoLabelNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private MaskedEditBox maskedEditNumber;
        private ErrorProvider errorValidating;
        private AutoLabel autoLabelNotes;
        private RichTextBox rtxtNotes;
    }
}