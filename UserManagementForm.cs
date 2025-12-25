using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadStudents();
            LoadAdmins();
        }

        private void LoadTeachers()
        {
            try
            {
                string query = @"SELECT TeacherId, TeacherName, Email AS Username, Phone AS Password, Subject 
                                FROM Teachers ORDER BY TeacherName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvTeachers.DataSource = dt;

                if (dgvTeachers.Columns.Count > 0)
                {
                    dgvTeachers.Columns["TeacherId"].HeaderText = "ID";
                    dgvTeachers.Columns["TeacherName"].HeaderText = "Name";
                    dgvTeachers.Columns["Username"].HeaderText = "Username (Email)";
                    dgvTeachers.Columns["Password"].HeaderText = "Password (Phone)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                string query = @"SELECT StudentId, StudentName, Email AS Username, Phone AS Password, Class, Section 
                                FROM Students ORDER BY StudentName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvStudents.DataSource = dt;

                if (dgvStudents.Columns.Count > 0)
                {
                    dgvStudents.Columns["StudentId"].HeaderText = "ID";
                    dgvStudents.Columns["StudentName"].HeaderText = "Name";
                    dgvStudents.Columns["Username"].HeaderText = "Username (Email)";
                    dgvStudents.Columns["Password"].HeaderText = "Password (Phone)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAdmins()
        {
            try
            {
                string query = @"SELECT AdminId, FullName, Username, Password, Email 
                                FROM Admin ORDER BY Username";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvAdmins.DataSource = dt;

                if (dgvAdmins.Columns.Count > 0)
                {
                    dgvAdmins.Columns["AdminId"].HeaderText = "ID";
                    dgvAdmins.Columns["FullName"].HeaderText = "Full Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admins: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["TeacherId"].Value);
            string currentEmail = dgvTeachers.SelectedRows[0].Cells["Username"].Value?.ToString() ?? "";
            string currentPhone = dgvTeachers.SelectedRows[0].Cells["Password"].Value?.ToString() ?? "";
            string teacherName = dgvTeachers.SelectedRows[0].Cells["TeacherName"].Value?.ToString() ?? "";

            using (CredentialEditForm editForm = new CredentialEditForm("Teacher", teacherName, currentEmail, currentPhone))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string query = "UPDATE Teachers SET Email = @Email, Phone = @Phone WHERE TeacherId = @TeacherId";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@TeacherId", teacherId),
                            new SqlParameter("@Email", editForm.NewUsername),
                            new SqlParameter("@Phone", editForm.NewPassword)
                        };

                        int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                        if (result > 0)
                        {
                            MessageBox.Show("Teacher credentials updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating teacher: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentId"].Value);
            string currentEmail = dgvStudents.SelectedRows[0].Cells["Username"].Value?.ToString() ?? "";
            string currentPhone = dgvStudents.SelectedRows[0].Cells["Password"].Value?.ToString() ?? "";
            string studentName = dgvStudents.SelectedRows[0].Cells["StudentName"].Value?.ToString() ?? "";

            using (CredentialEditForm editForm = new CredentialEditForm("Student", studentName, currentEmail, currentPhone))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string query = "UPDATE Students SET Email = @Email, Phone = @Phone WHERE StudentId = @StudentId";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@StudentId", studentId),
                            new SqlParameter("@Email", editForm.NewUsername),
                            new SqlParameter("@Phone", editForm.NewPassword)
                        };

                        int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                        if (result > 0)
                        {
                            MessageBox.Show("Student credentials updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudents();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating student: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int adminId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["AdminId"].Value);
            string currentUsername = dgvAdmins.SelectedRows[0].Cells["Username"].Value?.ToString() ?? "";
            string currentPassword = dgvAdmins.SelectedRows[0].Cells["Password"].Value?.ToString() ?? "";
            string fullName = dgvAdmins.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "";

            using (CredentialEditForm editForm = new CredentialEditForm("Admin", fullName, currentUsername, currentPassword))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string query = "UPDATE Admin SET Username = @Username, Password = @Password WHERE AdminId = @AdminId";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@AdminId", adminId),
                            new SqlParameter("@Username", editForm.NewUsername),
                            new SqlParameter("@Password", editForm.NewPassword)
                        };

                        int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                        if (result > 0)
                        {
                            MessageBox.Show("Admin credentials updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAdmins();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating admin: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            using (CredentialEditForm editForm = new CredentialEditForm("New Admin", "", "", "", true))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string query = @"INSERT INTO Admin (Username, Password, FullName, Email) 
                                        VALUES (@Username, @Password, @FullName, @Email)";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@Username", editForm.NewUsername),
                            new SqlParameter("@Password", editForm.NewPassword),
                            new SqlParameter("@FullName", editForm.FullName),
                            new SqlParameter("@Email", editForm.Email)
                        };

                        int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                        if (result > 0)
                        {
                            MessageBox.Show("New admin added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAdmins();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding admin: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmins.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvAdmins.Rows.Count <= 1)
            {
                MessageBox.Show("Cannot delete the last admin account!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int adminId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["AdminId"].Value);
            string username = dgvAdmins.SelectedRows[0].Cells["Username"].Value?.ToString() ?? "";

            DialogResult result = MessageBox.Show($"Are you sure you want to delete admin '{username}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Admin WHERE AdminId = @AdminId";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@AdminId", adminId)
                    };

                    int deleteResult = DatabaseHelper.ExecuteNonQuery(query, parameters);
                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Admin deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdmins();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting admin: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadStudents();
            LoadAdmins();
            MessageBox.Show("Data refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Helper form for editing credentials
    public class CredentialEditForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
        private bool isNewAdmin;

        public string NewUsername { get; private set; }
        public string NewPassword { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }

        public CredentialEditForm(string userType, string name, string username, string password, bool isNew = false)
        {
            this.isNewAdmin = isNew;
            InitializeForm(userType, name, username, password);
        }

        private void InitializeForm(string userType, string name, string username, string password)
        {
            this.Text = isNewAdmin ? "Add New Admin" : $"Edit {userType} Credentials - {name}";
            this.Size = new Size(400, isNewAdmin ? 280 : 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int yPos = 20;

            if (isNewAdmin)
            {
                Label lblFullName = new Label { Text = "Full Name:", Location = new Point(20, yPos), Size = new Size(100, 25) };
                txtFullName = new TextBox { Location = new Point(130, yPos), Size = new Size(230, 25) };
                this.Controls.Add(lblFullName);
                this.Controls.Add(txtFullName);
                yPos += 35;

                Label lblEmail = new Label { Text = "Email:", Location = new Point(20, yPos), Size = new Size(100, 25) };
                txtEmail = new TextBox { Location = new Point(130, yPos), Size = new Size(230, 25) };
                this.Controls.Add(lblEmail);
                this.Controls.Add(txtEmail);
                yPos += 35;
            }

            Label lblUsername = new Label
            {
                Text = userType == "Admin" ? "Username:" : "Email (Username):",
                Location = new Point(20, yPos),
                Size = new Size(110, 25)
            };
            txtUsername = new TextBox { Text = username, Location = new Point(130, yPos), Size = new Size(230, 25) };
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            yPos += 35;

            Label lblPassword = new Label
            {
                Text = userType == "Admin" ? "Password:" : "Phone (Password):",
                Location = new Point(20, yPos),
                Size = new Size(110, 25)
            };
            txtPassword = new TextBox { Text = password, Location = new Point(130, yPos), Size = new Size(230, 25) };
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            yPos += 45;

            btnSave = new Button
            {
                Text = "Save",
                Location = new Point(130, yPos),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(39, 174, 96),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(240, yPos),
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(149, 165, 166),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password are required!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isNewAdmin && (string.IsNullOrWhiteSpace(txtFullName.Text)))
            {
                MessageBox.Show("Full Name is required!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewUsername = txtUsername.Text.Trim();
            NewPassword = txtPassword.Text.Trim();
            if (isNewAdmin)
            {
                FullName = txtFullName.Text.Trim();
                Email = txtEmail?.Text.Trim() ?? "";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
