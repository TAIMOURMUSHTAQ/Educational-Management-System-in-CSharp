using System;
using System.Windows.Forms;

namespace EducationalManagementSystem
{
    /// <summary>
    /// Main entry point for Educational Management System
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
