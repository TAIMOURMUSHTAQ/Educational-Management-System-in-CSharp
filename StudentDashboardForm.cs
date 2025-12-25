using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class StudentDashboardForm : Form
    {
        private int studentId;
        private string studentName;
        private string studentClass;
        private string section;

        public StudentDashboardForm(int studentId, string studentName, string studentClass, string section)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentClass = studentClass;
            this.section = section;
        }

        private void StudentDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {studentName}! Today is {DateTime.Now:dddd, MMMM dd, yyyy}";
            LoadStudentInfo();
            LoadAttendance();
            LoadTimetable();
            LoadExamMarks();
        }

        private void LoadStudentInfo()
        {
            try
            {
                string query = "SELECT * FROM Students WHERE StudentId = @StudentId";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentId", studentId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblStudentName.Text = row["StudentName"].ToString();
                    lblFatherName.Text = row["FatherName"]?.ToString() ?? "N/A";
                    lblEmail.Text = row["Email"]?.ToString() ?? "N/A";
                    lblPhone.Text = row["Phone"]?.ToString() ?? "N/A";
                    lblAddress.Text = row["Address"]?.ToString() ?? "N/A";
                    lblClass.Text = $"{row["Class"]} - {row["Section"]}";
                    lblGender.Text = row["Gender"]?.ToString() ?? "N/A";
                    lblDOB.Text = row["DateOfBirth"] != DBNull.Value
                        ? Convert.ToDateTime(row["DateOfBirth"]).ToString("dd MMM yyyy") : "N/A";
                    lblAdmissionDate.Text = row["AdmissionDate"] != DBNull.Value
                        ? Convert.ToDateTime(row["AdmissionDate"]).ToString("dd MMM yyyy") : "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student info: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAttendance()
        {
            try
            {
                string query = @"SELECT AttendanceDate as Date, Status 
                                FROM Attendance 
                                WHERE StudentId = @StudentId 
                                ORDER BY AttendanceDate DESC";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentId", studentId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvAttendance.DataSource = dt;

                // Calculate attendance percentage
                int totalDays = dt.Rows.Count;
                int presentDays = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Status"].ToString() == "Present")
                        presentDays++;
                }

                double percentage = totalDays > 0 ? (presentDays * 100.0 / totalDays) : 0;
                lblAttendancePercentage.Text = $"{percentage:F1}%";
                lblTotalPresent.Text = presentDays.ToString();
                lblTotalAbsent.Text = (totalDays - presentDays).ToString();

                // Color based on percentage
                if (percentage >= 75)
                    lblAttendancePercentage.ForeColor = Color.FromArgb(39, 174, 96);
                else if (percentage >= 50)
                    lblAttendancePercentage.ForeColor = Color.FromArgb(230, 126, 34);
                else
                    lblAttendancePercentage.ForeColor = Color.FromArgb(231, 76, 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTimetable()
        {
            try
            {
                string query = @"SELECT t.Day, t.Subject, tc.TeacherName as Teacher, 
                                t.StartTime as [Start Time], t.EndTime as [End Time]
                                FROM Timetable t 
                                LEFT JOIN Teachers tc ON t.TeacherId = tc.TeacherId
                                WHERE t.Class = @Class AND t.Section = @Section
                                ORDER BY 
                                CASE t.Day 
                                    WHEN 'Monday' THEN 1 
                                    WHEN 'Tuesday' THEN 2 
                                    WHEN 'Wednesday' THEN 3 
                                    WHEN 'Thursday' THEN 4 
                                    WHEN 'Friday' THEN 5 
                                    WHEN 'Saturday' THEN 6 
                                END, t.StartTime";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Class", studentClass),
                    new SqlParameter("@Section", section)
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvTimetable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetable: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExamMarks()
        {
            try
            {
                // Check if ExamMarks table exists, if not create sample data
                string checkQuery = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES 
                                     WHERE TABLE_NAME = 'ExamMarks'";
                int tableExists = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery));

                if (tableExists == 0)
                {
                    // Create sample marks data for display
                    DataTable sampleDt = new DataTable();
                    sampleDt.Columns.Add("Subject", typeof(string));
                    sampleDt.Columns.Add("Obtained Marks", typeof(int));
                    sampleDt.Columns.Add("Total Marks", typeof(int));
                    sampleDt.Columns.Add("Percentage", typeof(string));
                    sampleDt.Columns.Add("Grade", typeof(string));

                    // Add sample data
                    sampleDt.Rows.Add("Mathematics", 85, 100, "85%", "A");
                    sampleDt.Rows.Add("English", 78, 100, "78%", "B+");
                    sampleDt.Rows.Add("Science", 92, 100, "92%", "A+");
                    sampleDt.Rows.Add("Physics", 76, 100, "76%", "B+");
                    sampleDt.Rows.Add("Chemistry", 88, 100, "88%", "A");
                    sampleDt.Rows.Add("Computer Science", 95, 100, "95%", "A+");

                    dgvMarks.DataSource = sampleDt;
                    lblMarksNote.Text = "Note: Sample data shown. Contact admin for actual marks.";
                }
                else
                {
                    string query = @"SELECT Subject, ObtainedMarks as [Obtained Marks], 
                                    TotalMarks as [Total Marks],
                                    CAST((ObtainedMarks * 100.0 / TotalMarks) as VARCHAR) + '%' as Percentage,
                                    Grade
                                    FROM ExamMarks 
                                    WHERE StudentId = @StudentId 
                                    ORDER BY Subject";
                    SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@StudentId", studentId) };
                    DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                    dgvMarks.DataSource = dt;
                }
            }
            catch (Exception)
            {
                // Show sample data if there's an error
                DataTable sampleDt = new DataTable();
                sampleDt.Columns.Add("Subject", typeof(string));
                sampleDt.Columns.Add("Obtained Marks", typeof(int));
                sampleDt.Columns.Add("Total Marks", typeof(int));
                sampleDt.Columns.Add("Percentage", typeof(string));
                sampleDt.Columns.Add("Grade", typeof(string));

                sampleDt.Rows.Add("Mathematics", 85, 100, "85%", "A");
                sampleDt.Rows.Add("English", 78, 100, "78%", "B+");
                sampleDt.Rows.Add("Science", 92, 100, "92%", "A+");
                sampleDt.Rows.Add("Physics", 76, 100, "76%", "B+");
                sampleDt.Rows.Add("Chemistry", 88, 100, "88%", "A");

                dgvMarks.DataSource = sampleDt;
                lblMarksNote.Text = "Note: Sample data shown.";
            }
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

        private void StudentDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    LoadStudentInfo();
                    break;
                case 1:
                    LoadAttendance();
                    break;
                case 2:
                    LoadTimetable();
                    break;
                case 3:
                    LoadExamMarks();
                    break;
            }
        }
    }
}
