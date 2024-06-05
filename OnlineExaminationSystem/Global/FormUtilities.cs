using System.ComponentModel;
using System.Windows.Forms;

namespace OnlineExaminationSystem.Global
{
    public static class FormUtilities
    {
        public static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, icon.ToString(), MessageBoxButtons.OK, icon);
        }

        public static void SetValidationError(ref Control control , ref ErrorProvider errorProvider, ref CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            control.Focus();
            errorProvider.SetError(control, errorMessage);
        }

        public static void ClearValidationError(ref Control control, ref ErrorProvider errorProvider, ref CancelEventArgs e)
        {
            e.Cancel = false;
            errorProvider.SetError(control, null);
        }

    }
}
