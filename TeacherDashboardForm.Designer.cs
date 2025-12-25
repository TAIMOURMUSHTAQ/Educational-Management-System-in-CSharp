namespace EducationalManagementSystem
{
    partial class TeacherDashboardForm
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
            this.lblJoiningDateLabel = new System.Windows.Forms.Label();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblQualificationLabel = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblSubjectLabel = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTeacherNameLabel = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblLectureCount = new System.Windows.Forms.Label();
            this.lblLecturesLabel = new System.Windows.Forms.Label();
            this.tabTimetable = new System.Windows.Forms.TabPage();
            this.panelTimetableContent = new System.Windows.Forms.Panel();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.panelAttendanceContent = new System.Windows.Forms.Panel();
            this.panelAttendanceGrid = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panelAttendanceForm = new System.Windows.Forms.Panel();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbClassFilter = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.panelProfileContent.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.tabTimetable.SuspendLayout();
            this.panelTimetableContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.tabAttendance.SuspendLayout();
            this.panelAttendanceContent.SuspendLayout();
            this.panelAttendanceGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panelAttendanceForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
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
            this.lblTitle.Size = new System.Drawing.Size(230, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👨‍🏫 Teacher Portal";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(450, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Teacher!";
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
            this.tabControl.Controls.Add(this.tabTimetable);
            this.tabControl.Controls.Add(this.tabAttendance);
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
            this.panelProfileContent.Controls.Add(this.panelStats);
            this.panelProfileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfileContent.Location = new System.Drawing.Point(3, 3);
            this.panelProfileContent.Name = "panelProfileContent";
            this.panelProfileContent.Size = new System.Drawing.Size(986, 494);
            this.panelProfileContent.TabIndex = 0;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelStats.Controls.Add(this.lblLectureCount);
            this.panelStats.Controls.Add(this.lblLecturesLabel);
            this.panelStats.Location = new System.Drawing.Point(20, 20);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(200, 120);
            this.panelStats.TabIndex = 0;
            // 
            // lblLecturesLabel
            // 
            this.lblLecturesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLecturesLabel.ForeColor = System.Drawing.Color.White;
            this.lblLecturesLabel.Location = new System.Drawing.Point(0, 15);
            this.lblLecturesLabel.Name = "lblLecturesLabel";
            this.lblLecturesLabel.Size = new System.Drawing.Size(200, 25);
            this.lblLecturesLabel.TabIndex = 0;
            this.lblLecturesLabel.Text = "📚 My Lectures";
            this.lblLecturesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLectureCount
            // 
            this.lblLectureCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblLectureCount.ForeColor = System.Drawing.Color.White;
            this.lblLectureCount.Location = new System.Drawing.Point(0, 45);
            this.lblLectureCount.Name = "lblLectureCount";
            this.lblLectureCount.Size = new System.Drawing.Size(200, 60);
            this.lblLectureCount.TabIndex = 1;
            this.lblLectureCount.Text = "0";
            this.lblLectureCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.lblJoiningDateLabel);
            this.groupBoxInfo.Controls.Add(this.lblJoiningDate);
            this.groupBoxInfo.Controls.Add(this.lblQualificationLabel);
            this.groupBoxInfo.Controls.Add(this.lblQualification);
            this.groupBoxInfo.Controls.Add(this.lblSubjectLabel);
            this.groupBoxInfo.Controls.Add(this.lblSubject);
            this.groupBoxInfo.Controls.Add(this.lblPhoneLabel);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Controls.Add(this.lblEmailLabel);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblTeacherNameLabel);
            this.groupBoxInfo.Controls.Add(this.lblTeacherName);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(240, 20);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(450, 250);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Personal Information";
            // 
            // lblTeacherNameLabel
            // 
            this.lblTeacherNameLabel.AutoSize = true;
            this.lblTeacherNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTeacherNameLabel.Location = new System.Drawing.Point(20, 40);
            this.lblTeacherNameLabel.Name = "lblTeacherNameLabel";
            this.lblTeacherNameLabel.Size = new System.Drawing.Size(49, 19);
            this.lblTeacherNameLabel.TabIndex = 0;
            this.lblTeacherNameLabel.Text = "Name:";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTeacherName.Location = new System.Drawing.Point(150, 40);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(280, 19);
            this.lblTeacherName.TabIndex = 1;
            this.lblTeacherName.Text = "-";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailLabel.Location = new System.Drawing.Point(20, 70);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(45, 19);
            this.lblEmailLabel.TabIndex = 2;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(150, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(280, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "-";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhoneLabel.Location = new System.Drawing.Point(20, 100);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(50, 19);
            this.lblPhoneLabel.TabIndex = 4;
            this.lblPhoneLabel.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(150, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(280, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "-";
            // 
            // lblSubjectLabel
            // 
            this.lblSubjectLabel.AutoSize = true;
            this.lblSubjectLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubjectLabel.Location = new System.Drawing.Point(20, 130);
            this.lblSubjectLabel.Name = "lblSubjectLabel";
            this.lblSubjectLabel.Size = new System.Drawing.Size(56, 19);
            this.lblSubjectLabel.TabIndex = 6;
            this.lblSubjectLabel.Text = "Subject:";
            // 
            // lblSubject
            // 
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblSubject.Location = new System.Drawing.Point(150, 130);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(280, 19);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "-";
            // 
            // lblQualificationLabel
            // 
            this.lblQualificationLabel.AutoSize = true;
            this.lblQualificationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualificationLabel.Location = new System.Drawing.Point(20, 160);
            this.lblQualificationLabel.Name = "lblQualificationLabel";
            this.lblQualificationLabel.Size = new System.Drawing.Size(88, 19);
            this.lblQualificationLabel.TabIndex = 8;
            this.lblQualificationLabel.Text = "Qualification:";
            // 
            // lblQualification
            // 
            this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQualification.Location = new System.Drawing.Point(150, 160);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(280, 19);
            this.lblQualification.TabIndex = 9;
            this.lblQualification.Text = "-";
            // 
            // lblJoiningDateLabel
            // 
            this.lblJoiningDateLabel.AutoSize = true;
            this.lblJoiningDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJoiningDateLabel.Location = new System.Drawing.Point(20, 190);
            this.lblJoiningDateLabel.Name = "lblJoiningDateLabel";
            this.lblJoiningDateLabel.Size = new System.Drawing.Size(85, 19);
            this.lblJoiningDateLabel.TabIndex = 10;
            this.lblJoiningDateLabel.Text = "Joining Date:";
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJoiningDate.Location = new System.Drawing.Point(150, 190);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(280, 19);
            this.lblJoiningDate.TabIndex = 11;
            this.lblJoiningDate.Text = "-";
            // 
            // tabTimetable
            // 
            this.tabTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabTimetable.Controls.Add(this.panelTimetableContent);
            this.tabTimetable.Location = new System.Drawing.Point(4, 26);
            this.tabTimetable.Name = "tabTimetable";
            this.tabTimetable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimetable.Size = new System.Drawing.Size(992, 500);
            this.tabTimetable.TabIndex = 1;
            this.tabTimetable.Text = "🕐 My Timetable";
            // 
            // panelTimetableContent
            // 
            this.panelTimetableContent.AutoScroll = true;
            this.panelTimetableContent.Controls.Add(this.dgvTimetable);
            this.panelTimetableContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTimetableContent.Location = new System.Drawing.Point(3, 3);
            this.panelTimetableContent.Name = "panelTimetableContent";
            this.panelTimetableContent.Size = new System.Drawing.Size(986, 494);
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
            this.dgvTimetable.Size = new System.Drawing.Size(946, 454);
            this.dgvTimetable.TabIndex = 0;
            // 
            // tabAttendance
            // 
            this.tabAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabAttendance.Controls.Add(this.panelAttendanceContent);
            this.tabAttendance.Location = new System.Drawing.Point(4, 26);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(992, 500);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "📋 Mark Attendance";
            // 
            // panelAttendanceContent
            // 
            this.panelAttendanceContent.AutoScroll = true;
            this.panelAttendanceContent.Controls.Add(this.panelAttendanceGrid);
            this.panelAttendanceContent.Controls.Add(this.panelAttendanceForm);
            this.panelAttendanceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttendanceContent.Location = new System.Drawing.Point(0, 0);
            this.panelAttendanceContent.Name = "panelAttendanceContent";
            this.panelAttendanceContent.Size = new System.Drawing.Size(992, 500);
            this.panelAttendanceContent.TabIndex = 0;
            // 
            // panelAttendanceForm
            // 
            this.panelAttendanceForm.BackColor = System.Drawing.Color.White;
            this.panelAttendanceForm.Controls.Add(this.btnMarkAttendance);
            this.panelAttendanceForm.Controls.Add(this.cmbAttendanceStatus);
            this.panelAttendanceForm.Controls.Add(this.lblStatus);
            this.panelAttendanceForm.Controls.Add(this.cmbStudent);
            this.panelAttendanceForm.Controls.Add(this.lblStudent);
            this.panelAttendanceForm.Controls.Add(this.dtpAttendanceDate);
            this.panelAttendanceForm.Controls.Add(this.lblDate);
            this.panelAttendanceForm.Controls.Add(this.cmbClassFilter);
            this.panelAttendanceForm.Controls.Add(this.lblClass);
            this.panelAttendanceForm.Location = new System.Drawing.Point(20, 20);
            this.panelAttendanceForm.Name = "panelAttendanceForm";
            this.panelAttendanceForm.Size = new System.Drawing.Size(350, 250);
            this.panelAttendanceForm.TabIndex = 0;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClass.Location = new System.Drawing.Point(20, 20);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(88, 19);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Select Class:*";
            // 
            // cmbClassFilter
            // 
            this.cmbClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClassFilter.Location = new System.Drawing.Point(140, 17);
            this.cmbClassFilter.Name = "cmbClassFilter";
            this.cmbClassFilter.Size = new System.Drawing.Size(190, 25);
            this.cmbClassFilter.TabIndex = 1;
            this.cmbClassFilter.SelectedIndexChanged += new System.EventHandler(this.cmbClassFilter_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(20, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttendanceDate.Location = new System.Drawing.Point(140, 52);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(190, 25);
            this.dtpAttendanceDate.TabIndex = 3;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudent.Location = new System.Drawing.Point(20, 95);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(65, 19);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "Student:*";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudent.Location = new System.Drawing.Point(140, 92);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(190, 25);
            this.cmbStudent.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(20, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:*";
            // 
            // cmbAttendanceStatus
            // 
            this.cmbAttendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttendanceStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(140, 132);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(190, 25);
            this.cmbAttendanceStatus.TabIndex = 7;
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMarkAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAttendance.FlatAppearance.BorderSize = 0;
            this.btnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkAttendance.ForeColor = System.Drawing.Color.White;
            this.btnMarkAttendance.Location = new System.Drawing.Point(140, 180);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(190, 40);
            this.btnMarkAttendance.TabIndex = 8;
            this.btnMarkAttendance.Text = "✓ Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = false;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // panelAttendanceGrid
            // 
            this.panelAttendanceGrid.BackColor = System.Drawing.Color.White;
            this.panelAttendanceGrid.Controls.Add(this.dgvAttendance);
            this.panelAttendanceGrid.Location = new System.Drawing.Point(390, 20);
            this.panelAttendanceGrid.Name = "panelAttendanceGrid";
            this.panelAttendanceGrid.Size = new System.Drawing.Size(580, 460);
            this.panelAttendanceGrid.TabIndex = 1;
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(580, 460);
            this.dgvAttendance.TabIndex = 0;
            // 
            // TeacherDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeacherDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educational Management System - Teacher Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherDashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.TeacherDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.panelProfileContent.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.tabTimetable.ResumeLayout(false);
            this.panelTimetableContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            this.panelAttendanceContent.ResumeLayout(false);
            this.panelAttendanceGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panelAttendanceForm.ResumeLayout(false);
            this.panelAttendanceForm.PerformLayout();
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
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblLecturesLabel;
        private System.Windows.Forms.Label lblLectureCount;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblTeacherNameLabel;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSubjectLabel;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblQualificationLabel;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblJoiningDateLabel;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.TabPage tabTimetable;
        private System.Windows.Forms.Panel panelTimetableContent;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.Panel panelAttendanceContent;
        private System.Windows.Forms.Panel panelAttendanceForm;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClassFilter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Panel panelAttendanceGrid;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}
