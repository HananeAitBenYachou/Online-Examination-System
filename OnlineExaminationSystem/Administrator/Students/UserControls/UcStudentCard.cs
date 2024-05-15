using Guna.UI2.WinForms;
using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace OnlineExaminationSystem.Administrator.Students.UserControls
{
    public partial class UcStudentCard : UserControl
    {
        public enum EnLoadBy : byte { PersonID , StudentID }
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        public int? StudentID { get; private set; } = null;
        public Student Student { get; private set; } = null;

        public UcStudentCard()
        {
            InitializeComponent();
        }

        private void LoadStudentData()
        {
            StudentID = Student.StudentID;

            ucPersonCard1.LoadPersonData(Student.PersonID);

            txtStudentID.Text = StudentID.ToString();
            txtTrackName.Text = Student.TrackInfo.Name;
            dtpStartDate.Value = Student.GraduationDate;
            dtpGraduationDate.Value = Student.GraduationDate;
        }

        public bool LoadStudentData(int? value , EnLoadBy loadBy)
        {
            switch(loadBy)
            {
                case EnLoadBy.PersonID:
                    Student = Student.Find(value, Student.EnFilterBy.PersonID);
                    break;

                case EnLoadBy.StudentID:
                    Student = Student.Find(value, Student.EnFilterBy.StudentID);
                    break;
            }

            if (Student == null)
            {
                ShowErrorMessage($"No student with ID = {value} was found in the system !");
                return false;
            }

            LoadStudentData();
            return true;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
