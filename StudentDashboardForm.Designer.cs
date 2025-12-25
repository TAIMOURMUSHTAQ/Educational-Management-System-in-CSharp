namespace EducationalManagementSystem
{
    partial class StudentDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.panelProfileContent = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblAdmissionDateLabel = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblDOBLabel = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblClassLabel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFatherNameLabel = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblStudentNameLabel = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.panelAttendanceContent = new System.Windows.Forms.Panel();
            this.panelAttendanceStats = new System.Windows.Forms.Panel();
            this.lblTotalAbsentLabel = new System.Windows.Forms.Label();
            this.lblTotalAbsent = new System.Windows.Forms.Label();
            this.lblTotalPresentLabel = new System.Windows.Forms.Label();
            this.lblTotalPresent = new System.Windows.Forms.Label();
            this.lblAttendancePercentage = new System.Windows.Forms.Label();
            this.lblAttendanceLabel = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.panelTimetableContent = new System.Windows.Forms.Panel();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.panelMarksContent = new System.Windows.Forms.Panel();
            this.lblMarksNote = new System.Windows.Forms.Label();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.panelProfileContent.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            this.panelAttendanceContent.SuspendLayout();
            this.panelAttendanceStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.tabTimetable.SuspendLayout();
            this.panelTimetableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.tabMarks.SuspendLayout();
            this.panelMarksContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👨‍🎓 Student Portal";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(450, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Student!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(880, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabAttendance);
            this.tabControl.Controls.Add(this.tabTimetable);
            this.tabControl.Controls.Add(this.tabMarks);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 70);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 530);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabProfile.Controls.Add(this.panelProfileContent);
            this.tabProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(992, 500);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "📋 My Profile";
            // 
            // panelProfileContent
            // 
            this.panelProfileContent.AutoScroll = true;
            this.panelProfileContent.Controls.Add(this.groupBoxInfo);
            this.panelProfileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfileContent.Location = new System.Drawing.Point(3, 3);
            this.panelProfileContent.Name = "panelProfileContent";
            this.panelProfileContent.Size = new System.Drawing.Size(986, 494);
            this.panelProfileContent.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.lblAdmissionDateLabel);
            this.groupBoxInfo.Controls.Add(this.lblAdmissionDate);
            this.groupBoxInfo.Controls.Add(this.lblDOBLabel);
            this.groupBoxInfo.Controls.Add(this.lblDOB);
            this.groupBoxInfo.Controls.Add(this.lblGenderLabel);
            this.groupBoxInfo.Controls.Add(this.lblGender);
            this.groupBoxInfo.Controls.Add(this.lblClassLabel);
            this.groupBoxInfo.Controls.Add(this.lblClass);
            this.groupBoxInfo.Controls.Add(this.lblAddressLabel);
            this.groupBoxInfo.Controls.Add(this.lblAddress);
            this.groupBoxInfo.Controls.Add(this.lblPhoneLabel);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Controls.Add(this.lblEmailLabel);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblFatherNameLabel);
            this.groupBoxInfo.Controls.Add(this.lblFatherName);
            this.groupBoxInfo.Controls.Add(this.lblStudentNameLabel);
            this.groupBoxInfo.Controls.Add(this.lblStudentName);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 20);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(600, 350);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Personal Information";
            // 
            // lblStudentNameLabel
            // 
            this.lblStudentNameLabel.AutoSize = true;
            this.lblStudentNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentNameLabel.Location = new System.Drawing.Point(20, 45);
            this.lblStudentNameLabel.Name = "lblStudentNameLabel";
            this.lblStudentNameLabel.Size = new System.Drawing.Size(49, 19);
            this.lblStudentNameLabel.TabIndex = 0;
            this.lblStudentNameLabel.Text = "Name:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(180, 45);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(400, 19);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "-";
            // 
            // lblFatherNameLabel
            // 
            this.lblFatherNameLabel.AutoSize = true;
            this.lblFatherNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFatherNameLabel.Location = new System.Drawing.Point(20, 80);
            this.lblFatherNameLabel.Name = "lblFatherNameLabel";
            this.lblFatherNameLabel.Size = new System.Drawing.Size(96, 19);
            this.lblFatherNameLabel.TabIndex = 2;
            this.lblFatherNameLabel.Text = "Father\'s Name:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFatherName.Location = new System.Drawing.Point(180, 80);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(400, 19);
            this.lblFatherName.TabIndex = 3;
            this.lblFatherName.Text = "-";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailLabel.Location = new System.Drawing.Point(20, 115);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(45, 19);
            this.lblEmailLabel.TabIndex = 4;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(180, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(400, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "-";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhoneLabel.Location = new System.Drawing.Point(20, 150);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(50, 19);
            this.lblPhoneLabel.TabIndex = 6;
            this.lblPhoneLabel.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(180, 150);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(400, 19);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "-";
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddressLabel.Location = new System.Drawing.Point(20, 185);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(60, 19);
            this.lblAddressLabel.TabIndex = 8;
            this.lblAddressLabel.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(180, 185);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(400, 19);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "-";
            // 
            // lblClassLabel
            // 
            this.lblClassLabel.AutoSize = true;
            this.lblClassLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClassLabel.Location = new System.Drawing.Point(20, 220);
            this.lblClassLabel.Name = "lblClassLabel";
            this.lblClassLabel.Size = new System.Drawing.Size(100, 19);
            this.lblClassLabel.TabIndex = 10;
            this.lblClassLabel.Text = "Class - Section:";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblClass.Location = new System.Drawing.Point(180, 220);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(400, 19);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "-";
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenderLabel.Location = new System.Drawing.Point(20, 255);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(56, 19);
            this.lblGenderLabel.TabIndex = 12;
            this.lblGenderLabel.Text = "Gender:";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(180, 255);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(400, 19);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "-";
            // 
            // lblDOBLabel
            // 
            this.lblDOBLabel.AutoSize = true;
            this.lblDOBLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDOBLabel.Location = new System.Drawing.Point(20, 290);
            this.lblDOBLabel.Name = "lblDOBLabel";
            this.lblDOBLabel.Size = new System.Drawing.Size(92, 19);
            this.lblDOBLabel.TabIndex = 14;
            this.lblDOBLabel.Text = "Date of Birth:";
            // 
            // lblDOB
            // 
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDOB.Location = new System.Drawing.Point(180, 290);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(400, 19);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "-";
            // 
            // lblAdmissionDateLabel
            // 
            this.lblAdmissionDateLabel.AutoSize = true;
            this.lblAdmissionDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdmissionDateLabel.Location = new System.Drawing.Point(20, 320);
            this.lblAdmissionDateLabel.Name = "lblAdmissionDateLabel";
            this.lblAdmissionDateLabel.Size = new System.Drawing.Size(109, 19);
            this.lblAdmissionDateLabel.TabIndex = 16;
            this.lblAdmissionDateLabel.Text = "Admission Date:";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdmissionDate.Location = new System.Drawing.Point(180, 320);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(400, 19);
            this.lblAdmissionDate.TabIndex = 17;
            this.lblAdmissionDate.Text = "-";
            // 
            // tabAttendance
            // 
            this.tabAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabAttendance.Controls.Add(this.panelAttendanceContent);
            this.tabAttendance.Location = new System.Drawing.Point(4, 26);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(992, 500);
            this.tabAttendance.TabIndex = 1;
            this.tabAttendance.Text = "📊 My Attendance";
            // 
            // panelAttendanceContent
            // 
            this.panelAttendanceContent.AutoScroll = true;
            this.panelAttendanceContent.Controls.Add(this.panelAttendanceStats);
            this.panelAttendanceContent.Controls.Add(this.dgvAttendance);
            this.panelAttendanceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttendanceContent.Location = new System.Drawing.Point(3, 3);
            this.panelAttendanceContent.Name = "panelAttendanceContent";
            this.panelAttendanceContent.Size = new System.Drawing.Size(986, 494);
            this.panelAttendanceContent.TabIndex = 0;
            // 
            // panelAttendanceStats
            // 
            this.panelAttendanceStats.BackColor = System.Drawing.Color.White;
            this.panelAttendanceStats.Controls.Add(this.lblTotalAbsentLabel);
            this.panelAttendanceStats.Controls.Add(this.lblTotalAbsent);
            this.panelAttendanceStats.Controls.Add(this.lblTotalPresentLabel);
            this.panelAttendanceStats.Controls.Add(this.lblTotalPresent);
            this.panelAttendanceStats.Controls.Add(this.lblAttendancePercentage);
            this.panelAttendanceStats.Controls.Add(this.lblAttendanceLabel);
            this.panelAttendanceStats.Location = new System.Drawing.Point(20, 20);
            this.panelAttendanceStats.Name = "panelAttendanceStats";
            this.panelAttendanceStats.Size = new System.Drawing.Size(300, 150);
            this.panelAttendanceStats.TabIndex = 0;
            // 
            // lblAttendanceLabel
            // 
            this.lblAttendanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAttendanceLabel.Location = new System.Drawing.Point(10, 10);
            this.lblAttendanceLabel.Name = "lblAttendanceLabel";
            this.lblAttendanceLabel.Size = new System.Drawing.Size(280, 25);
            this.lblAttendanceLabel.TabIndex = 0;
            this.lblAttendanceLabel.Text = "📊 Attendance Percentage";
            this.lblAttendanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttendancePercentage
            // 
            this.lblAttendancePercentage.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAttendancePercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblAttendancePercentage.Location = new System.Drawing.Point(10, 40);
            this.lblAttendancePercentage.Name = "lblAttendancePercentage";
            this.lblAttendancePercentage.Size = new System.Drawing.Size(280, 60);
            this.lblAttendancePercentage.TabIndex = 1;
            this.lblAttendancePercentage.Text = "0%";
            this.lblAttendancePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPresentLabel
            // 
            this.lblTotalPresentLabel.AutoSize = true;
            this.lblTotalPresentLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalPresentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalPresentLabel.Location = new System.Drawing.Point(20, 110);
            this.lblTotalPresentLabel.Name = "lblTotalPresentLabel";
            this.lblTotalPresentLabel.Size = new System.Drawing.Size(57, 19);
            this.lblTotalPresentLabel.TabIndex = 2;
            this.lblTotalPresentLabel.Text = "Present:";
            // 
            // lblTotalPresent
            // 
            this.lblTotalPresent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalPresent.Location = new System.Drawing.Point(80, 110);
            this.lblTotalPresent.Name = "lblTotalPresent";
            this.lblTotalPresent.Size = new System.Drawing.Size(50, 19);
            this.lblTotalPresent.TabIndex = 3;
            this.lblTotalPresent.Text = "0";
            // 
            // lblTotalAbsentLabel
            // 
            this.lblTotalAbsentLabel.AutoSize = true;
            this.lblTotalAbsentLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalAbsentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblTotalAbsentLabel.Location = new System.Drawing.Point(150, 110);
            this.lblTotalAbsentLabel.Name = "lblTotalAbsentLabel";
            this.lblTotalAbsentLabel.Size = new System.Drawing.Size(54, 19);
            this.lblTotalAbsentLabel.TabIndex = 4;
            this.lblTotalAbsentLabel.Text = "Absent:";
            // 
            // lblTotalAbsent
            // 
            this.lblTotalAbsent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblTotalAbsent.Location = new System.Drawing.Point(210, 110);
            this.lblTotalAbsent.Name = "lblTotalAbsent";
            this.lblTotalAbsent.Size = new System.Drawing.Size(50, 19);
            this.lblTotalAbsent.TabIndex = 5;
            this.lblTotalAbsent.Text = "0";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(350, 20);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(616, 454);
            this.dgvAttendance.TabIndex = 1;
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabTimetable.Controls.Add(this.panelTimetableContent);
            this.tabTimetable.Location = new System.Drawing.Point(4, 26);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Size = new System.Drawing.Size(992, 500);
            this.tabTimetable.TabIndex = 2;
            this.tabTimetable.Text = "🕐 My Timetable";
            // 
            // panelTimetableContent
            // 
            this.panelTimetableContent.AutoScroll = true;
            this.panelTimetableContent.Controls.Add(this.dgvTimetable);
            this.panelTimetableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimetableContent.Location = new System.Drawing.Point(0, 0);
            this.panelTimetableContent.Name = "panelTimetableContent";
            this.panelTimetableContent.Size = new System.Drawing.Size(992, 500);
            this.panelTimetableContent.TabIndex = 0;
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToDeleteRows = false;
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(20, 20);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersVisible = false;
            this.dgvTimetable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(952, 460);
            this.dgvTimetable.TabIndex = 0;
            // 
            // tabMarks
            // 
            this.tabMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabMarks.Controls.Add(this.panelMarksContent);
            this.tabMarks.Location = new System.Drawing.Point(4, 26);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Size = new System.Drawing.Size(992, 500);
            this.tabMarks.TabIndex = 3;
            this.tabMarks.Text = "📝 Exam Marks";
            // 
            // panelMarksContent
            // 
            this.panelMarksContent.AutoScroll = true;
            this.panelMarksContent.Controls.Add(this.lblMarksNote);
            this.panelMarksContent.Controls.Add(this.dgvMarks);
            this.panelMarksContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMarksContent.Location = new System.Drawing.Point(0, 0);
            this.panelMarksContent.Name = "panelMarksContent";
            this.panelMarksContent.Size = new System.Drawing.Size(992, 500);
            this.panelMarksContent.TabIndex = 0;
            // 
            // dgvMarks
            // 
            this.dgvMarks.AllowUserToAddRows = false;
            this.dgvMarks.AllowUserToDeleteRows = false;
            this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(20, 50);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.ReadOnly = true;
            this.dgvMarks.RowHeadersVisible = false;
            this.dgvMarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarks.Size = new System.Drawing.Size(952, 430);
            this.dgvMarks.TabIndex = 0;
            // 
            // lblMarksNote
            // 
            this.lblMarksNote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblMarksNote.ForeColor = System.Drawing.Color.Gray;
            this.lblMarksNote.Location = new System.Drawing.Point(20, 20);
            this.lblMarksNote.Name = "lblMarksNote";
            this.lblMarksNote.Size = new System.Drawing.Size(500, 25);
            this.lblMarksNote.TabIndex = 1;
            this.lblMarksNote.Text = "";
            // 
            // StudentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educational Management System - Student Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.panelProfileContent.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.tabAttendance.ResumeLayout(false);
            this.panelAttendanceContent.ResumeLayout(false);
            this.panelAttendanceStats.ResumeLayout(false);
            this.panelAttendanceStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.tabTimetable.ResumeLayout(false);
            this.panelTimetableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.tabMarks.ResumeLayout(false);
            this.panelMarksContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel panelProfileContent;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblStudentNameLabel;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblFatherNameLabel;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClassLabel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOBLabel;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAdmissionDateLabel;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.Panel panelAttendanceContent;
        private System.Windows.Forms.Panel panelAttendanceStats;
        private System.Windows.Forms.Label lblAttendanceLabel;
        private System.Windows.Forms.Label lblAttendancePercentage;
        private System.Windows.Forms.Label lblTotalPresentLabel;
        private System.Windows.Forms.Label lblTotalPresent;
        private System.Windows.Forms.Label lblTotalAbsentLabel;
        private System.Windows.Forms.Label lblTotalAbsent;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.Panel panelTimetableContent;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.Panel panelMarksContent;
        private System.Windows.Forms.Label lblMarksNote;
        private System.Windows.Forms.DataGridView dgvMarks;
    }
}
