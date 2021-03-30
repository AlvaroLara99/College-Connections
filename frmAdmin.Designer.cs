namespace LaraAlvaroProjectA
{
    partial class frmAdmin
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
            this.lblID = new System.Windows.Forms.Label();
            this.mnuItmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStory = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblGraduated = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuAdmin = new System.Windows.Forms.MenuStrip();
            this.mnuItmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChatLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItmView = new System.Windows.Forms.ToolStripMenuItem();
            this.hlpAdmin = new System.Windows.Forms.HelpProvider();
            this.lblIDText = new System.Windows.Forms.Label();
            this.lblFirstNameText = new System.Windows.Forms.Label();
            this.lblLastNameText = new System.Windows.Forms.Label();
            this.lblAgeText = new System.Windows.Forms.Label();
            this.lblStateText = new System.Windows.Forms.Label();
            this.lblCityText = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblZipText = new System.Windows.Forms.Label();
            this.lblGradText = new System.Windows.Forms.Label();
            this.lblWorkText = new System.Windows.Forms.Label();
            this.lblSalaryText = new System.Windows.Forms.Label();
            this.lblStoryText = new System.Windows.Forms.Label();
            this.lblEducationText = new System.Windows.Forms.Label();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.mnuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(253, 133);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 26);
            this.lblID.TabIndex = 58;
            this.lblID.Text = "ID:";
            // 
            // mnuItmLogOut
            // 
            this.mnuItmLogOut.Name = "mnuItmLogOut";
            this.mnuItmLogOut.Size = new System.Drawing.Size(62, 20);
            this.mnuItmLogOut.Text = "&Log Out";
            this.mnuItmLogOut.Click += new System.EventHandler(this.mnuAdminClose_Click);
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStory.Location = new System.Drawing.Point(107, 352);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(158, 26);
            this.lblStory.TabIndex = 55;
            this.lblStory.Text = "Success Story:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(576, 279);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(80, 26);
            this.lblSalary.TabIndex = 53;
            this.lblSalary.Text = "Salary:";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducation.Location = new System.Drawing.Point(565, 352);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(185, 26);
            this.lblEducation.TabIndex = 51;
            this.lblEducation.Text = "Higher Education:";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWork.Location = new System.Drawing.Point(421, 279);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(69, 26);
            this.lblWork.TabIndex = 49;
            this.lblWork.Text = "Work:";
            // 
            // lblGraduated
            // 
            this.lblGraduated.AutoSize = true;
            this.lblGraduated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraduated.Location = new System.Drawing.Point(266, 279);
            this.lblGraduated.Name = "lblGraduated";
            this.lblGraduated.Size = new System.Drawing.Size(120, 26);
            this.lblGraduated.TabIndex = 47;
            this.lblGraduated.Text = "Graduated:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(111, 279);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(48, 26);
            this.lblZip.TabIndex = 45;
            this.lblZip.Text = "Zip:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(786, 214);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 26);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(533, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 26);
            this.lblCity.TabIndex = 41;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(253, 214);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(69, 26);
            this.lblState.TabIndex = 39;
            this.lblState.Text = "State:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(992, 133);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(57, 26);
            this.lblAge.TabIndex = 37;
            this.lblAge.Text = "Age:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(678, 132);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 26);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(364, 133);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(125, 26);
            this.lblFirst.TabIndex = 33;
            this.lblFirst.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(-1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1239, 100);
            this.label2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 620);
            this.label1.TabIndex = 30;
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmLogOut,
            this.mnuItmHelp,
            this.mnuItmEdit,
            this.mnuItmChat,
            this.mnuItmReports,
            this.mnuItmView});
            this.mnuAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(1234, 24);
            this.mnuAdmin.TabIndex = 0;
            this.mnuAdmin.Text = "menuStrip1";
            // 
            // mnuItmHelp
            // 
            this.mnuItmHelp.Name = "mnuItmHelp";
            this.mnuItmHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuItmHelp.Text = "&Help";
            this.mnuItmHelp.Click += new System.EventHandler(this.mnuItmHelp_Click);
            // 
            // mnuItmEdit
            // 
            this.mnuItmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmEditStudent,
            this.mnuItmAdd});
            this.mnuItmEdit.Name = "mnuItmEdit";
            this.mnuItmEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuItmEdit.Text = "&Edit";
            // 
            // mnuItmEditStudent
            // 
            this.mnuItmEditStudent.Name = "mnuItmEditStudent";
            this.mnuItmEditStudent.Size = new System.Drawing.Size(180, 22);
            this.mnuItmEditStudent.Text = "&Student";
            this.mnuItmEditStudent.Click += new System.EventHandler(this.mnuItmEditStudent_Click);
            // 
            // mnuItmAdd
            // 
            this.mnuItmAdd.Name = "mnuItmAdd";
            this.mnuItmAdd.Size = new System.Drawing.Size(180, 22);
            this.mnuItmAdd.Text = "&Add Account";
            this.mnuItmAdd.Click += new System.EventHandler(this.mnuItmAdd_Click);
            // 
            // mnuItmChat
            // 
            this.mnuItmChat.Name = "mnuItmChat";
            this.mnuItmChat.Size = new System.Drawing.Size(44, 20);
            this.mnuItmChat.Text = "&Chat";
            this.mnuItmChat.Click += new System.EventHandler(this.mnuItmChat_Click);
            // 
            // mnuItmReports
            // 
            this.mnuItmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItmChatLog,
            this.mnuItmChangeLog});
            this.mnuItmReports.Name = "mnuItmReports";
            this.mnuItmReports.Size = new System.Drawing.Size(59, 20);
            this.mnuItmReports.Text = "&Reports";
            // 
            // mnuItmChatLog
            // 
            this.mnuItmChatLog.Name = "mnuItmChatLog";
            this.mnuItmChatLog.Size = new System.Drawing.Size(180, 22);
            this.mnuItmChatLog.Text = "Cha&t Log";
            this.mnuItmChatLog.Click += new System.EventHandler(this.mnuItmChatLog_Click);
            // 
            // mnuItmChangeLog
            // 
            this.mnuItmChangeLog.Name = "mnuItmChangeLog";
            this.mnuItmChangeLog.Size = new System.Drawing.Size(180, 22);
            this.mnuItmChangeLog.Text = "C&hange Log";
            this.mnuItmChangeLog.Click += new System.EventHandler(this.mnuItmChangeLog_Click);
            // 
            // mnuItmView
            // 
            this.mnuItmView.Name = "mnuItmView";
            this.mnuItmView.Size = new System.Drawing.Size(86, 20);
            this.mnuItmView.Text = "&View Profiles";
            this.mnuItmView.Click += new System.EventHandler(this.mnuItmView_Click);
            // 
            // lblIDText
            // 
            this.lblIDText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDText.Location = new System.Drawing.Point(258, 163);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(100, 31);
            this.lblIDText.TabIndex = 60;
            // 
            // lblFirstNameText
            // 
            this.lblFirstNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameText.Location = new System.Drawing.Point(369, 163);
            this.lblFirstNameText.Name = "lblFirstNameText";
            this.lblFirstNameText.Size = new System.Drawing.Size(308, 31);
            this.lblFirstNameText.TabIndex = 61;
            // 
            // lblLastNameText
            // 
            this.lblLastNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameText.Location = new System.Drawing.Point(683, 163);
            this.lblLastNameText.Name = "lblLastNameText";
            this.lblLastNameText.Size = new System.Drawing.Size(308, 31);
            this.lblLastNameText.TabIndex = 62;
            // 
            // lblAgeText
            // 
            this.lblAgeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeText.Location = new System.Drawing.Point(997, 163);
            this.lblAgeText.Name = "lblAgeText";
            this.lblAgeText.Size = new System.Drawing.Size(100, 31);
            this.lblAgeText.TabIndex = 63;
            // 
            // lblStateText
            // 
            this.lblStateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateText.Location = new System.Drawing.Point(258, 244);
            this.lblStateText.Name = "lblStateText";
            this.lblStateText.Size = new System.Drawing.Size(274, 31);
            this.lblStateText.TabIndex = 64;
            // 
            // lblCityText
            // 
            this.lblCityText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityText.Location = new System.Drawing.Point(538, 244);
            this.lblCityText.Name = "lblCityText";
            this.lblCityText.Size = new System.Drawing.Size(247, 31);
            this.lblCityText.TabIndex = 65;
            // 
            // lblAddressText
            // 
            this.lblAddressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressText.Location = new System.Drawing.Point(791, 244);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(411, 31);
            this.lblAddressText.TabIndex = 66;
            // 
            // lblZipText
            // 
            this.lblZipText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipText.Location = new System.Drawing.Point(116, 309);
            this.lblZipText.Name = "lblZipText";
            this.lblZipText.Size = new System.Drawing.Size(149, 31);
            this.lblZipText.TabIndex = 67;
            // 
            // lblGradText
            // 
            this.lblGradText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGradText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradText.Location = new System.Drawing.Point(271, 309);
            this.lblGradText.Name = "lblGradText";
            this.lblGradText.Size = new System.Drawing.Size(149, 31);
            this.lblGradText.TabIndex = 68;
            // 
            // lblWorkText
            // 
            this.lblWorkText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkText.Location = new System.Drawing.Point(426, 309);
            this.lblWorkText.Name = "lblWorkText";
            this.lblWorkText.Size = new System.Drawing.Size(149, 31);
            this.lblWorkText.TabIndex = 69;
            // 
            // lblSalaryText
            // 
            this.lblSalaryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryText.Location = new System.Drawing.Point(581, 309);
            this.lblSalaryText.Name = "lblSalaryText";
            this.lblSalaryText.Size = new System.Drawing.Size(149, 31);
            this.lblSalaryText.TabIndex = 70;
            // 
            // lblStoryText
            // 
            this.lblStoryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryText.Location = new System.Drawing.Point(112, 383);
            this.lblStoryText.Name = "lblStoryText";
            this.lblStoryText.Size = new System.Drawing.Size(373, 249);
            this.lblStoryText.TabIndex = 71;
            // 
            // lblEducationText
            // 
            this.lblEducationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEducationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationText.Location = new System.Drawing.Point(570, 383);
            this.lblEducationText.Name = "lblEducationText";
            this.lblEducationText.Size = new System.Drawing.Size(551, 249);
            this.lblEducationText.TabIndex = 72;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(249, 253);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 32;
            this.pbxPhoto.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(212)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1234, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStory);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.lblGraduated);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuAdmin);
            this.Controls.Add(this.lblEducationText);
            this.Controls.Add(this.lblStoryText);
            this.Controls.Add(this.lblSalaryText);
            this.Controls.Add(this.lblWorkText);
            this.Controls.Add(this.lblGradText);
            this.Controls.Add(this.lblZipText);
            this.Controls.Add(this.lblAddressText);
            this.Controls.Add(this.lblCityText);
            this.Controls.Add(this.lblStateText);
            this.Controls.Add(this.lblAgeText);
            this.Controls.Add(this.lblLastNameText);
            this.Controls.Add(this.lblFirstNameText);
            this.Controls.Add(this.lblIDText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpAdmin.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.hlpAdmin.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.mnuAdmin.ResumeLayout(false);
            this.mnuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ToolStripMenuItem mnuItmLogOut;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblGraduated;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItmEditStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuItmHelp;
        private System.Windows.Forms.HelpProvider hlpAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChat;
        private System.Windows.Forms.ToolStripMenuItem mnuItmReports;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChatLog;
        private System.Windows.Forms.ToolStripMenuItem mnuItmChangeLog;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.Label lblFirstNameText;
        private System.Windows.Forms.Label lblLastNameText;
        private System.Windows.Forms.Label lblAgeText;
        private System.Windows.Forms.Label lblStateText;
        private System.Windows.Forms.Label lblCityText;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblZipText;
        private System.Windows.Forms.Label lblGradText;
        private System.Windows.Forms.Label lblWorkText;
        private System.Windows.Forms.Label lblSalaryText;
        private System.Windows.Forms.Label lblStoryText;
        private System.Windows.Forms.Label lblEducationText;
        private System.Windows.Forms.ToolStripMenuItem mnuItmAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuItmView;
    }
}