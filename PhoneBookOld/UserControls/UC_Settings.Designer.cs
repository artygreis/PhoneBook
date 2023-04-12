
using Syncfusion.Windows.Forms.Tools;

namespace PhoneBook.UserControls
{
    partial class UC_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Settings));
            this.panelControl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnApplyUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.autoLabelOldPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.autoLabelNewPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.autoLabelSourceDb = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorValidating = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelControl.Controls.Add(this.groupBox2);
            this.panelControl.Controls.Add(this.groupBox1);
            this.panelControl.Controls.Add(this.btnSearchFile);
            this.panelControl.Controls.Add(this.textBoxSourceFile);
            this.panelControl.Controls.Add(this.panel2);
            this.panelControl.Controls.Add(this.panel3);
            this.panelControl.Controls.Add(this.panel4);
            this.panelControl.Controls.Add(this.panel5);
            this.panelControl.Controls.Add(this.autoLabelSourceDb);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(690, 444);
            this.panelControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.btnApplyUpdate);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(38, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 81);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обновления";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(41, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(275, 21);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Проверить наличие обновлений";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnApplyUpdate
            // 
            this.btnApplyUpdate.BackColor = System.Drawing.Color.White;
            this.btnApplyUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnApplyUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyUpdate.Image")));
            this.btnApplyUpdate.Location = new System.Drawing.Point(412, 31);
            this.btnApplyUpdate.Name = "btnApplyUpdate";
            this.btnApplyUpdate.Size = new System.Drawing.Size(137, 30);
            this.btnApplyUpdate.TabIndex = 12;
            this.btnApplyUpdate.Text = " Обновить !!!";
            this.btnApplyUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplyUpdate.UseVisualStyleBackColor = false;
            this.btnApplyUpdate.Click += new System.EventHandler(this.btnApplyUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOldPassword);
            this.groupBox1.Controls.Add(this.autoLabelOldPassword);
            this.groupBox1.Controls.Add(this.textBoxNewPassword);
            this.groupBox1.Controls.Add(this.btnSaveNewPassword);
            this.groupBox1.Controls.Add(this.autoLabelNewPassword);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 182);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение пароля";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxOldPassword.Location = new System.Drawing.Point(26, 55);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(290, 26);
            this.textBoxOldPassword.TabIndex = 0;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            // 
            // autoLabelOldPassword
            // 
            this.autoLabelOldPassword.DY = -29;
            this.autoLabelOldPassword.ForeColor = System.Drawing.Color.White;
            this.autoLabelOldPassword.Gap = 10;
            this.autoLabelOldPassword.LabeledControl = this.textBoxOldPassword;
            this.autoLabelOldPassword.Location = new System.Drawing.Point(26, 26);
            this.autoLabelOldPassword.Name = "autoLabelOldPassword";
            this.autoLabelOldPassword.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelOldPassword.Size = new System.Drawing.Size(140, 19);
            this.autoLabelOldPassword.TabIndex = 9;
            this.autoLabelOldPassword.Text = "Старый пароль:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxNewPassword.Location = new System.Drawing.Point(26, 124);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(290, 26);
            this.textBoxNewPassword.TabIndex = 2;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSaveNewPassword
            // 
            this.btnSaveNewPassword.BackColor = System.Drawing.Color.White;
            this.btnSaveNewPassword.FlatAppearance.BorderSize = 0;
            this.btnSaveNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSaveNewPassword.Image = global::PhoneBook.Properties.Resources.save;
            this.btnSaveNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNewPassword.Location = new System.Drawing.Point(370, 120);
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.Size = new System.Drawing.Size(188, 33);
            this.btnSaveNewPassword.TabIndex = 7;
            this.btnSaveNewPassword.Text = " Сохранить пароль";
            this.btnSaveNewPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveNewPassword.UseVisualStyleBackColor = false;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.btnSaveNewPassword_Click);
            // 
            // autoLabelNewPassword
            // 
            this.autoLabelNewPassword.DY = -29;
            this.autoLabelNewPassword.ForeColor = System.Drawing.Color.White;
            this.autoLabelNewPassword.Gap = 10;
            this.autoLabelNewPassword.LabeledControl = this.textBoxNewPassword;
            this.autoLabelNewPassword.Location = new System.Drawing.Point(26, 95);
            this.autoLabelNewPassword.Name = "autoLabelNewPassword";
            this.autoLabelNewPassword.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelNewPassword.Size = new System.Drawing.Size(128, 19);
            this.autoLabelNewPassword.TabIndex = 11;
            this.autoLabelNewPassword.Text = "Новый пароль:";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchFile.BackColor = System.Drawing.Color.White;
            this.btnSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearchFile.Image = global::PhoneBook.Properties.Resources.edit;
            this.btnSearchFile.Location = new System.Drawing.Point(527, 82);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(116, 30);
            this.btnSearchFile.TabIndex = 12;
            this.btnSearchFile.Text = "Изменить";
            this.btnSearchFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFile.UseVisualStyleBackColor = false;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSourceFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.textBoxSourceFile.Location = new System.Drawing.Point(38, 50);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.ReadOnly = true;
            this.textBoxSourceFile.Size = new System.Drawing.Size(605, 26);
            this.textBoxSourceFile.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 8);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 436);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(682, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 436);
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
            // autoLabelSourceDb
            // 
            this.autoLabelSourceDb.DY = -29;
            this.autoLabelSourceDb.ForeColor = System.Drawing.Color.White;
            this.autoLabelSourceDb.Gap = 10;
            this.autoLabelSourceDb.LabeledControl = this.textBoxSourceFile;
            this.autoLabelSourceDb.Location = new System.Drawing.Point(38, 21);
            this.autoLabelSourceDb.Name = "autoLabelSourceDb";
            this.autoLabelSourceDb.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabelSourceDb.Size = new System.Drawing.Size(174, 19);
            this.autoLabelSourceDb.TabIndex = 10;
            this.autoLabelSourceDb.Text = "Путь к справочнику:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 444);
            this.panel1.TabIndex = 0;
            // 
            // errorValidating
            // 
            this.errorValidating.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorValidating.ContainerControl = this;
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(690, 444);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private AutoLabel autoLabelOldPassword;
        private AutoLabel autoLabelSourceDb;
        private AutoLabel autoLabelNewPassword;
        private System.Windows.Forms.Button btnSaveNewPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorValidating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApplyUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
