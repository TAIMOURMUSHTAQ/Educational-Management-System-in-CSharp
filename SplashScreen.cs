using System;
using System.Drawing;
using System.Windows.Forms;

namespace EducationalManagementSystem
{
    public partial class SplashScreen : Form
    {
        private Timer timer;
        private int progressValue = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Initialize the timer for progress bar animation
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Load logo if exists
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
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressValue += 2;
            progressBar.Value = Math.Min(progressValue, 100);

            // Update loading text
            if (progressValue < 30)
                lblLoading.Text = "Loading resources...";
            else if (progressValue < 60)
                lblLoading.Text = "Initializing database...";
            else if (progressValue < 90)
                lblLoading.Text = "Preparing application...";
            else
                lblLoading.Text = "Almost ready...";

            if (progressValue >= 100)
            {
                timer.Stop();
                timer.Dispose();

                // Open Welcome Screen
                WelcomeScreen welcomeScreen = new WelcomeScreen();
                welcomeScreen.Show();
                this.Hide();
            }
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}
