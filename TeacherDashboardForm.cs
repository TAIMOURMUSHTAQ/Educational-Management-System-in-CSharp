using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class TeacherDashboardForm : Form
    {
        private int teacherId;
        private string teacherName;

        public TeacherDashboardForm(int teacherId, string teacherName)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            this.teacherName = teacherName;
        }

        private void TeacherDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {teacherName}! Today is {DateTime.Now:dddd, MMMM dd, yyyy}";
            LoadTeacherInfo();
            LoadTimetable();
            LoadStudentsForAttendance();

            // Initialize attendance date
            dtpAttendanceDate.Value = DateTime.Today;
            cmbAttendanceStatus.Items.AddRange(new string[] { "Present", "Absent", "Leave" });
        }

        private void LoadTeacherInfo()
        {
            try
            {
                string query = "SELECT * FROM Teachers WHERE TeacherId = @TeacherId";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@TeacherId", teacherId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblTeacherName.Text = row["TeacherName"].ToString();
                    lblEmail.Text = row["Email"]?.ToString() ?? "N/A";
                    lblPhone.Text = row["Phone"]?.ToString() ?? "N/A";
                    lblSubject.Text = row["Subject"]?.ToString() ?? "N/A";
                    lblQualification.Text = row["Qualification"]?.ToString() ?? "N/A";
                    lblJoiningDate.Text = row["JoiningDate"] != DBNull.Value
                        ? Convert.ToDateTime(row["JoiningDate"]).ToString("dd MMM yyyy") : "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teacher info: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTimetable()
        {
            try
            {
                string query = @"SELECT t.TimetableId, t.Class, t.Section, t.Day, t.Subject, 
                                t.StartTime, t.EndTime 
                                FROM Timetable t 
                                WHERE t.TeacherId = @TeacherId
                                ORDER BY 
                                CASE t.Day 
                                    WHEN 'Monday' THEN 1 
                                    WHEN 'Tuesday' THEN 2 
                                    WHEN 'Wednesday' THEN 3 
                                    WHEN 'Thursday' THEN 4 
                                    WHEN 'Friday' THEN 5 
                                    WHEN 'Saturday' THEN 6 
                                END, t.StartTime";
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@TeacherId", teacherId) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvTimetable.DataSource = dt;

                // Format columns
                if (dgvTimetable.Columns.Count > 0)
                {
                    dgvTimetable.Columns["TimetableId"].Visible = false;
                    dgvTimetable.Columns["StartTime"].HeaderText = "Start";
                    dgvTimetable.Columns["EndTime"].HeaderText = "End";
                }

                // Update lecture count
                lblLectureCount.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetable: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentsForAttendance()
        {
            try
            {
                // Get classes that this teacher teaches
                string classQuery = @"SELECT DISTINCT Class, Section FROM Timetable WHERE TeacherId = @TeacherId";
                SqlParameter[] classParams = new SqlParameter[] { new SqlParameter("@TeacherId", teacherId) };
                DataTable classDt = DatabaseHelper.ExecuteQuery(classQuery, classParams);

                cmbClassFilter.Items.Clear();
                cmbClassFilter.Items.Add("Select Class");
                foreach (DataRow row in classDt.Rows)
                {
                    cmbClassFilter.Items.Add($"{row["Class"]}-{row["Section"]}");
                }
                cmbClassFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClassFilter.SelectedIndex <= 0) return;

            try
            {
                string[] classSec = cmbClassFilter.SelectedItem.ToString().Split('-');
                string studentQuery = @"SELECT StudentId, StudentName + ' (' + Class + '-' + Section + ')' AS DisplayName 
                                        FROM Students WHERE Class = @Class AND Section = @Section ORDER BY StudentName";
                SqlParameter[] studentParams = new SqlParameter[]
                {
                    new SqlParameter("@Class", classSec[0]),
                    new SqlParameter("@Section", classSec[1])
                };
                DataTable studentDt = DatabaseHelper.ExecuteQuery(studentQuery, studentParams);

                cmbStudent.DataSource = studentDt;
                cmbStudent.DisplayMember = "DisplayName";
                cmbStudent.ValueMember = "StudentId";
                cmbStudent.SelectedIndex = -1;

                // Load existing attendance for today
                LoadAttendanceForClass(classSec[0], classSec[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAttendanceForClass(string classVal, string section)
        {
            try
            {
                string query = @"SELECT a.AttendanceId, s.StudentName, s.Class, s.Section, 
                                a.AttendanceDate, a.Status 
                                FROM Attendance a 
                                INNER JOIN Students s ON a.StudentId = s.StudentId 
                                WHERE s.Class = @Class AND s.Section = @Section
                                AND a.AttendanceDate = @Date
                                ORDER BY s.StudentName";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Class", classVal),
                    new SqlParameter("@Section", section),
                    new SqlParameter("@Date", dtpAttendanceDate.Value.Date)
                };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvAttendance.DataSource = dt;

                if (dgvAttendance.Columns.Count > 0)
                {
                    dgvAttendance.Columns["AttendanceId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbAttendanceStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select attendance status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                DateTime attendanceDate = dtpAttendanceDate.Value.Date;

                // Check if attendance already exists (teachers can only mark once)
                string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentId = @StudentId AND AttendanceDate = @Date";
                SqlParameter[] checkParams = new SqlParameter[]
                {
                    new SqlParameter("@StudentId", studentId),
                    new SqlParameter("@Date", attendanceDate)
                };
                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (count > 0)
                {
                    MessageBox.Show("Attendance already marked for this student on this date!\nTeachers cannot modify attendance. Contact Admin for changes.",
                        "Already Marked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = @"INSERT INTO Attendance (StudentId, AttendanceDate, Status) 
                                      VALUES (@StudentId, @Date, @Status)";
                SqlParameter[] insertParams = new SqlParameter[]
                {
                    new SqlParameter("@StudentId", studentId),
                    new SqlParameter("@Date", attendanceDate),
                    new SqlParameter("@Status", cmbAttendanceStatus.SelectedItem.ToString())
                };

                int result = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
                if (result > 0)
                {
                    MessageBox.Show("Attendance marked successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload attendance grid
                    if (cmbClassFilter.SelectedIndex > 0)
                    {
                        string[] classSec = cmbClassFilter.SelectedItem.ToString().Split('-');
                        LoadAttendanceForClass(classSec[0], classSec[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error marking attendance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TeacherDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                LoadTeacherInfo();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                LoadTimetable();
            }
        }
    }
}
