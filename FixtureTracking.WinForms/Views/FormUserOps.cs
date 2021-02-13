using FixtureTracking.Entities.Dtos.User;
using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using FixtureTracking.WinForms.Utilities.Constants;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormUserOps : Form
    {
        private Guid _selectedUserId;
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

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var userIdCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmUserId)];
            var nameCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmName)];

            _selectedUserId = Guid.Parse(userIdCell.Value.ToString());
            switch (clickedCell.OwningColumn.Name)
            {
                case nameof(clmDebits):
                    var departmentCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmDepartment)];

                    FormDebitsOfUser formDebitsOfUser = new FormDebitsOfUser(_selectedUserId, nameCell.Value.ToString(), departmentCell.Value.ToString());
                    formDebitsOfUser.ShowDialog();
                    break;

                case nameof(clmDelete):
                    var usernameCell = dgvObjectList.Rows[e.RowIndex].Cells[nameof(clmUsername)];

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
                await DeleteUser(userId);
        }

        private async Task LoadUserList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();
            ClearInputs();

            var users = await UserService.GetList();
            users.ForEach(userDto =>
            {
                dgvObjectList.Rows.Add(userDto.User.Id, userDto.FullName, userDto.DepartmentName, userDto.User.Username, userDto.User.Email, userDto.User.UpdatedAt, "Debits", "Delete");
            });
            dgvObjectList.Sort(dgvObjectList.Columns[nameof(clmUpdatedAt)], System.ComponentModel.ListSortDirection.Descending);
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
            MessageBox.Show(Messages.UserRegistered);
            await LoadUserList();
        }

        private async Task DeleteUser(Guid userId)
        {
            await UserService.Delete(userId);
            MessageBox.Show(Messages.UserDeleted);
            await LoadUserList();
        }
    }
}
