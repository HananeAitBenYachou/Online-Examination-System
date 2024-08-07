﻿using OnlineExaminationSystem.Administrator.Instructors;
using OnlineExaminationSystem.Administrator_system.Users;
using OnlineExaminationSystem.Instructor_system.Exams;
using OnlineExaminationSystem.Instructor_system.Questions;
using OnlineExaminationSystem.Login;
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

            Application.Run(new FrmLogin());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
