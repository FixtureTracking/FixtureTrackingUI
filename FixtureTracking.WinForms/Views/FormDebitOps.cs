using FixtureTracking.WinForms.Services.FixtureTrackingAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixtureTracking.WinForms.Views
{
    public partial class FormDebitOps : Form
    {
        private Guid _selectedFixtureId;
        private Guid _selectedUserId;
        public FormDebitOps()
        {
            InitializeComponent();
        }

        private async void FormDebitOps_Load(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private async void btnRefreshList_Click(object sender, EventArgs e)
        {
            await LoadDebitList();
        }

        private async Task LoadDebitList()
        {
            dgvObjectList.Rows.Clear();
            dgvObjectList.Refresh();

            var debits = await DebitService.GetList();
            debits.ForEach(debitDto =>
            {
                string dateReturn = debitDto.Debit.IsReturn ? debitDto.Debit.DateReturn.ToString() : "-";
                dgvObjectList.Rows.Add(debitDto.Debit.Id, debitDto.Debit.Description, debitDto.FixtureName, debitDto.UserFullName, debitDto.DepartmentName, debitDto.Debit.DateDebit, debitDto.Debit.IsReturn, dateReturn, "Delete");
            });
        }

        private void btnSlcFixture_Click(object sender, EventArgs e)
        {
            FormSelectFixture formSelectFixture = new FormSelectFixture();
            formSelectFixture.ShowDialog();
            _selectedFixtureId = formSelectFixture.SelectedFixtureId;
            if (_selectedFixtureId != Guid.Empty)
            {
                btnSlcFixture.Enabled = false;
                btnSlcFixture.Text = "Fixture selected";
            }
        }

        private void btnSlcUser_Click(object sender, EventArgs e)
        {
            FormSelectUser formSelectUser = new FormSelectUser();
            formSelectUser.ShowDialog();
            _selectedUserId = formSelectUser.SelectedUserId;
            if (_selectedUserId != Guid.Empty)
            {
                btnSlcUser.Enabled = false;
                btnSlcUser.Text = "User selected";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
