using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class RoleLoginForm : Form
    {
        private string userRole;

        public RoleLoginForm(string role)
        {
            InitializeComponent();
            this.userRole = role;
        }

        private void RoleLoginForm_Load(object sender, EventArgs e)
        {
            // Set role-specific styling
            switch (userRole)
            {
                case "Admin":
                    lblTitle.Text = "Administrator Login";
                    panelHeader.BackColor = Color.FromArgb(231, 76, 60);
                    btnLogin.BackColor = Color.FromArgb(231, 76, 60);
                    break;
                case "Teacher":
                    lblTitle.Text = "Teacher Login";
                    panelHeader.BackColor = Color.FromArgb(39, 174, 96);
                    btnLogin.BackColor = Color.FromArgb(39, 174, 96);
                    break;
                case "Student":
                    lblTitle.Text = "Student Login";
                    panelHeader.BackColor = Color.FromArgb(41, 128, 185);
                    btnLogin.BackColor = Color.FromArgb(41, 128, 185);
                    break;
            }

            // Load logo
            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\icon.png");
                if (System.IO.File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (userRole)
                {
                    case "Admin":
                        ValidateAdmin(username, password);
                        break;
                    case "Teacher":
                        ValidateTeacher(username, password);
                        break;
                    case "Student":
                        ValidateStudent(username, password);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message + "\n\nPlease make sure the database is set up correctly.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateAdmin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            int count = Convert.ToInt32(result);

            if (count > 0)
            {
                MessageBox.Show("Login Successful! Welcome Admin.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm("Admin", 0, "Administrator");
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void ValidateTeacher(string username, string password)
        {
            // For teachers, username is email and password is phone number (for simplicity)
            string query = "SELECT TeacherId, TeacherName FROM Teachers WHERE Email = @Email AND Phone = @Phone";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", username),
                new SqlParameter("@Phone", password)
            };

            var dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                int teacherId = Convert.ToInt32(dt.Rows[0]["TeacherId"]);
                string teacherName = dt.Rows[0]["TeacherName"].ToString();

                MessageBox.Show($"Login Successful! Welcome {teacherName}.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TeacherDashboardForm teacherDashboard = new TeacherDashboardForm(teacherId, teacherName);
                teacherDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!\n\nNote: Use your Email as username and Phone as password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void ValidateStudent(string username, string password)
        {
            // For students, username is email and password is phone number (for simplicity)
            string query = "SELECT StudentId, StudentName, Class, Section FROM Students WHERE Email = @Email AND Phone = @Phone";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", username),
                new SqlParameter("@Phone", password)
            };

            var dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                int studentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
                string studentName = dt.Rows[0]["StudentName"].ToString();
                string studentClass = dt.Rows[0]["Class"].ToString();
                string section = dt.Rows[0]["Section"].ToString();

                MessageBox.Show($"Login Successful! Welcome {studentName}.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                StudentDashboardForm studentDashboard = new StudentDashboardForm(studentId, studentName, studentClass, section);
                studentDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!\n\nNote: Use your Email as username and Phone as password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void RoleLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
