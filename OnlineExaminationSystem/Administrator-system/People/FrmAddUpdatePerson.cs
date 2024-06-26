﻿using Guna.UI2.WinForms;
using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using OnlineExaminationSystem.Properties;
using OnlineExaminationSystem_UtilityLayer;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.People
{
    public partial class FrmAddUpdatePerson : Form
    {
        private enum Mode : byte { AddNew, Update };
        private Mode _mode;

        private int? _personID = null;
        private Person _person = null;

        private readonly byte _maximumAgeAllowed = 65;
        private readonly byte _minimumAgeAllowed = 18;

        private readonly string destinationFolderPath = ConfigurationManager.AppSettings["projectImagesFolder"];

        public FrmAddUpdatePerson(int? personID)
        {
            InitializeComponent();
            _personID = personID;
            _mode = Mode.Update;
        }
        public FrmAddUpdatePerson()
        {
            InitializeComponent();
            _mode = Mode.AddNew;
        }

        public event EventHandler<int?> PersonAdded;

        private void RaisePersonAddedEvent()
        {
            OnPersonAdded(this, _personID);
        }

        protected virtual void OnPersonAdded(object sender, int? personID)
        {
            PersonAdded?.Invoke(sender, personID);
        }

        private void FrmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            InitializeForm();

            if (_mode == Mode.Update)
                LoadPersonData();
        }

        private bool SavePersonData()
        {
            if (!HandlePersonalImage())
                return false;

            UpdatePersonData();

            if (!_person.Save())
            {
                FormUtilities.ShowMessage("Person data is not saved successfully.", MessageBoxIcon.Error);
                return false;
            }

            else
            {
                FormUtilities.ShowMessage("Person data saved successfully !", MessageBoxIcon.Information);
                UpdateFormAfterSave();
                return true;
            }
        }

        private void UpdateFormAfterSave()
        {
            _mode = Mode.Update;
            _personID = _person.PersonID;
            txtPersonID.Text = _personID.ToString();
        }

        private void UpdatePersonData()
        {
            _person.FirstName = txtFirstName.Text.Trim();
            _person.LastName = txtLastName.Text.Trim();
            _person.NationalNo = txtNationalNo.Text.Trim();
            _person.Email = txtEmail.Text.Trim();
            _person.PhoneNumber = txtPhone.Text.Trim();
            _person.Gender = rbMale.Checked ? 'M' : 'F';
            _person.Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim();
            _person.BirthDate = dtpBirthDate.Value;
            _person.PersonalImagePath = pbPersonalImage.ImageLocation;
        }

        private void LoadPersonData()
        {
            _person = Person.Find(_personID);

            if (_person == null)
            {
                FormUtilities.ShowMessage($"No person with ID = {_personID} was found in the system !", MessageBoxIcon.Error);
                Close();
                return;
            }

            DisplayPersonData();
        }

        private void DisplayPersonData()
        {
            txtPersonID.Text = _personID.ToString();
            txtFirstName.Text = _person.FirstName;
            txtLastName.Text = _person.LastName;
            txtNationalNo.Text = _person.NationalNo;
            txtEmail.Text = _person.Email;
            txtPhone.Text = _person.PhoneNumber;
            txtAddress.Text = _person.Address ?? string.Empty;

            dtpBirthDate.Value = _person.BirthDate;

            rbMale.Checked = _person.GenderText == Person.GenderType.Male;

            rbFemale.Checked = !rbMale.Checked;

            if (_person.PersonalImagePath != null)
                pbPersonalImage.ImageLocation = _person.PersonalImagePath;

            llbRemoveImage.Visible = pbPersonalImage.ImageLocation != null;
        }

        private void SetAgeRangeLimits()
        {
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-_minimumAgeAllowed);
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-_maximumAgeAllowed);
            dtpBirthDate.Value = dtpBirthDate.MaxDate;
        }

        private void InitializeForm()
        {
            if (_mode == Mode.AddNew)
                _person = new Person();

            lblTitle.Text = _mode == Mode.AddNew ? "Add New Person" : "Update Person";

            rbMale.Checked = true;

            pbPersonalImage.Image = Resources.man;

            SetAgeRangeLimits();
        }

        private bool HandlePersonalImage()
        {
            if (_person.PersonalImagePath != pbPersonalImage.ImageLocation)
            {
                if (_person.PersonalImagePath != null)
                {
                    try
                    {
                        File.Delete(_person.PersonalImagePath);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
                        FormUtilities.ShowMessage("An error occured while trying to replace the person's old personal image", MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (pbPersonalImage.ImageLocation != null)
                {
                    try
                    {
                        string sourceFilePath = pbPersonalImage.ImageLocation;

                        if (Utility.CopyImageToProjectImagesFolder(ref sourceFilePath, destinationFolderPath))
                            pbPersonalImage.ImageLocation = sourceFilePath;

                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError(ex);
                        FormUtilities.ShowMessage("An error occured while trying to save the person's new personal image", MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            return true;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Some fields are not valid. Please check the red icon(s) for details.", MessageBoxIcon.Warning);
                return;
            }

            if (SavePersonData())
                RaisePersonAddedEvent();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void LlbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonalImage.ImageLocation = openFileDialog1.FileName;
                llbRemoveImage.Visible = true;
            }
        }

        private void LlbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonalImage.ImageLocation = null;
            pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
            llbRemoveImage.Visible = false;
        }

        private void RbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonalImage.ImageLocation == null)
            {
                pbPersonalImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))

                SetValidationError(txtEmail, e, "This field is required !");

            else if (!Validation.IsValidEmailAddress(txtEmail.Text))
                SetValidationError(txtEmail, e, "This email format is not valid !");


            else if (_person.Email != txtEmail.Text && Person.DoesPersonExist(txtEmail.Text, Person.FindByOption.Email))
                SetValidationError(txtEmail, e, "This email address is already in use !");

            else
                ClearValidationError(txtEmail, e);
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text))
                SetValidationError(textBox, e, "This field is required !");

            else
                ClearValidationError(textBox, e);
        }

        private void TxtNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
                SetValidationError(txtNationalNo, e, "This field is required !");

            else if (_person.NationalNo != txtNationalNo.Text && Person.DoesPersonExist(txtNationalNo.Text, Person.FindByOption.NationalNo))
                SetValidationError(txtNationalNo, e, "This nationalNo is already taken by another person!");

            else
                ClearValidationError(txtNationalNo, e);
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
