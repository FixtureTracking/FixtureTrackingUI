using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormSelectUser : Form
    {
        public Guid SelectedUserId { get; set; }
        public FormSelectUser()
        {
            InitializeComponent();
            SelectedUserId = new Guid();
        }

        private async void FormSelectUser_Load(object sender, EventArgs e)
        {
            await LoadUserList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadUserList();
        }

        private void dgvObjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedCell = dgvObjectList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (clickedCell.OwningColumn.HeaderCell.Value.ToString() == "Select")
            {
                var userIdCell = dgvObjectList.Rows[e.RowIndex].Cells["clmUserId"];
                SelectedUserId = Guid.Parse(userIdCell.Value.ToString());
                this.Close();
            }
        }

        private async Task LoadUserList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var users = await UserService.GetList();
            users.ForEach(userDto =>
            {
                dgvObjectList.Rows.Add(userDto.User.Id, userDto.FullName, userDto.DepartmentName, userDto.User.Username, userDto.User.Email, "SELECT");
            });
            dgvObjectList.Sort(dgvObjectList.Columns["clmName"], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
