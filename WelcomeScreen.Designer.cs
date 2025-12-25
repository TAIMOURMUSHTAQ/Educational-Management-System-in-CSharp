namespace EducationalManagementSystem
{
    partial class WelcomeScreen
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblStudentDesc = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.lblTeacherDesc = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblAdminDesc = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.lblSelectRole = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.panelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.lblSelectRole);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Controls.Add(this.pictureBoxLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 600);
            this.panelMain.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pictureBoxLogo.Location = new System.Drawing.Point(400, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 140);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(900, 50);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSubtitle.Location = new System.Drawing.Point(0, 190);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(900, 30);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Educational Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectRole
            // 
            this.lblSelectRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblSelectRole.Location = new System.Drawing.Point(0, 240);
            this.lblSelectRole.Name = "lblSelectRole";
            this.lblSelectRole.Size = new System.Drawing.Size(900, 30);
            this.lblSelectRole.TabIndex = 3;
            this.lblSelectRole.Text = "Please select your role to continue";
            this.lblSelectRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.panelStudent);
            this.panelCards.Controls.Add(this.panelTeacher);
            this.panelCards.Controls.Add(this.panelAdmin);
            this.panelCards.Location = new System.Drawing.Point(50, 280);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(800, 250);
            this.panelCards.TabIndex = 4;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.White;
            this.panelAdmin.Controls.Add(this.btnAdmin);
            this.panelAdmin.Controls.Add(this.lblAdminDesc);
            this.panelAdmin.Controls.Add(this.lblAdmin);
            this.panelAdmin.Controls.Add(this.picAdmin);
            this.panelAdmin.Location = new System.Drawing.Point(20, 10);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(230, 230);
            this.panelAdmin.TabIndex = 0;
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.picAdmin.Location = new System.Drawing.Point(80, 20);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(70, 70);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAdmin.Location = new System.Drawing.Point(0, 95);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(230, 30);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administrator";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminDesc
            // 
            this.lblAdminDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblAdminDesc.Location = new System.Drawing.Point(10, 125);
            this.lblAdminDesc.Name = "lblAdminDesc";
            this.lblAdminDesc.Size = new System.Drawing.Size(210, 40);
            this.lblAdminDesc.TabIndex = 2;
            this.lblAdminDesc.Text = "Full system access with complete management capabilities";
            this.lblAdminDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(40, 175);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 40);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Login as Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BackColor = System.Drawing.Color.White;
            this.panelTeacher.Controls.Add(this.btnTeacher);
            this.panelTeacher.Controls.Add(this.lblTeacherDesc);
            this.panelTeacher.Controls.Add(this.lblTeacher);
            this.panelTeacher.Controls.Add(this.picTeacher);
            this.panelTeacher.Location = new System.Drawing.Point(285, 10);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(230, 230);
            this.panelTeacher.TabIndex = 1;
            // 
            // picTeacher
            // 
            this.picTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.picTeacher.Location = new System.Drawing.Point(80, 20);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(70, 70);
            this.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTeacher.TabIndex = 0;
            this.picTeacher.TabStop = false;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTeacher.Location = new System.Drawing.Point(0, 95);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(230, 30);
            this.lblTeacher.TabIndex = 1;
            this.lblTeacher.Text = "Teacher";
            this.lblTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeacherDesc
            // 
            this.lblTeacherDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTeacherDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblTeacherDesc.Location = new System.Drawing.Point(10, 125);
            this.lblTeacherDesc.Name = "lblTeacherDesc";
            this.lblTeacherDesc.Size = new System.Drawing.Size(210, 40);
            this.lblTeacherDesc.TabIndex = 2;
            this.lblTeacherDesc.Text = "View schedule, mark attendance, and manage classes";
            this.lblTeacherDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Location = new System.Drawing.Point(40, 175);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(150, 40);
            this.btnTeacher.TabIndex = 3;
            this.btnTeacher.Text = "Login as Teacher";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.White;
            this.panelStudent.Controls.Add(this.btnStudent);
            this.panelStudent.Controls.Add(this.lblStudentDesc);
            this.panelStudent.Controls.Add(this.lblStudent);
            this.panelStudent.Controls.Add(this.picStudent);
            this.panelStudent.Location = new System.Drawing.Point(550, 10);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(230, 230);
            this.panelStudent.TabIndex = 2;
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.picStudent.Location = new System.Drawing.Point(80, 20);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(70, 70);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 0;
            this.picStudent.TabStop = false;
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStudent.Location = new System.Drawing.Point(0, 95);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(230, 30);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentDesc
            // 
            this.lblStudentDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentDesc.Location = new System.Drawing.Point(10, 125);
            this.lblStudentDesc.Name = "lblStudentDesc";
            this.lblStudentDesc.Size = new System.Drawing.Size(210, 40);
            this.lblStudentDesc.TabIndex = 2;
            this.lblStudentDesc.Text = "View attendance, marks, timetable, and personal info";
            this.lblStudentDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(40, 175);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(150, 40);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Login as Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(375, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educational Management System - Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeScreen_FormClosing);
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.panelTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSelectRole;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAdminDesc;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblTeacherDesc;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudentDesc;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnExit;
    }
}
