using System.Windows.Forms;

namespace FixtureTracking.WinForms.Utilities.FormTools
{
    public static class DeleteDiaolog
    {
        public static DialogResult Show(string objectName, string description)
        {
            return MessageBox.Show(
                $"Are you sure to delete this {objectName}?\r\n({description})",
                "Confirm Delete",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
        }
    }
}
