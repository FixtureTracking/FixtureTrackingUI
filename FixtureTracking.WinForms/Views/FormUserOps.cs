using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormUserOps : Form
    {
        private Guid _selectedUserId;
        private List<UserForDetailDto> _users;
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
            var userIdCell = dgvUserList.Rows[e.RowIndex].Cells["clmUserId"];
            _selectedUserId = Guid.Parse(userIdCell.Value.ToString());
            switch (clickedCell.OwningColumn.HeaderCell.Value)
            {
                case "Debits":
                    // TODO : Debits (name) form
                    break;

                case "Delete":
                    var nameCell = dgvUserList.Rows[e.RowIndex].Cells["clmName"];
                    var usernameCell = dgvUserList.Rows[e.RowIndex].Cells["clmUsername"];

                    ShowDeleteDiaolog(_selectedUserId, nameCell.Value.ToString(), usernameCell.Value.ToString());
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
            _users = users;

            users.ForEach(userDto =>
            {
                dgvUserList.Rows.Add(userDto.User.Id, userDto.FullName, userDto.DepartmentName, userDto.User.Username, userDto.User.Email, userDto.User.CreatedAt, "Get Debits", "Delete");
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
