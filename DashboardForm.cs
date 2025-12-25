using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class DashboardForm : Form
    {
        private string userRole;
        private int userId;
        private string userName;

        public DashboardForm() : this("Admin", 0, "Administrator")
        {
        }

        public DashboardForm(string role, int id, string name)
        {
            InitializeComponent();
            this.userRole = role;
            this.userId = id;
            this.userName = name;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            lblWelcome.Text = $"Welcome, {userName}! Today is {DateTime.Now:dddd, MMMM dd, yyyy}";
        }

        private void LoadDashboardData()
        {
            try
            {
                // Get Student Count
                object studentCount = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Students");
                lblStudentCount.Text = studentCount?.ToString() ?? "0";

                // Get Teacher Count
                object teacherCount = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Teachers");
                lblTeacherCount.Text = teacherCount?.ToString() ?? "0";

                // Get Today's Attendance Count (Present)
                string attendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE AttendanceDate = @Today AND Status = 'Present'";
                object attendanceCount = DatabaseHelper.ExecuteScalar(attendanceQuery,
                    new System.Data.SqlClient.SqlParameter[] {
                        new System.Data.SqlClient.SqlParameter("@Today", DateTime.Today)
                    });
                lblAttendanceCount.Text = attendanceCount?.ToString() ?? "0";

                // Get Timetable Entries Count
                object timetableCount = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Timetable");
                lblTimetableCount.Text = timetableCount?.ToString() ?? "0";
            }
            catch (Exception ex)
            {
                // Set default values if database is not available
                lblStudentCount.Text = "0";
                lblTeacherCount.Text = "0";
                lblAttendanceCount.Text = "0";
                lblTimetableCount.Text = "0";

                MessageBox.Show("Could not load dashboard data: " + ex.Message, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentManagementForm studentForm = new StudentManagementForm();
            studentForm.ShowDialog();
            LoadDashboardData(); // Refresh counts after closing
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            TeacherManagementForm teacherForm = new TeacherManagementForm();
            teacherForm.ShowDialog();
            LoadDashboardData();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.ShowDialog();
            LoadDashboardData();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();
            timetableForm.ShowDialog();
            LoadDashboardData();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userForm = new UserManagementForm();
            userForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                WelcomeScreen welcomeScreen = new WelcomeScreen();
                welcomeScreen.Show();
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
