using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.Courses
{
    public partial class FrmAddUpdateCourse : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _courseID = null;
        private Course _course = null;

        private const int _minCredits = 1;
        private const int _maxCredits = 6;

        public FrmAddUpdateCourse(int? courseID)
        {
            InitializeComponent();
            _courseID = courseID;
            _mode = Mode.Update;
        }
        public FrmAddUpdateCourse()
        {
            InitializeComponent();
            _mode = Mode.AddNew;
        }

        private void FrmAddUpdateCourse_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadCourseData();
        }

        private void InitializeForm()
        {
            if (_mode == Mode.AddNew)
                _course = new Course();

            lblTitle.Text = _mode == Mode.AddNew ? "Add New Course" : "Update Course";
        }

        private void LoadCourseData()
        {
            _course = Course.Find(_courseID);

            if (_course == null)
            {
                FormUtilities.ShowMessage($"No course with ID = {_courseID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayCourseData();
        }

        private void DisplayCourseData()
        {
            txtCourseID.Text = _courseID.ToString();
            txtName.Text = _course.Name;
            txtDescription.Text = _course.Description ?? string.Empty;
            txtPrerequisites.Text = _course.Prerequisites ?? string.Empty;
            txtCredits.Text = _course.Credits.ToString();
            txtDuration.Text = _course.Duration.ToString();
        }

        private bool SaveCourseData()
        {
            UpdateCourseData();

            if (!_course.Save())
            {
                FormUtilities.ShowMessage("Course data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Course data saved successfully !", MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateCourseData()
        {
            _course.Name = txtName.Text.Trim();
            _course.Prerequisites = string.IsNullOrWhiteSpace(txtPrerequisites.Text) ? null : txtPrerequisites.Text.Trim();
            _course.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim();
            _course.Credits = float.Parse(txtCredits.Text, NumberStyles.Float, CultureInfo.InvariantCulture);
            _course.Duration = short.Parse(txtDuration.Text);
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _courseID = _course.CourseID;
            txtCourseID.Text = _courseID.ToString();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            SaveCourseData();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                SetValidationError(txtName, e, "This field is required !");

            else if (_course.Name != txtName.Text && Course.DoesCourseExist(txtName.Text))
                SetValidationError(txtName, e, "A course with the same name already exists!");

            else
                ClearValidationError(txtName, e);
        }

        private void TxtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDuration.Text))
                SetValidationError(txtDuration, e, "This field is required !");

            else if (Convert.ToInt16(txtDuration.Text) < 1)
                SetValidationError(txtDuration, e, "course duration must be greater than 0 (hours)");

            else
                ClearValidationError(txtDuration, e);
        }

        private void TxtCredits_Validating(object sender, CancelEventArgs e)
        {
            float credits = float.Parse(txtCredits.Text, NumberStyles.Float, CultureInfo.InvariantCulture);

            if (string.IsNullOrWhiteSpace(txtCredits.Text))
                SetValidationError(txtCredits, e, "This field is required !");

            else if (credits < 1 || credits > 6)
                SetValidationError(txtCredits, e, $"course credits must be between {_minCredits} and {_maxCredits}");

            else
                ClearValidationError(txtCredits, e);
        }

        private void TxtCredits_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
