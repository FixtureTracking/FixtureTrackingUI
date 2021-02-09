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

        private async void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvUserList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var userIdCell = dgvUserList.Rows[e.RowIndex].Cells["clmUserId"];
            Guid userId = Guid.Parse(userIdCell.Value.ToString());
            switch (clickedCell.OwningColumn.HeaderCell.Value)
            {
                case "Detail":
                    var userForDetailDto = await UserService.GetDetail(userId);
                    FormUserDetail formUserDetail = new FormUserDetail(userForDetailDto);
                    formUserDetail.ShowDialog();
                    break;

                case "Delete":
                    var firstNameCell = dgvUserList.Rows[e.RowIndex].Cells["clmFirstName"];
                    var lastNameCell = dgvUserList.Rows[e.RowIndex].Cells["clmLastName"];
                    var usernameCell = dgvUserList.Rows[e.RowIndex].Cells["clmUsername"];

                    var fullName = $"{firstNameCell.Value} {lastNameCell.Value}";
                    var username = usernameCell.Value.ToString();

                    ShowDeleteDiaolog(userId, fullName, username);
                    break;

                default:
                    break;
            }
        }

        private void ClearInputs()
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtUsername.ResetText();
            txtEmail.ResetText();
            dtpBirthdate.ResetText();
            cmbDepartment.ResetText();
        }

        private async void ShowDeleteDiaolog(Guid userId, string fullName, string username)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete this user?\r\n({fullName} - {username})", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                await DeleteUser(userId);
            }
        }

        private async Task LoadUserList()
        {
            dgvUserList.Rows.Clear();
            dgvUserList.Refresh();
            ClearInputs();

            var users = await UserService.GetList();

            users.ForEach(user =>
            {
                dgvUserList.Rows.Add(user.Id, user.FirstName, user.LastName, user.Username, user.Email, user.CreatedAt, "Get Detail", "Delete");
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

            MessageBox.Show("User registered.");
            await LoadUserList();
        }

        private async Task DeleteUser(Guid userId)
        {
            await UserService.Delete(userId);
            MessageBox.Show("User deleted.");
            ClearInputs();
            await LoadUserList();
        }
    }
}
