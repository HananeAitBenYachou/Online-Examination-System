using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using static OnlineExamination_BusinessLayer.Instructor;

namespace OnlineExaminationSystem.Administrator.Instructors
{
    public partial class FrmAddUpdateInstructor : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _instructorID = null;
        private Instructor _instructor = null;
        private int? _personID = null;

        private readonly DateTime _maximumHireDateAllowed = DateTime.Now;
        private readonly DateTime _minimumHireDateAllowed = DateTime.Now.AddYears(-30);

        public FrmAddUpdateInstructor(int? instructorID)
        {
            InitializeComponent();
            _instructorID = instructorID;
            _mode = Mode.Update;
        }
        public FrmAddUpdateInstructor()
        {
            InitializeComponent();
            _mode = Mode.AddNew;
        }

        private void FrmAddUpdateInstructor_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadInstructorData();
        }

        private bool SaveInstructorData()
        {
            UpdateInstructorData();

            if (!_instructor.Save())
            {
                FormUtilities.ShowMessage("Instructor data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Instructor data saved successfully !", MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;

            _instructorID = _instructor.InstructorID;
            txtInstructorID.Text = _instructorID.ToString();

            ucPersonCardWithFilter1.FilterEnabled = false;
        }

        private void UpdateInstructorData()
        {
            _instructor.PersonID = _personID.Value;
            _instructor.HireDate = dtpHireDate.Value;
            _instructor.MonthlySalary = float.Parse(txtMonthlySalary.Text, NumberStyles.Float, CultureInfo.InvariantCulture);
            _instructor.IsMarkedForDelete = _mode == Mode.AddNew ? false : _instructor.IsMarkedForDelete;
            _instructor.ExitDate = ckbIsStillEmployed.Checked ? null : (DateTime?)dtpExitDate.Value;
        }

        private void LoadInstructorData()
        {
            _instructor = Instructor.Find(_instructorID, FindByOption.InstructorID);

            if (_instructor == null)
            {
                FormUtilities.ShowMessage($"No instructor with ID = {_instructorID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayStudentData();
        }

        private void DisplayStudentData()
        {
            ucPersonCardWithFilter1.LoadPersonData(_instructor.PersonID);

            txtInstructorID.Text = _instructorID.ToString();
            txtMonthlySalary.Text = _instructor.MonthlySalary.ToString();
            dtpHireDate.Value = _instructor.HireDate;
            dtpExitDate.Value = _instructor.ExitDate ?? dtpExitDate.Value;
        }

        private void UpdateFormState()
        {
            bool isAddNewMode = _mode == Mode.AddNew;

            lblTitle.Text = isAddNewMode ? "Add New Instructor" : "Update Instructor";
            ucPersonCardWithFilter1.FilterEnabled = isAddNewMode;

            btnNext.Enabled = !isAddNewMode;
            btnSave.Enabled = !isAddNewMode;
            tpWorkInfo.Enabled = !isAddNewMode;
        }

        private void InitializeForm()
        {
            dtpHireDate.MaxDate = _maximumHireDateAllowed;
            dtpHireDate.MinDate = _minimumHireDateAllowed;
            dtpHireDate.Value = _maximumHireDateAllowed;

            ckbIsStillEmployed.Checked = true;

            ucPersonCardWithFilter1.PersonSelected += PersonSelectedEventHandler;

            _instructor = _mode == Mode.AddNew ? new Instructor() : _instructor;

            UpdateFormState();
        }

        private void PersonSelectedEventHandler(object sender, int? personID)
        {
            if (personID == null)
                btnNext.Enabled = false;

            else if (_mode == Mode.AddNew && Instructor.DoesInstructorExist(personID, FindByOption.PersonID))
            {
                FormUtilities.ShowMessage("The person selected is already linked with another instructor , please select another one !", MessageBoxIcon.Error);
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
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Error);
                return;
            }

            SaveInstructorData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tcInstructorInfo.SelectedTab = tpWorkInfo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNext_EnabledChanged(object sender, EventArgs e)
        {
            tpWorkInfo.Enabled = btnNext.Enabled;
            btnSave.Enabled = btnNext.Enabled;
        }

        private void CkbIsStillEmployed_CheckedChanged(object sender, EventArgs e)
        {
            dtpExitDate.Enabled = !ckbIsStillEmployed.Checked;
        }

        private void TxtMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DtpExitDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpExitDate.Value < dtpHireDate.Value)
                SetValidationError(dtpExitDate, e, "Exit date is not valid !");
            else
                ClearValidationError(dtpExitDate, e);
        }

        private void DtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            dtpExitDate.MinDate = dtpHireDate.Value;
            dtpExitDate.MaxDate = DateTime.Now;
            dtpExitDate.Value = DateTime.Now;
        }

        private void TxtMonthlySalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text))
                SetValidationError(txtMonthlySalary, e, "This field is required !");

            else if (float.Parse(txtMonthlySalary.Text, NumberStyles.Float, CultureInfo.InvariantCulture) <= 0)
                SetValidationError(txtMonthlySalary, e, $"salary must be greater than zero");

            else
                ClearValidationError(txtMonthlySalary, e);
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
