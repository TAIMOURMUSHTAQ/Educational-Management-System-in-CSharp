using System;
using System.Drawing;
using System.Windows.Forms;

namespace EducationalManagementSystem
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            // Load logo if exists
            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\icon.png");
                if (System.IO.File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }

                // Load role images
                string adminPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\admin.png");
                string teacherPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\teacher.png");
                string studentPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\student.png");

                if (System.IO.File.Exists(adminPath))
                {
                    picAdmin.Image = Image.FromFile(adminPath);
                    picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (System.IO.File.Exists(teacherPath))
                {
                    picTeacher.Image = Image.FromFile(teacherPath);
                    picTeacher.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (System.IO.File.Exists(studentPath))
                {
                    picStudent.Image = Image.FromFile(studentPath);
                    picStudent.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            RoleLoginForm loginForm = new RoleLoginForm("Admin");
            loginForm.Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            RoleLoginForm loginForm = new RoleLoginForm("Teacher");
            loginForm.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            RoleLoginForm loginForm = new RoleLoginForm("Student");
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
