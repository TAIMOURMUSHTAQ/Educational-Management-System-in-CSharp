using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using EducationalManagementSystem.Utilities;

namespace EducationalManagementSystem
{
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            LoadTimetable();
            LoadTeachers();
            ClearFields();

            // Populate combo boxes
            cmbClass.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbSection.Items.AddRange(new string[] { "A", "B", "C", "D" });
            cmbDay.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cmbSubject.Items.AddRange(new string[] { "Mathematics", "English", "Science", "Physics", "Chemistry", "Biology", "Computer Science", "History", "Geography", "Economics", "Urdu", "Islamiat", "Arts", "Physical Education" });

            cmbFilterClass.Items.AddRange(new string[] { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbFilterDay.Items.AddRange(new string[] { "All", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            cmbFilterClass.SelectedIndex = 0;
            cmbFilterDay.SelectedIndex = 0;
        }

        private void LoadTeachers()
        {
            try
            {
                string query = "SELECT TeacherId, TeacherName FROM Teachers ORDER BY TeacherName";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                cmbTeacher.DataSource = dt;
                cmbTeacher.DisplayMember = "TeacherName";
                cmbTeacher.ValueMember = "TeacherId";
                cmbTeacher.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTimetable()
        {
            try
            {
                string query = @"SELECT t.TimetableId, t.Class, t.Section, t.Day, t.Subject, 
                                tc.TeacherName, t.StartTime, t.EndTime 
                                FROM Timetable t 
                                LEFT JOIN Teachers tc ON t.TeacherId = tc.TeacherId 
                                ORDER BY t.Class, t.Section, 
                                CASE t.Day 
                                    WHEN 'Monday' THEN 1 
                                    WHEN 'Tuesday' THEN 2 
                                    WHEN 'Wednesday' THEN 3 
                                    WHEN 'Thursday' THEN 4 
                                    WHEN 'Friday' THEN 5 
                                    WHEN 'Saturday' THEN 6 
                                END, t.StartTime";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvTimetable.DataSource = dt;

                // Format columns
                if (dgvTimetable.Columns.Count > 0)
                {
                    dgvTimetable.Columns["TimetableId"].HeaderText = "ID";
                    dgvTimetable.Columns["TeacherName"].HeaderText = "Teacher";
                    dgvTimetable.Columns["StartTime"].HeaderText = "Start Time";
                    dgvTimetable.Columns["EndTime"].HeaderText = "End Time";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading timetable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTimetableId.Clear();
            cmbClass.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;
            dtpStartTime.Value = DateTime.Today.AddHours(8);
            dtpEndTime.Value = DateTime.Today.AddHours(9);
        }

        private bool ValidateInput()
        {
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }
            if (cmbSection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a section!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSection.Focus();
                return false;
            }
            if (cmbDay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a day!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDay.Focus();
                return false;
            }
            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
                return false;
            }
            if (dtpEndTime.Value <= dtpStartTime.Value)
            {
                MessageBox.Show("End time must be after start time!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                int? teacherId = cmbTeacher.SelectedValue != null ? (int?)Convert.ToInt32(cmbTeacher.SelectedValue) : null;

                string query = @"INSERT INTO Timetable (Class, Section, Day, Subject, TeacherId, StartTime, EndTime) 
                                VALUES (@Class, @Section, @Day, @Subject, @TeacherId, @StartTime, @EndTime)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Class", cmbClass.SelectedItem.ToString()),
                    new SqlParameter("@Section", cmbSection.SelectedItem.ToString()),
                    new SqlParameter("@Day", cmbDay.SelectedItem.ToString()),
                    new SqlParameter("@Subject", cmbSubject.SelectedItem.ToString()),
                    new SqlParameter("@TeacherId", teacherId.HasValue ? (object)teacherId.Value : DBNull.Value),
                    new SqlParameter("@StartTime", dtpStartTime.Value.TimeOfDay),
                    new SqlParameter("@EndTime", dtpEndTime.Value.TimeOfDay)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Timetable entry added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTimetable();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding timetable entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimetableId.Text))
            {
                MessageBox.Show("Please select a timetable entry to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                int? teacherId = cmbTeacher.SelectedValue != null ? (int?)Convert.ToInt32(cmbTeacher.SelectedValue) : null;

                string query = @"UPDATE Timetable SET 
                                Class = @Class, 
                                Section = @Section, 
                                Day = @Day, 
                                Subject = @Subject, 
                                TeacherId = @TeacherId, 
                                StartTime = @StartTime, 
                                EndTime = @EndTime 
                                WHERE TimetableId = @TimetableId";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TimetableId", int.Parse(txtTimetableId.Text)),
                    new SqlParameter("@Class", cmbClass.SelectedItem.ToString()),
                    new SqlParameter("@Section", cmbSection.SelectedItem.ToString()),
                    new SqlParameter("@Day", cmbDay.SelectedItem.ToString()),
                    new SqlParameter("@Subject", cmbSubject.SelectedItem.ToString()),
                    new SqlParameter("@TeacherId", teacherId.HasValue ? (object)teacherId.Value : DBNull.Value),
                    new SqlParameter("@StartTime", dtpStartTime.Value.TimeOfDay),
                    new SqlParameter("@EndTime", dtpEndTime.Value.TimeOfDay)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Timetable entry updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTimetable();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating timetable entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimetableId.Text))
            {
                MessageBox.Show("Please select a timetable entry to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this timetable entry?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Timetable WHERE TimetableId = @TimetableId";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@TimetableId", int.Parse(txtTimetableId.Text))
                    };

                    int deleteResult = DatabaseHelper.ExecuteNonQuery(query, parameters);
                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Timetable entry deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTimetable();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting timetable entry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string classFilter = cmbFilterClass.SelectedItem?.ToString() ?? "All";
                string dayFilter = cmbFilterDay.SelectedItem?.ToString() ?? "All";

                string query = @"SELECT t.TimetableId, t.Class, t.Section, t.Day, t.Subject, 
                                tc.TeacherName, t.StartTime, t.EndTime 
                                FROM Timetable t 
                                LEFT JOIN Teachers tc ON t.TeacherId = tc.TeacherId 
                                WHERE 1=1";

                if (classFilter != "All")
                    query += " AND t.Class = @Class";
                if (dayFilter != "All")
                    query += " AND t.Day = @Day";

                query += @" ORDER BY t.Class, t.Section, 
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
                    new SqlParameter("@Class", classFilter),
                    new SqlParameter("@Day", dayFilter)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvTimetable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTimetable.Rows[e.RowIndex];
                txtTimetableId.Text = row.Cells["TimetableId"].Value.ToString();

                cmbClass.SelectedItem = row.Cells["Class"].Value?.ToString();
                cmbSection.SelectedItem = row.Cells["Section"].Value?.ToString();
                cmbDay.SelectedItem = row.Cells["Day"].Value?.ToString();
                cmbSubject.SelectedItem = row.Cells["Subject"].Value?.ToString();

                // Find teacher by name
                string teacherName = row.Cells["TeacherName"].Value?.ToString();
                if (!string.IsNullOrEmpty(teacherName))
                {
                    for (int i = 0; i < cmbTeacher.Items.Count; i++)
                    {
                        DataRowView drv = cmbTeacher.Items[i] as DataRowView;
                        if (drv != null && drv["TeacherName"].ToString() == teacherName)
                        {
                            cmbTeacher.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    cmbTeacher.SelectedIndex = -1;
                }

                if (row.Cells["StartTime"].Value != DBNull.Value)
                {
                    TimeSpan startTime = (TimeSpan)row.Cells["StartTime"].Value;
                    dtpStartTime.Value = DateTime.Today.Add(startTime);
                }
                if (row.Cells["EndTime"].Value != DBNull.Value)
                {
                    TimeSpan endTime = (TimeSpan)row.Cells["EndTime"].Value;
                    dtpEndTime.Value = DateTime.Today.Add(endTime);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
