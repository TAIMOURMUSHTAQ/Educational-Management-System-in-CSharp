using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class TeacherManagementForm : Form
    {
        public TeacherManagementForm()
        {
            InitializeComponent();
        }

        private void TeacherManagementForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            ClearFields();

            // Populate combo boxes
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbSubject.Items.AddRange(new string[] { "Mathematics", "English", "Science", "Physics", "Chemistry", "Biology", "Computer Science", "History", "Geography", "Economics", "Urdu", "Islamiat", "Arts" });
        }

        private void LoadTeachers()
        {
            try
            {
                string query = "SELECT TeacherId, TeacherName, Email, Phone, Address, Gender, Subject, Qualification, Salary, JoiningDate FROM Teachers ORDER BY TeacherId DESC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvTeachers.DataSource = dt;

                // Format columns
                if (dgvTeachers.Columns.Count > 0)
                {
                    dgvTeachers.Columns["TeacherId"].HeaderText = "ID";
                    dgvTeachers.Columns["TeacherName"].HeaderText = "Teacher Name";
                    dgvTeachers.Columns["JoiningDate"].HeaderText = "Joining Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTeacherId.Clear();
            txtTeacherName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtQualification.Clear();
            txtSalary.Clear();
            dtpJoiningDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            txtTeacherName.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text))
            {
                MessageBox.Show("Please enter teacher name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherName.Focus();
                return false;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }
            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                decimal salary = 0;
                decimal.TryParse(txtSalary.Text, out salary);

                string query = @"INSERT INTO Teachers (TeacherName, Email, Phone, Address, Gender, Subject, Qualification, Salary, JoiningDate) 
                                VALUES (@TeacherName, @Email, @Phone, @Address, @Gender, @Subject, @Qualification, @Salary, @JoiningDate)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TeacherName", txtTeacherName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@Gender", cmbGender.SelectedItem.ToString()),
                    new SqlParameter("@Subject", cmbSubject.SelectedItem.ToString()),
                    new SqlParameter("@Qualification", txtQualification.Text.Trim()),
                    new SqlParameter("@Salary", salary),
                    new SqlParameter("@JoiningDate", dtpJoiningDate.Value.Date)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeacherId.Text))
            {
                MessageBox.Show("Please select a teacher to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                decimal salary = 0;
                decimal.TryParse(txtSalary.Text, out salary);

                string query = @"UPDATE Teachers SET 
                                TeacherName = @TeacherName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address, 
                                Gender = @Gender, 
                                Subject = @Subject, 
                                Qualification = @Qualification, 
                                Salary = @Salary, 
                                JoiningDate = @JoiningDate 
                                WHERE TeacherId = @TeacherId";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TeacherId", int.Parse(txtTeacherId.Text)),
                    new SqlParameter("@TeacherName", txtTeacherName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@Gender", cmbGender.SelectedItem.ToString()),
                    new SqlParameter("@Subject", cmbSubject.SelectedItem.ToString()),
                    new SqlParameter("@Qualification", txtQualification.Text.Trim()),
                    new SqlParameter("@Salary", salary),
                    new SqlParameter("@JoiningDate", dtpJoiningDate.Value.Date)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Teacher updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeacherId.Text))
            {
                MessageBox.Show("Please select a teacher to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Teachers WHERE TeacherId = @TeacherId";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@TeacherId", int.Parse(txtTeacherId.Text))
                    };

                    int deleteResult = DatabaseHelper.ExecuteNonQuery(query, parameters);
                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Teacher deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeachers();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadTeachers();
                    return;
                }

                string query = @"SELECT TeacherId, TeacherName, Email, Phone, Address, Gender, Subject, Qualification, Salary, JoiningDate 
                                FROM Teachers 
                                WHERE TeacherName LIKE @Search OR Email LIKE @Search OR Phone LIKE @Search OR Subject LIKE @Search
                                ORDER BY TeacherId DESC";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Search", "%" + searchText + "%")
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvTeachers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                txtTeacherId.Text = row.Cells["TeacherId"].Value.ToString();
                txtTeacherName.Text = row.Cells["TeacherName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtQualification.Text = row.Cells["Qualification"].Value?.ToString() ?? "";
                txtSalary.Text = row.Cells["Salary"].Value?.ToString() ?? "";

                if (row.Cells["JoiningDate"].Value != DBNull.Value)
                    dtpJoiningDate.Value = Convert.ToDateTime(row.Cells["JoiningDate"].Value);

                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
                cmbSubject.SelectedItem = row.Cells["Subject"].Value?.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
