using OnlineExamination_BusinessLayer;
using OnlineExaminationSystem.Global;
using System;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Administrator.People.UserControls
{
    public partial class UcPersonCardWithFilter : UserControl
    {
        public int? PersonID => ucPersonCard1.PersonID;
        public Person Person => ucPersonCard1.Person;

        private enum FindByOption { PersonID, NationalNo };
        private FindByOption _findPersonBy;

        public bool FilterEnabled
        {
            set
            {
                gbFilter.Enabled = value;

                if (value)
                    ActivateFilter();
            }

            get
            {
                return gbFilter.Enabled;
            }
        }


        public event EventHandler<int?> PersonSelected;

        protected virtual void OnPersonSelected(object sender, int? personID)
        {
            PersonSelected?.Invoke(sender, personID);
        }

        private void RaisePersonSelectedEvent()
        {
            OnPersonSelected(this, PersonID);
        }

        public UcPersonCardWithFilter()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void LoadPersonData<T>(byte index, T filterValue)
        {
            cbFilterByOptions.SelectedIndex = index;

            txtFilterValue.Text = Convert.ToString(filterValue);

            btnSearchPerson.PerformClick();
        }

        public void LoadPersonData(int? personID)
        {
            LoadPersonData(0, personID);
        }

        public void LoadPersonData(string NationalNo)
        {
            LoadPersonData(1, NationalNo);
        }

        private void BtnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                FormUtilities.ShowMessage("Please enter the person's ID / NationalNo !", MessageBoxIcon.Warning);
                return;
            }

            if (!SearchPerson())
                Reset();

            RaisePersonSelectedEvent();
        }

        private bool SearchPerson()
        {
            switch (_findPersonBy)
            {
                case FindByOption.PersonID:
                    return ucPersonCard1.LoadPersonData(int.Parse(txtFilterValue.Text.Trim()));

                case FindByOption.NationalNo:
                    return ucPersonCard1.LoadPersonData(txtFilterValue.Text.Trim());

                default:
                    return false;
            }
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson form = new FrmAddUpdatePerson();
            form.PersonAdded += PersonAddedEventHandler;
            form.ShowDialog();
        }

        private void PersonAddedEventHandler(object sender, int? personID)
        {
            txtFilterValue.Text = personID.ToString();

            btnSearchPerson.PerformClick();
        }

        private void CbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _findPersonBy = cbFilterByOptions.SelectedIndex == 0 ? FindByOption.PersonID : FindByOption.NationalNo;

            txtFilterValue.ResetText();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = cbFilterByOptions.SelectedIndex == 0 && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void TxtFilterValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                e.Cancel = true;
                txtFilterValue.Focus();
                errorProvider1.SetError(txtFilterValue, "This field is required !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        public void ActivateFilter()
        {
            txtFilterValue.Select();
        }
    }
}
