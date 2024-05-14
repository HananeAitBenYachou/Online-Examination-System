using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Administrator.People.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static OnlineExamination_BusinessLayer.Student;

namespace OnlineExaminationSystem.Administrator.Students
{
    public partial class FrmAddUpdateStudent : Form
    {
        private enum EnMode : byte { AddNew, Update };
        private EnMode _mode;

        private int? _studentID = null;
        private Student _student = null;
        private int? _personID = null;

        public FrmAddUpdateStudent(int? studentID)
        {
            InitializeComponent();
            _studentID = studentID;
            _mode = EnMode.Update;
        }
        public FrmAddUpdateStudent()
        {
            InitializeComponent();
            _mode = EnMode.AddNew;
        }

        private void FrmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            Reset();

            if (_mode == EnMode.Update)
                LoadStudentData();
        }

        private bool SaveStudentData()
        {
            UpdateStudentData();

            if (!_student.Save())
            {
                ShowErrorMessage("Student data is not saved successfully.");
                return false;
            }

            else
            {
                ShowSuccessMessage("Student data saved successfully !");
                UpdateFormForSavedStudent();
                return true;
            }
        }

        private void UpdateFormForSavedStudent()
        {
            _mode = EnMode.Update;

            _studentID = _student.StudentID;
            txtStudentID.Text = _studentID.ToString();

            ucPersonCardWithFilter1.FilterEnabled = false;
        }

        private void UpdateStudentData()
        {
            _student.PersonID = _personID.Value;
            _student.StartDate = dtpStartDate.Value;
            _student.GraduationDate = dtpGraduationDate.Value;
            _student.IsMarkedForDelete = _mode == EnMode.AddNew ? false : _student.IsMarkedForDelete;
            _student.TrackID = Track.Find(cbTracks.Text).TrackID;       
        }

        private void LoadStudentData()
        {
            _student = Student.Find(_studentID);

            if (_student == null)
            {
                ShowErrorMessage($"No student with ID = {_studentID} was found in the system !");
                this.Close();
                return;
            }

            PopulateFormFieldsWithStudentData();
        }

        private void PopulateComboBoxWithTracks()
        {
            var trackNames = Track.GetAllTracks().AsEnumerable().Select(row => row["Track Name"]).ToArray();

            cbTracks.Items.AddRange(trackNames);

            cbTracks.SelectedIndex = 0;
        }

        private void PopulateFormFieldsWithStudentData()
        {
            ucPersonCardWithFilter1.LoadPersonData(_student.PersonID);

            txtStudentID.Text = _studentID.ToString();
            dtpStartDate.Value = _student.StartDate;
            dtpGraduationDate.Value = _student.GraduationDate;
            cbTracks.SelectedIndex = cbTracks.FindString(_student.TrackInfo.Name);
        }

        private void UpdateFormState()
        {
            lblTitle.Text = _mode == EnMode.AddNew ? "Add New Student" : "Update Student";
            btnNext.Enabled = _mode == EnMode.Update;
            btnSave.Enabled = _mode == EnMode.Update;
            tpAcademicInfo.Enabled = _mode == EnMode.Update;
            ucPersonCardWithFilter1.FilterEnabled = _mode != EnMode.Update;
        }

        private void Reset()
        {
            PopulateComboBoxWithTracks();

            dtpStartDate.Value = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now;
            dtpGraduationDate.Value = dtpStartDate.Value.AddYears(1);

            ucPersonCardWithFilter1.PersonSelected += PersonSelectedEventHandler;

            if (_mode == EnMode.AddNew)
                _student = new Student();

            UpdateFormState();
        }

        private void PersonSelectedEventHandler(object sender, int? personID)
        {
            if (personID == null)        
                btnNext.Enabled = false;
            
            else if (_mode == EnMode.AddNew && Student.DoesStudentExist(personID, EnFilterBy.PersonID))
            {
                ShowErrorMessage("The person selected is already linked with another student , please select another one !");
                btnNext.Enabled = false;
            }

            else
            {
                _personID = personID.Value;
                btnNext.Enabled = true;
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                ShowErrorMessage("Some fields are not valid. Please check the red icon(s) for details.");
                return;
            }

            SaveStudentData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tcStudentInfo.SelectedTab = tpAcademicInfo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_EnabledChanged(object sender, EventArgs e)
        {
            tpAcademicInfo.Enabled = btnNext.Enabled;
            btnSave.Enabled = btnNext.Enabled;
        }

        private void DtpGraduationDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpGraduationDate.Value <= dtpStartDate.Value)
                SetValidationError(dtpGraduationDate, e, "Graduation date is not valid !");
            else
                ClearValidationError(dtpGraduationDate, e);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetValidationError(Control control, System.ComponentModel.CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            control.Focus();
            errorProvider1.SetError(control, errorMessage);
        }

        private void ClearValidationError(Control control, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider1.SetError(control, null);
        }

    }
}
