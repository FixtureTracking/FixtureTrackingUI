using FixtureTracking.Entities.Dtos.User;
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
            await LoadUserList();
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            await RegisterUser();
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvUserList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            switch (clickedCell.OwningColumn.HeaderCell.Value)
            {
                case "Detail":
                    var userId = dgvUserList.Rows[e.RowIndex].Cells["clmUserId"];
                    MessageBox.Show(userId.Value.ToString());
                    break;

                default:
                    break;
            }
        }

        private async Task LoadUserList()
        {
            dgvUserList.Rows.Clear();
            dgvUserList.Refresh();

            var users = await UserService.GetList();

            users.ForEach(user =>
            {
                dgvUserList.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Email, user.CreatedAt, "Get Detail");
            });

            dgvUserList.Sort(dgvUserList.Columns["clmCreatedAt"], System.ComponentModel.ListSortDirection.Descending);
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

            cmbDepartment.SelectedItem = new { Display = "Staff", Value = 5 };
        }

        private async Task RegisterUser()
        {
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto()
            {
                BirthDate = dtpBirthdate.Value.Date,
                DepartmentId = (cmbDepartment.SelectedItem as dynamic).Value,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = "fixT123.", // TODO : random password -> send e-mail
                Username = txtUsername.Text
            };
            await AuthService.Register(userForRegisterDto);

            MessageBox.Show("User registered");
            await LoadUserList();
        }
    }
}
