using System.Windows.Forms;

namespace OnlineExaminationSystem.Global
{
    public static class FormUtilities
    {
        public static void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, icon.ToString(), MessageBoxButtons.OK, icon);
        }

    }
}
