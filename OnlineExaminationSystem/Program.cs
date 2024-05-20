using OnlineExaminationSystem.Administrator;
using OnlineExaminationSystem.Administrator.Courses;
using OnlineExaminationSystem.Administrator.Instructors;
using OnlineExaminationSystem.Administrator.Instructors.UserControls;
using OnlineExaminationSystem.Administrator.People;
using OnlineExaminationSystem.Administrator.Students;
using OnlineExaminationSystem.Administrator.TrackCourses;
using OnlineExaminationSystem.Administrator.Tracks;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int? ID = 1;
            Application.Run(new FrmShowInstructorInfo(ID));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
