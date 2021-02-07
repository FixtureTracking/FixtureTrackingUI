using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormUserOps : Form
    {
        public FormUserOps()
        {
            InitializeComponent();
        }

        private async void FormUserOps_Load(object sender, EventArgs e)
        {
            await LoadUserList();
            await LoadDepartmentComboBox();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            dgvUserList.Rows.Clear();
            dgvUserList.Refresh();
            await LoadUserList();
        }

        private async Task LoadUserList()
        {
            var users = await UserService.GetList();

            users.ForEach(user =>
            {
                dgvUserList.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Email);
            });
        }

        private async Task LoadDepartmentComboBox()
        {
            var departments = await DepartmentService.GetList();

            cmbDepartment.DisplayMember = "Display";
            cmbDepartment.ValueMember = "Value";

            departments.ForEach(department =>
            {
                cmbDepartment.Items.Add(new { Display = department.Name, Value = department.Id });
            });
        }
    }
}
