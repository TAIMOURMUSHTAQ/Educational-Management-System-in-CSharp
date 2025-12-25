namespace EducationalManagementSystem
{
    partial class DashboardForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTimetableCard = new System.Windows.Forms.Panel();
            this.lblTimetableCount = new System.Windows.Forms.Label();
            this.lblTimetableTitle = new System.Windows.Forms.Label();
            this.panelAttendanceCard = new System.Windows.Forms.Panel();
            this.lblAttendanceCount = new System.Windows.Forms.Label();
            this.lblAttendanceTitle = new System.Windows.Forms.Label();
            this.panelTeacherCard = new System.Windows.Forms.Panel();
            this.lblTeacherCount = new System.Windows.Forms.Label();
            this.lblTeacherTitle = new System.Windows.Forms.Label();
            this.panelStudentCard = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelTimetableCard.SuspendLayout();
            this.panelAttendanceCard.SuspendLayout();
            this.panelTeacherCard.SuspendLayout();
            this.panelStudentCard.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(380, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 Educational Management System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(500, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Admin!";
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
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.btnRefresh);
            this.panelSidebar.Controls.Add(this.btnUserManagement);
            this.panelSidebar.Controls.Add(this.btnTimetable);
            this.panelSidebar.Controls.Add(this.btnAttendance);
            this.panelSidebar.Controls.Add(this.btnTeachers);
            this.panelSidebar.Controls.Add(this.btnStudents);
            this.panelSidebar.Controls.Add(this.lblMenu);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 530);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(0, 20);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(200, 30);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(0, 70);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 50);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "👨‍🎓 Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Location = new System.Drawing.Point(0, 125);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(200, 50);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "👨‍🏫 Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 180);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 50);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "📋 Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTimetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimetable.FlatAppearance.BorderSize = 0;
            this.btnTimetable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTimetable.ForeColor = System.Drawing.Color.White;
            this.btnTimetable.Location = new System.Drawing.Point(0, 235);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(200, 50);
            this.btnTimetable.TabIndex = 4;
            this.btnTimetable.Text = "🕐 Timetable";
            this.btnTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimetable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 290);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 50);
            this.btnUserManagement.TabIndex = 6;
            this.btnUserManagement.Text = "🔐 User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.panelTimetableCard);
            this.panelContent.Controls.Add(this.panelAttendanceCard);
            this.panelContent.Controls.Add(this.panelTeacherCard);
            this.panelContent.Controls.Add(this.panelStudentCard);
            this.panelContent.Controls.Add(this.lblDashboardTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 530);
            this.panelContent.TabIndex = 2;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(30, 30);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(127, 30);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // panelStudentCard
            // 
            this.panelStudentCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelStudentCard.Controls.Add(this.lblStudentCount);
            this.panelStudentCard.Controls.Add(this.lblStudentTitle);
            this.panelStudentCard.Location = new System.Drawing.Point(35, 90);
            this.panelStudentCard.Name = "panelStudentCard";
            this.panelStudentCard.Size = new System.Drawing.Size(170, 150);
            this.panelStudentCard.TabIndex = 1;
            // 
            // lblStudentTitle
            // 
            this.lblStudentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStudentTitle.ForeColor = System.Drawing.Color.White;
            this.lblStudentTitle.Location = new System.Drawing.Point(0, 20);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(170, 30);
            this.lblStudentTitle.TabIndex = 0;
            this.lblStudentTitle.Text = "👨‍🎓 Students";
            this.lblStudentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.ForeColor = System.Drawing.Color.White;
            this.lblStudentCount.Location = new System.Drawing.Point(0, 60);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(170, 70);
            this.lblStudentCount.TabIndex = 1;
            this.lblStudentCount.Text = "0";
            this.lblStudentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTeacherCard
            // 
            this.panelTeacherCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelTeacherCard.Controls.Add(this.lblTeacherCount);
            this.panelTeacherCard.Controls.Add(this.lblTeacherTitle);
            this.panelTeacherCard.Location = new System.Drawing.Point(225, 90);
            this.panelTeacherCard.Name = "panelTeacherCard";
            this.panelTeacherCard.Size = new System.Drawing.Size(170, 150);
            this.panelTeacherCard.TabIndex = 2;
            // 
            // lblTeacherTitle
            // 
            this.lblTeacherTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTeacherTitle.ForeColor = System.Drawing.Color.White;
            this.lblTeacherTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTeacherTitle.Name = "lblTeacherTitle";
            this.lblTeacherTitle.Size = new System.Drawing.Size(170, 30);
            this.lblTeacherTitle.TabIndex = 0;
            this.lblTeacherTitle.Text = "👨‍🏫 Teachers";
            this.lblTeacherTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeacherCount
            // 
            this.lblTeacherCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTeacherCount.ForeColor = System.Drawing.Color.White;
            this.lblTeacherCount.Location = new System.Drawing.Point(0, 60);
            this.lblTeacherCount.Name = "lblTeacherCount";
            this.lblTeacherCount.Size = new System.Drawing.Size(170, 70);
            this.lblTeacherCount.TabIndex = 1;
            this.lblTeacherCount.Text = "0";
            this.lblTeacherCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAttendanceCard
            // 
            this.panelAttendanceCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelAttendanceCard.Controls.Add(this.lblAttendanceCount);
            this.panelAttendanceCard.Controls.Add(this.lblAttendanceTitle);
            this.panelAttendanceCard.Location = new System.Drawing.Point(415, 90);
            this.panelAttendanceCard.Name = "panelAttendanceCard";
            this.panelAttendanceCard.Size = new System.Drawing.Size(170, 150);
            this.panelAttendanceCard.TabIndex = 3;
            // 
            // lblAttendanceTitle
            // 
            this.lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceTitle.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceTitle.Location = new System.Drawing.Point(0, 20);
            this.lblAttendanceTitle.Name = "lblAttendanceTitle";
            this.lblAttendanceTitle.Size = new System.Drawing.Size(170, 30);
            this.lblAttendanceTitle.TabIndex = 0;
            this.lblAttendanceTitle.Text = "📋 Present Today";
            this.lblAttendanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttendanceCount
            // 
            this.lblAttendanceCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceCount.ForeColor = System.Drawing.Color.White;
            this.lblAttendanceCount.Location = new System.Drawing.Point(0, 60);
            this.lblAttendanceCount.Name = "lblAttendanceCount";
            this.lblAttendanceCount.Size = new System.Drawing.Size(170, 70);
            this.lblAttendanceCount.TabIndex = 1;
            this.lblAttendanceCount.Text = "0";
            this.lblAttendanceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTimetableCard
            // 
            this.panelTimetableCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelTimetableCard.Controls.Add(this.lblTimetableCount);
            this.panelTimetableCard.Controls.Add(this.lblTimetableTitle);
            this.panelTimetableCard.Location = new System.Drawing.Point(605, 90);
            this.panelTimetableCard.Name = "panelTimetableCard";
            this.panelTimetableCard.Size = new System.Drawing.Size(170, 150);
            this.panelTimetableCard.TabIndex = 4;
            // 
            // lblTimetableTitle
            // 
            this.lblTimetableTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimetableTitle.ForeColor = System.Drawing.Color.White;
            this.lblTimetableTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTimetableTitle.Name = "lblTimetableTitle";
            this.lblTimetableTitle.Size = new System.Drawing.Size(170, 30);
            this.lblTimetableTitle.TabIndex = 0;
            this.lblTimetableTitle.Text = "🕐 Timetable";
            this.lblTimetableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimetableCount
            // 
            this.lblTimetableCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTimetableCount.ForeColor = System.Drawing.Color.White;
            this.lblTimetableCount.Location = new System.Drawing.Point(0, 60);
            this.lblTimetableCount.Name = "lblTimetableCount";
            this.lblTimetableCount.Size = new System.Drawing.Size(170, 70);
            this.lblTimetableCount.TabIndex = 1;
            this.lblTimetableCount.Text = "0";
            this.lblTimetableCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educational Management System - Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelTimetableCard.ResumeLayout(false);
            this.panelAttendanceCard.ResumeLayout(false);
            this.panelTeacherCard.ResumeLayout(false);
            this.panelStudentCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel panelStudentCard;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Panel panelTeacherCard;
        private System.Windows.Forms.Label lblTeacherTitle;
        private System.Windows.Forms.Label lblTeacherCount;
        private System.Windows.Forms.Panel panelAttendanceCard;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceCount;
        private System.Windows.Forms.Panel panelTimetableCard;
        private System.Windows.Forms.Label lblTimetableTitle;
        private System.Windows.Forms.Label lblTimetableCount;
        private System.Windows.Forms.Button btnUserManagement;
    }
}
