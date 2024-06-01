using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static OnlineExamination_BusinessLayer.Student;

namespace OnlineExaminationSystem.Administrator.Students
{
    public partial class FrmAddUpdateStudent : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _studentID = null;
        private Student _student = null;
        private int? _personID = null;

        public FrmAddUpdateStudent(int? studentID)
        {
            InitializeComponent();
            _studentID = studentID;
            _mode = Mode.Update;
        }
        public FrmAddUpdateStudent()
        {
            InitializeComponent();
            _mode = Mode.AddNew;
        }

        private void FrmAddUpdateStudent_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadStudentData();
        }

        private bool SaveStudentData()
        {
            UpdateStudentData();

            if (!_student.Save())
            {
                FormUtilities.ShowMessage("Student data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Student data saved successfully !", MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;

            _studentID = _student.StudentID;
            txtStudentID.Text = _studentID.ToString();

            ucPersonCardWithFilter1.FilterEnabled = false;
        }

        private void UpdateStudentData()
        {
            _student.PersonID = _personID.Value;
            _student.StartDate = dtpStartDate.Value;
            _student.GraduationDate = dtpGraduationDate.Value;
            _student.IsMarkedForDelete = _mode == Mode.AddNew ? false : _student.IsMarkedForDelete;
            _student.TrackID = Track.Find(cbTracks.Text).TrackID;
        }

        private void LoadStudentData()
        {
            _student = Student.Find(_studentID, FindByOption.StudentID);

            if (_student == null)
            {
                FormUtilities.ShowMessage($"No student with ID = {_studentID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayStudentData();
        }

        private void PopulateComboBoxWithTracks()
        {
            var trackNames = Track.GetAllTracks().AsEnumerable().Select(row => row["Track Name"]).ToArray();

            cbTracks.Items.AddRange(trackNames);

            cbTracks.SelectedIndex = 0;
        }

        private void DisplayStudentData()
        {
            ucPersonCardWithFilter1.LoadPersonData(_student.PersonID);

            txtStudentID.Text = _studentID.ToString();
            dtpStartDate.Value = _student.StartDate;
            dtpGraduationDate.Value = _student.GraduationDate;
            cbTracks.SelectedIndex = cbTracks.FindString(_student.TrackInfo.Name);
        }

        private void UpdateFormState()
        {
            lblTitle.Text = _mode == Mode.AddNew ? "Add New Student" : "Update Student";
            btnNext.Enabled = _mode == Mode.Update;
            btnSave.Enabled = _mode == Mode.Update;
            tpAcademicInfo.Enabled = _mode == Mode.Update;
            ucPersonCardWithFilter1.FilterEnabled = _mode != Mode.Update;
        }

        private void InitializeForm()
        {
            PopulateComboBoxWithTracks();

            dtpStartDate.Value = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now;
            dtpGraduationDate.Value = dtpStartDate.Value.AddYears(1);

            ucPersonCardWithFilter1.PersonSelected += PersonSelectedEventHandler;

            if (_mode == Mode.AddNew)
                _student = new Student();

            UpdateFormState();
        }

        private void PersonSelectedEventHandler(object sender, int? personID)
        {
            if (personID == null)
                btnNext.Enabled = false;

            else if (_mode == Mode.AddNew && Student.DoesStudentExist(personID, FindByOption.PersonID))
            {
                FormUtilities.ShowMessage("The person selected is already linked with another student , please select another one !", MessageBoxIcon.Error);
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
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
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
            Close();
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
