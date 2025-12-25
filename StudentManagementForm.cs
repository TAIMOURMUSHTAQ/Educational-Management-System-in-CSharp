using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            ClearFields();

            // Populate combo boxes
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmbClass.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbSection.Items.AddRange(new string[] { "A", "B", "C", "D" });
        }

        private void LoadStudents()
        {
            try
            {
                string query = "SELECT StudentId, StudentName, FatherName, Email, Phone, Address, DateOfBirth, Gender, Class, Section, AdmissionDate FROM Students ORDER BY StudentId DESC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvStudents.DataSource = dt;

                // Format columns
                if (dgvStudents.Columns.Count > 0)
                {
                    dgvStudents.Columns["StudentId"].HeaderText = "ID";
                    dgvStudents.Columns["StudentName"].HeaderText = "Student Name";
                    dgvStudents.Columns["FatherName"].HeaderText = "Father Name";
                    dgvStudents.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                    dgvStudents.Columns["AdmissionDate"].HeaderText = "Admission Date";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-15);
            dtpAdmissionDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            txtStudentName.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter student name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                MessageBox.Show("Please enter father name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFatherName.Focus();
                return false;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return false;
            }
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select class!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }
            if (cmbSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select section!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSection.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                string query = @"INSERT INTO Students (StudentName, FatherName, Email, Phone, Address, DateOfBirth, Gender, Class, Section, AdmissionDate) 
                                VALUES (@StudentName, @FatherName, @Email, @Phone, @Address, @DateOfBirth, @Gender, @Class, @Section, @AdmissionDate)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@StudentName", txtStudentName.Text.Trim()),
                    new SqlParameter("@FatherName", txtFatherName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.Date),
                    new SqlParameter("@Gender", cmbGender.SelectedItem.ToString()),
                    new SqlParameter("@Class", cmbClass.SelectedItem.ToString()),
                    new SqlParameter("@Section", cmbSection.SelectedItem.ToString()),
                    new SqlParameter("@AdmissionDate", dtpAdmissionDate.Value.Date)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text))
            {
                MessageBox.Show("Please select a student to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                string query = @"UPDATE Students SET 
                                StudentName = @StudentName, 
                                FatherName = @FatherName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address, 
                                DateOfBirth = @DateOfBirth, 
                                Gender = @Gender, 
                                Class = @Class, 
                                Section = @Section, 
                                AdmissionDate = @AdmissionDate 
                                WHERE StudentId = @StudentId";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@StudentId", int.Parse(txtStudentId.Text)),
                    new SqlParameter("@StudentName", txtStudentName.Text.Trim()),
                    new SqlParameter("@FatherName", txtFatherName.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Phone", txtPhone.Text.Trim()),
                    new SqlParameter("@Address", txtAddress.Text.Trim()),
                    new SqlParameter("@DateOfBirth", dtpDateOfBirth.Value.Date),
                    new SqlParameter("@Gender", cmbGender.SelectedItem.ToString()),
                    new SqlParameter("@Class", cmbClass.SelectedItem.ToString()),
                    new SqlParameter("@Section", cmbSection.SelectedItem.ToString()),
                    new SqlParameter("@AdmissionDate", dtpAdmissionDate.Value.Date)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text))
            {
                MessageBox.Show("Please select a student to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Students WHERE StudentId = @StudentId";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@StudentId", int.Parse(txtStudentId.Text))
                    };

                    int deleteResult = DatabaseHelper.ExecuteNonQuery(query, parameters);
                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    LoadStudents();
                    return;
                }

                string query = @"SELECT StudentId, StudentName, FatherName, Email, Phone, Address, DateOfBirth, Gender, Class, Section, AdmissionDate 
                                FROM Students 
                                WHERE StudentName LIKE @Search OR FatherName LIKE @Search OR Email LIKE @Search OR Phone LIKE @Search OR Class LIKE @Search
                                ORDER BY StudentId DESC";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Search", "%" + searchText + "%")
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentId.Text = row.Cells["StudentId"].Value.ToString();
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                txtFatherName.Text = row.Cells["FatherName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";

                if (row.Cells["DateOfBirth"].Value != DBNull.Value)
                    dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

                if (row.Cells["AdmissionDate"].Value != DBNull.Value)
                    dtpAdmissionDate.Value = Convert.ToDateTime(row.Cells["AdmissionDate"].Value);

                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
                cmbClass.SelectedItem = row.Cells["Class"].Value?.ToString();
                cmbSection.SelectedItem = row.Cells["Section"].Value?.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
